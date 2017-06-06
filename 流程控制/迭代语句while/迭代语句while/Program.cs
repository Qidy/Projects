using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 迭代语句while
{
    class Program
    {
        //迭代语句是在程序中重复执行，知道满足条件才停止
        /* 1.while
         * 2.do....while..
         * 3.for
         * 4.foreach
         * 
        */
        static void Main(string[] args)
        {
            Console.WriteLine("输出50个数字");
            int var = 1;
            while (var <= 50)
            {
                Console.WriteLine(var);
                var++;
            }

            //for循环
            Console.WriteLine("输出50个数字");
            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine(i);
            }
            
            Console.ReadKey();
        }
    }
}
