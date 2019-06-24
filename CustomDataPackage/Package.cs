/* 
 * Copyright (C) 2019 Antikerlab Africa - All Rights Reserved
 * You may use, distribute and modify this code under the
 * terms of the Antikerlab Africa Public Source license.
 *
 * You should have received a copy of the license with
 * this file. If not, please write to: license@antikerlab.africa , or visit : http://license.antikerlab.africa
 *
 * Copyright (C) 2019 Peter Naambo
 * File: Package.cs
 */
using System;

namespace CDP
{
    [Serializable]
    internal class Package
    {
        public byte Header { get; set; }
        public string Version { get; set; }
        public byte Authentification { get; set; }
        public string Payload { get; set; }
    }
}
