using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组排序
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myint = { 0, 2, 3, 5, 7, 8, 10, 15, 17, 19, 20, 30, 50, 80, 100, 150 };
            Array.Sort(myint);
            Console.WriteLine("Array.Sort():");
            foreach (int item in myint)
            {
                
                Console.Write(item+ " ");
            }
            Console.WriteLine();
            Array.Reverse(myint);
            Console.WriteLine("Array.Reverse():");
            foreach (int outint in myint)
            {
               
                Console.Write(outint+ " ");
            }

            Console.ReadKey();
        }
    }
}
