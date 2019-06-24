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
