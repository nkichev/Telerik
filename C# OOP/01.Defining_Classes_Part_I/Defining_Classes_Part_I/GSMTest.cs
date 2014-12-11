//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Defining_Classes_Part_I
//{
//    public class GSMTest
//    {
//        static void Main(string[] args)
//        {
//            GSM[] gsms = new GSM[] 
//            { 
//                new GSM("N92", "Nokia"),
//                new GSM("Sony Ericson", "Sony", 200, "Pesho", new Battery("model1", 20,5,BatteryType.Li_Ion),new Display(3,256)),
//                new GSM("Galaxy S3III", "Samsung", 400, "Goro", new Battery("model4", 22,7,BatteryType.NiCd),new Display(4,1024)),
//                new GSM("N92", "Nokia", 270, "Ivan", new Battery("model2", 20,5,BatteryType.Li_Ion),new Display()),
//                new GSM("Galaxy S3III", "Samsung", 150, "Stoyan", new Battery(),new Display(7,512)),               

//            };
//            foreach (var gsm in gsms)
//            {
//                Console.WriteLine(gsm.ToString());
//                Console.WriteLine();
//            }

//            Console.WriteLine(GSM.IPhone4S);
//        }
//    }
//}