using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 迭代do._.@while
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            do
            {
                num++;
                Console.WriteLine(num);

            }
            while (num <= 50);
            Console.ReadKey();

        }
    }
}
