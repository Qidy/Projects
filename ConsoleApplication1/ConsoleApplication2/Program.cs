using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void write(int num)
        {
            int a = 1;
            for (int i = num; i > 0; i--) a *= i;
            Console.WriteLine("{0}的阶乘是{1}", num, a);

        }
        static int add(int a, int b)
        {
            return a + b;
        }
        static double radio(double d)
        {
            const double pi = 3.1415926;
            return d * d * pi;
        }

        static int Addsa(params int[] nums)
        {
            int sum = 0;
            foreach (int outnum in nums)
            {
                sum += outnum;
            }

            return sum;

        }
        static void Main(string[] args)
        {

            write(8);
            write(7);
            write(6);
            write(5);
            int c = add(3, 5);
            double f = radio(5);
            Console.WriteLine(f);
            Console.WriteLine(c);

            int[] Myarray = { 1, 2, 3, 4, 5, 67, 78 };
            Console.WriteLine(Addsa(Myarray));
            Console.ReadKey();


        }
    }
}
