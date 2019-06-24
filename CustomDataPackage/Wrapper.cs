using System;
using System.Reflection;

namespace CDP
{
    public static class DataPackage
    { 

        public static byte[] Package(byte h, string v, byte a, string p)
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

        public static object Package(byte[] pkg)
        {
            return Converters.ToObject(pkg);
        }


        public static byte GetHeader(object pkg)
        {
         return (byte)pkg.GetType().GetProperty("Header").GetValue(pkg);
        }

        public static string GetVersion(object pkg)
        {
            return pkg.GetType().GetProperty("Version").GetValue(pkg).ToString();
        }

        public static byte GetAuth(object pkg)
        {
            return (byte)pkg.GetType().GetProperty("Authentification").GetValue(pkg);
        }

        public static string GetPayload(object pkg)
        {
            return pkg.GetType().GetProperty("Payload").GetValue(pkg).ToString();
        }
    }
}
