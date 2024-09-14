using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace NagMe.Cryptography
{
    // -----------------------------------------------------------------------------
    // This class was generated with assistance from ChatGPT (OpenAI).
    // -----------------------------------------------------------------------------
    public class CredentialManager
    {
        private static CredentialManager? _current = null;

        public static CredentialManager Current
        {
            get
            {
                if (_current == null)
                {
                    _current = new CredentialManager();
                }

                return _current;
            }
        }

        public void SetCredential(
            string key,
            string credential)
        {
            var secureCredential = new SecureString();
            foreach (char c in credential)
            {
                secureCredential.AppendChar(c);
            }

            var credentialBlob = Encoding.UTF8.GetBytes(credential);
            var credentialStruct = new Interop.Win32.NativeCredential
            {
                Type = Interop.Win32.CredentialType.Generic,
                TargetName = key,
                CredentialBlobSize = (uint)credentialBlob.Length,
                CredentialBlob = Marshal.StringToCoTaskMemUni(credential),
                Persist = Interop.Win32.CredentialPersistence.LocalMachine,
                AttributeCount = 0,
                Comment = null,
                TargetAlias = null,
                UserName = null
            };

            var success = Interop.Win32.CredWrite(ref credentialStruct, 0);
            Marshal.FreeCoTaskMem(credentialStruct.CredentialBlob);

            if (!success)
            {
                throw new Exception("Failed to save credential.");
            }
        }

        public string GetCredential(string key)
        {
            IntPtr credPointer;

            var success = Interop.Win32.CredRead(key, Interop.Win32.CredentialType.Generic, 0, out credPointer);
            if (!success || credPointer == IntPtr.Zero)
            {
                throw new Exception("Credential not found.");
            }

            var credential = Marshal.PtrToStructure<Interop.Win32.NativeCredential>(credPointer);
            var credentialBlob = Marshal.PtrToStringUni(credential.CredentialBlob, (int)credential.CredentialBlobSize / 2);

            Interop.Win32.CredFree(credPointer);
            return credentialBlob;
        }

        public void RemoveCredential(string key)
        {
            // !!! Do we need to handle the return value?
            Interop.Win32.CredDelete(key, Interop.Win32.CredentialType.Generic, 0);
        }
    }
}
