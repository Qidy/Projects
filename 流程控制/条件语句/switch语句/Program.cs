using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch分支语句
{
    class Program
    {
        static void Main(string[] args)
        {
            // int roll= int.Parse(Console.ReadLine());
            Random kk = new Random();
           int roll = kk.Next(1,7);
            switch (roll)
            {
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("2");
                    break;
                case 3:
                    Console.WriteLine("3");
                    break;
                case 4:
                    Console.WriteLine("4");
                    break;
                case 5:
                    Console.WriteLine("5");
                    break;
                case 6:
                    Console.WriteLine("6");
                    break;
                default:
                    Console.WriteLine("输入错误");
                    break;



            }
            Console.ReadKey();
        }
    }
}
