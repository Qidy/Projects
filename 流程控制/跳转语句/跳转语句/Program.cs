﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 跳转语句 //break
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输出1-500的数字");
            for (int i = 1; i < 501; i++)
            {
                if ((i % 2 == 0) && (i % 3 == 0) && (i % 4 == 0) && (i % 5 == 0) && (i % 6 == 0) && (i % 7 == 0))
                {
                    Console.Write(i);
                    break;
                }
                if (i % 10 == 0) Console.WriteLine(i);
                else
                {
                    Console.Write(i + " ");
                    if (i < 10) Console.Write(" ");
                    if (i < 100) Console.Write(" ");

                }
            }
            Console.ReadKey();
        }
    }
}
