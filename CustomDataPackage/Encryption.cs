/* 
 * Copyright (C) 2019 Antikerlab Africa - All Rights Reserved
 * You may use, distribute and modify this code under the
 * terms of the Antikerlab Africa Public Source license.
 *
 * You should have received a copy of the license with
 * this file. If not, please write to: license@antikerlab.africa , or visit : http://license.antikerlab.africa
 *
 * Copyright (C) 2019 Peter Naambo
 * File: Encryption.cs
 */

using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CDP
{
    public class Encryption
    {
        private byte[] Crypto(ICryptoTransform cryptoTransform, byte[] data)
        {
            using (var memoryStream = new MemoryStream())
            {
                using (var cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write))
                {
                    cryptoStream.Write(data, 0, data.Length);
                    cryptoStream.FlushFinalBlock();
                    return memoryStream.ToArray();
                }
            }
        }

        public byte[] Encrypt(byte[] data, string key, string iv)
        {
            DESCryptoServiceProvider cryptic = new DESCryptoServiceProvider
            {
                Key = Encoding.UTF8.GetBytes(key),
                IV = Encoding.UTF8.GetBytes(iv)
            };

            return Crypto(cryptic.CreateEncryptor(), data);

        }

        public byte[] Decrypt(byte[] data, string key, string iv)
        {
            DESCryptoServiceProvider cryptic = new DESCryptoServiceProvider
            {
                Key = Encoding.UTF8.GetBytes(key),
                IV = Encoding.UTF8.GetBytes(iv)
            };
            return Crypto(cryptic.CreateDecryptor(), data);
        }
    }
}
