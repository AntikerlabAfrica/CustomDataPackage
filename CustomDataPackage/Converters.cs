using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;

namespace CDP
{
     internal static class Converters
    {
        internal static byte[] ToArray(Object obj)
        {

            Encryption encryption = new Encryption();
            if (obj == null) return null;
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, obj);
            byte[] data = encryption.Encrypt(ms.ToArray(), "2LSC0A83", "9SL40DW2");
            return data;
        }


        internal static Object ToObject(byte[] arr)
        {
            Encryption encryption = new Encryption();
            MemoryStream memStream = new MemoryStream();
            BinaryFormatter binForm = new BinaryFormatter();
            var decrptedmem = encryption.Decrypt(arr, "2LSC0A83", "9SL40DW2");
            memStream.Write(decrptedmem, 0, decrptedmem.Length);
            memStream.Seek(0, SeekOrigin.Begin);
            Object obj = (Object)binForm.Deserialize(memStream);
            return obj;
        }




    }
}
