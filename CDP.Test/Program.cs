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
                //Init DataPackageCreator
                CreateDataPackage createDataPackage = new CreateDataPackage(0x1A, "TestVersion2", 0x2A, "Test Payload");
                var data = createDataPackage.CreatePackage();


                //Init DataPackageReader
                ReadDataFromPackage Data = new ReadDataFromPackage(data);
                Console.WriteLine(Data.GetHeader());
                Console.WriteLine(Data.GetVersion());
                Console.WriteLine(Data.GetAuth());
                Console.WriteLine(Data.GetPayload());

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }





           
        }
    }
}
