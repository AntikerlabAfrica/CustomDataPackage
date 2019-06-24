/* 
 * Copyright (C) 2019 Antikerlab Africa - All Rights Reserved
 * You may use, distribute and modify this code under the
 * terms of the Antikerlab Africa Public Source license.
 *
 * You should have received a copy of the license with
 * this file. If not, please write to: license@antikerlab.africa , or visit : http://license.antikerlab.africa
 *
 * Copyright (C) 2019 Peter Naambo
 * File: API.cs
 */
namespace CDP
{
    public class DataPackage
    { 
        public DataPackage(byte Header, string Version, byte Auth, string Payload)
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

        public byte[] Create()
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

    public class ReadPackage
    {
        public ReadPackage(byte[] PKG)
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
