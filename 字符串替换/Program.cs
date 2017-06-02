using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串替换
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用Replace来实现，非静态方法
            //字符串.Replace(要替换的源字符串，替换后的字符串)
            string mysting = "http://www.baidu.com";
            string newstring = mysting.Replace('w','W');
            char[] a = mysting.ToCharArray();
            Array.Reverse(a);
            foreach (char item in a)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            Console.WriteLine(mysting);
            Console.WriteLine(newstring);
            Console.ReadKey();



        }
    }
}
