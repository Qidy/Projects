using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static string myString;

        //static int Add(params int[] nums)
        //{
        //    int sum = 0;
        //    foreach (int outnum in nums) sum += outnum;
        //    {

        //        return sum;
        //    }
        //}


        static int MaxValue(int[] intArray)
        {
            int Maxval = intArray[0];
            for (int i = 1; i < intArray.Length; i++)
            {
                if (intArray[i] > Maxval)
                    Maxval = intArray[i];
            }
            return Maxval;
        }

        static void write()
        {
            string Mystring = "this is a Write()";
            Console.WriteLine("now is Write()");
            Console.WriteLine("Mystring is {0}", Mystring);
            Console.WriteLine("Mystring is {0}", Program.myString);

        }

        static void Main(string[] args)
        {

            int[] Myarray = { 1,4,6,7,8,9};
            int Maxval = MaxValue(Myarray);
            Console.WriteLine(Maxval);
            Console.ReadKey();


            Program.myString = "Global myString";
            //int[] Myarray = { 3, 6, 7, 8, 9 };
            //Console.WriteLine(Add(Myarray));
            //Console.ReadKey();
            write();
            string Mystring = "this is a Main()";
            Console.WriteLine("now is Main()");
            Console.WriteLine("Mystring is {0}", Mystring);
            Console.WriteLine("Mystring is {0}", Program.myString);
            Console.ReadKey();
        }
    }
}
