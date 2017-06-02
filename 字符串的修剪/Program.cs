using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串的修剪
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             字符串修剪使用Trim()来实现
             
             */
            string name = "     user     ";
            Console.WriteLine(name+"|");
            Console.WriteLine(name.Trim()+"|");

            //字符串修剪使用TrimEnd来实现
            Console.WriteLine(name.TrimEnd() + "|");

            //字符串修剪使用TrimStart()来实现
            Console.WriteLine(name.TrimStart() + "|");

            string weburl = "#%http://www.baidu.com#%";
            Console.WriteLine(weburl.Trim('#', '%'));

            Console.WriteLine(weburl.Trim("#%".ToCharArray()));

            Console.ReadKey();



        }
    }
}
