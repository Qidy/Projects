using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串合并
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                1.符号+
                2.sting.concat
                3. sting.join

             */
            //第一种方法
            Console.WriteLine("字符串的合并");
            string a = "51zxw";
            string b = "C#";
            Console.WriteLine(a + b);
            //第二种方法
            string mystr = "51zxw";
            string mystr1 = "C#";
            string mystr2= string.Concat(mystr, mystr1);
            Console.WriteLine(mystr2);
            //第三种方法
            string[] mystring = { "51zxw", "C#"};
            //合并中添加符号
            string mychangestr = string.Join("**", mystring);
            Console.WriteLine(mychangestr);
            Console.ReadKey();
           



        }
    }
}
