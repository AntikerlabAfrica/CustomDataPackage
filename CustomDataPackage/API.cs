using System;
using System.Reflection;

namespace CDP
{
    public class CreateDataPackage
    { 
        public CreateDataPackage(byte Header, string Version, byte Auth, string Payload)
        {
            h = Header;
            v = Version;
            a = Auth;
            p = Payload;
        }

        internal byte h;
        internal string v;
        internal byte a;
        internal string p;

        public byte[] CreatePackage()
        {
            Package package = new Package
            {
                Header = h,
                Version = v,
                Authentification = a,
                Payload = p
            };
            return Converters.ToArray(package);
        }

    }

    public class ReadDataFromPackage
    {
        public ReadDataFromPackage(byte[] PKG)
        {
            pkg = PKG;
        }

        internal static byte[] pkg;


        internal static object Package()
        {
            return Converters.ToObject(pkg);
        }


        public byte GetHeader()
        {
            return (byte)Package().GetType().GetProperty("Header").GetValue(Package());
        }

        public string GetVersion()
        {
            return Package().GetType().GetProperty("Version").GetValue(Package()).ToString();
        }

        public byte GetAuth()
        {
            return (byte)Package().GetType().GetProperty("Authentification").GetValue(Package());
        }

        public string GetPayload()
        {
            return Package().GetType().GetProperty("Payload").GetValue(Package()).ToString();
        }
    }
}
