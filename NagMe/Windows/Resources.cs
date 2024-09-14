using System.Reflection;

namespace NagMe.Windows
{
    public static class Resources
    {
        public static Icon? LoadIconFromEmbeddedResource(string key)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            using (Stream? stream = assembly.GetManifestResourceStream(key))
            {
                if (stream != null)
                {
                    Icon icon = new(stream);
                    return icon;
                }

                return null;
            }
        }
    }
}
