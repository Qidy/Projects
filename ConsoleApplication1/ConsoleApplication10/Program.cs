using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Multiple(int num)
        {
            Console.WriteLine("{0}的乘法表是：", num);

            for (int i = 1; i <= num; i++)
            {
                if (num % i != 0) continue;

                else
                {
                    Console.WriteLine("{0,2} * {1,2}={2,2}", i, num / i, num);
                }
            }


        }
        static void Add(int num)
        {
            Console.WriteLine("{0}的加法表是：", num);
            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine("{0,2}+{1,2}={2,2}", i, num - i, num);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter You Number:");
            int Number = Convert.ToInt32(Console.ReadLine());
            Multiple(Number);
            Add(Number);
            Console.ReadKey();

        }
    }
}
