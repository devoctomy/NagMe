using Microsoft.AspNetCore.DataProtection;
using System.Text;

namespace NagMe.Cryptography
{
    public class StringProtector
    {
        private readonly IDataProtector _protector;

        public StringProtector(string applicationName, string purpose)
        {
            var dataProtectionProvider = DataProtectionProvider.Create(applicationName);
            _protector = dataProtectionProvider.CreateProtector(purpose);
        }

        public string Encrypt(string plaintext)
        {
            byte[] plaintextBytes = Encoding.UTF8.GetBytes(plaintext);
            byte[] encryptedBytes = _protector.Protect(plaintextBytes);
            string encryptedText = Convert.ToBase64String(encryptedBytes);
            return encryptedText;
        }

        public string Decrypt(string encryptedText)
        {
            byte[] encryptedBytes = Convert.FromBase64String(encryptedText);
            byte[] decryptedBytes = _protector.Unprotect(encryptedBytes);
            string plaintext = Encoding.UTF8.GetString(decryptedBytes);
            return plaintext;
        }
    }
}