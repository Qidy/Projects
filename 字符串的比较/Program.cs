using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串的比较
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            比较方法
            1. ==
            2. equals方法Equals(字符串1，字符串2) 返回布尔值
            3.  compare方法Compare(字符串1，字符串2,布尔值*忽略大小写*) 返回值是一个整数
            小于0     字符串1小于字符串2
            等于0     字符串1等于字符串2
            大于0     字符串1大于字符串2，或者字符串2为null引用             
             */

            string mystring = "Hello";
            string mystring1 = "HELLO";
            //比较之后返回布尔值
            Console.WriteLine(string.Equals(mystring, mystring1));
            //比较之后返回一个数值（e>i）
            Console.WriteLine(string.Compare(mystring, mystring1, true));
            Console.WriteLine(mystring.CompareTo(mystring1));
            Console.ReadKey();


        }
    }
}
