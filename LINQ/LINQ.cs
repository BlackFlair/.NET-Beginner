//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LINQ
//{
//    class LINQ
//    {
//        static void Main(string[] args)
//        {
//            string[] names = { "Raze", "Omen", "Astra", "Reyna", "Jett", "Sage", "Sova" };

//            var nameWithR = from name in names
//                            where name.Contains("R")
//                            select name;

//            var nameWithS = names.Where(name => name.Contains("S"));

//            Console.WriteLine("Name with R");
//            print(nameWithR.ToArray());
//            Console.WriteLine("\r\nName with R");
//            print(nameWithS.ToArray());


//        }

//        public static void print(string[] names)
//        {
//            foreach (string name in names)
//                Console.WriteLine(name);
//        }
//    }
//}
