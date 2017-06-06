using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 跳转语句_concontinue语句
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("50以内的奇数有");
            for (int i = 0; i < 51; i++)
            {
                if (i % 2 == 0)
                {
                    //continue语句停止本次迭代，并没有跳出迭代语句
                    //continue只能用在迭代语句中
                    continue;
                }
                //Console.Write(i + "\t");
                Console.Write(i + "  ");
            }
            Console.ReadKey();
        }
    }
}
