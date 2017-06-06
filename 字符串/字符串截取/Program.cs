using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串截取
{
    class Program
    {
        static void Main(string[] args)
        {
            //字符串.Substring 整数（截取位置，）
            string mystr = "0123456789";
            string mystr1 = mystr.Substring(5);
            //字符串.Substring(整数1,整数2 )（保留两数之间进行保留）
            string mystr2 = mystr.Substring(1, 5);
            Console.WriteLine(mystr1);
            Console.WriteLine(mystr2);

            Console.WriteLine("请输入一个单子，不区分大小写");
            string mystring1 = Console.ReadLine();
            //截取输入的首字幕
            string first = mystring1.Substring(0, 1);
            //截取输入首字母后的字符串，并转换小写字幕
            string other = mystring1.Substring(1).ToLower();
            //输出，截取首字母转换大写+截取后其他字符串
            Console.WriteLine(first.ToUpper() + other);
            Console.ReadKey();

        }
    }
}
