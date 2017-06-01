using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 大小写转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //声明字符串并赋值
            string mystring = "hello";
            string mystring1 = "HELLO";
            //输出并转换为大写
            Console.WriteLine(mystring.ToUpper());
            //输出并转换为小写
            Console.WriteLine(mystring1.ToLower());
            //与char转换区别
            char mychar = 'a';
            Console.WriteLine(char.ToLower(mychar));
            Console.WriteLine(char.ToUpper(mychar));
            Console.ReadKey();
        }
    }
}
