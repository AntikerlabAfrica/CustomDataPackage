using System;

namespace CDP.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Init DataPackageCreator
                DataPackage createDataPackage = new DataPackage(0x1A, "TestVersion", 0x2A, "Test Payload");
                var data = createDataPackage.Create();


                //Init DataPackageReader
                ReadPackage Data = new ReadPackage(data);
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
