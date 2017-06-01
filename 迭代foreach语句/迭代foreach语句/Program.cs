using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 迭代foreach语句
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个英文句子");
            string str = Console.ReadLine();
            foreach (char item in str)
            {
                if (char.IsWhiteSpace(item))
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(item);
                }
            }
            Console.ReadKey();
        }
    }
}
