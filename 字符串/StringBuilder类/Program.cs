using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder类
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             1. 引入命名空间system.Text
             2. 通过New关键字初始化
             3.           
             */

            StringBuilder mystringbuilder =new StringBuilder("http://www.baidu.com");
            Console.WriteLine("================Append===================");
            //追加对应的字符串
            Console.WriteLine(mystringbuilder.Append("\t"+"一个神奇网站"));
            Console.WriteLine("================Insert===================");
            //对应位置插入制定的字符串
            Console.WriteLine(mystringbuilder.Insert(20,"\n"));
            Console.WriteLine("================Remove===================");
            //移除从索引开始位置的N个字符
            Console.WriteLine(mystringbuilder.Remove(20,1));
            Console.WriteLine("================Replace===================");
            Console.WriteLine(mystringbuilder.Replace("神奇","强大"));
            Console.WriteLine("================AppendFormat===================");
            //按照指定的格式来添加字符串
            int savemoney = 2000;
            Console.WriteLine(mystringbuilder.AppendFormat(",为我省了{0:C}", savemoney));
            Console.WriteLine("================AppendLine===================");
            Console.WriteLine(mystringbuilder.AppendLine("自动换行"));
            Console.ReadKey();
        }
    }
}
