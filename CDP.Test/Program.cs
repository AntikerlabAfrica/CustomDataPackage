using System;
using System.ComponentModel;

namespace CDP.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var data = DataPackage.Package(0x1A, "TestVersion", 0x2A, "Test Payload");
                var obj = DataPackage.Package(data);
                Console.WriteLine(DataPackage.GetHeader(obj));
                Console.WriteLine(DataPackage.GetVersion(obj));
                Console.WriteLine(DataPackage.GetAuth(obj));
                Console.WriteLine(DataPackage.GetPayload(obj));

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }





           
        }
    }
}
