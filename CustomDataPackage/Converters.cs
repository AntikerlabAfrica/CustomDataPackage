/* 
 * Copyright (C) 2019 Antikerlab Africa - All Rights Reserved
 * You may use, distribute and modify this code under the
 * terms of the Antikerlab Africa Public Source license.
 *
 * You should have received a copy of the license with
 * this file. If not, please write to: license@antikerlab.africa , or visit : http://license.antikerlab.africa
 *
 * Copyright (C) 2019 Peter Naambo
 * File: Converters.cs
 */

using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CDP
{
     internal static class Converters
    {
        internal static byte[] ToArray(Object package)
        {

            Encryption encryption = new Encryption();
            if (package == null) return null;
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, package);
            byte[] data = encryption.Encrypt(ms.ToArray(), "2LSC0A83", "9SL40DW2");
            return data;
        }


        internal static Object ToObject(byte[] data)
        {
            Encryption encryption = new Encryption();
            MemoryStream memStream = new MemoryStream();
            BinaryFormatter binForm = new BinaryFormatter();
            var decrptedmem = encryption.Decrypt(data, "2LSC0A83", "9SL40DW2");
            memStream.Write(decrptedmem, 0, decrptedmem.Length);
            memStream.Seek(0, SeekOrigin.Begin);
            Object package = (Object)binForm.Deserialize(memStream);
            return package;
        }




    }
}
