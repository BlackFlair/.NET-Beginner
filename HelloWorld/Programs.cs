using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libs;

namespace HelloWorld
{
    public class Programs
    {
        static void Main(string[] args)
        {
            //List<int> input = new List<int>() { 1, 2, 1, 2, 3, 4 };
            //count(input);

            //list();

            //Test t = new Test();
            //t.test();

            //test();

            //findPairs();

            //secondLargest();
        }

        public string count(List<int> x)
        {
            List<int> a = x;

            List<int> b = new List<int>();

            string result = "";

            for(int i = 0; i < a.Count; i++)
            {
                if (!b.Contains(a[i]))
                {
                    b.Add(a[i]);

                    int count = 1;

                    for (int j = i + 1; j < a.Count; j++)
                        if (a[i] == a[j])
                            count += 1;

                    result = result + a[i] + " appears " + count + " times" + Environment.NewLine;
                }
            }

            return result;
        }

        public static void list()
        {
            List<string> cars = new List<string> { "Lamborghini", "Ferrari", "Tesla", "Audi", "Toyoto", "Mercedes", "McLaren", "Volvo", "Jaguar", "BMW" };

            String max = "", min = "qwertyuiop";

            foreach (string car in cars)
                if (car.Length > max.Length)
                    max = car;

            foreach (string car in cars)
                if (car.Length < min.Length)
                    min = car;

            Console.WriteLine("Max: " + max);
            Console.WriteLine("Min: " + min);

            Console.WriteLine("With wif");
            foreach (string car in cars)
            {
                if (car.Contains("wif"))
                    Console.WriteLine(car);
            }

            Console.WriteLine("Without a");
            foreach (string car in cars)
                if (!car.Contains("a") && !car.Contains("A"))
                    Console.WriteLine(car);
        }

        //private static void findPairs() //unfinished
        //{
        //    int[] a = { 3, 3,3,3, 1,  4, 5, 2,2 };
        //    int  y=0, q;

        //    Array.Sort(a);

        //    for(int i=0; i < a.Length-1; i++)
        //    {
        //        if (a[i] == a[i + 1])
        //        {
        //            int x = 1;
        //            x += 1;
        //            q = x / 2;
        //        }
        //        if (q > 0)
        //        {
        //            y += q;
        //        }
        //    }

        //    Console.WriteLine(y);
        //}

        private static void test()
        {
            string username = null;
            string password = null;

            Console.Write("Enter Username: ");
            username = Console.ReadLine();

            Console.Write("Enter Password: ");
            password = Console.ReadLine();

            double charges = 5000; //5000
            DateTime dateTime = DateTime.Now;

            if (username == "raj" && password == "1234")
            {
                Console.Write($"Hello {username}, We paid you Rs.{charges} on ");
                Console.WriteLine(String.Format("{0:d}", dateTime));
            }
        }

        private static void secondLargest()
        {
            int[] arr = { 1, 6, 8, 2, 4, 5, 7, 9, 0 };
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("The Second largest number is:");
            Console.WriteLine(arr[arr.Length - 1]);
        }
    }
}
