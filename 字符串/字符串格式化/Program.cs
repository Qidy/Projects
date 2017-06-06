using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串格式化
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Format
                 string.Format(要转换的格式，格式化对象)；
                 string.Format(要转换的格式，格式化对象1,格式化对象2)；
                  
             C      适用于数字类型              专用场合的或壁纸
             D      只用与整数乐行              一般整数
             E      数字类型                    科学记数法
             F      数字类型                    小数点后的位数固定
             G      数字类型                    一般整数
             N      数字类型                    通用场合数字格式
             P      数字类型                    百分数
             X      只用与整数类型              十六进制格式
             */

            //Console.WriteLine("{0:C}", 21.3);

            Console.WriteLine("字符串的格式化输出");
            string str = string.Format("默认格式：======={0}\n"+"使用C格式{0:C}\n"+ "使D格式{0:D}\n"+ "使用E格式{1:E}\n"+ "使用F格式{1:F}\n"+ "使用G格式{0:G}\n"+ "使用N格式{0:N}\n"+ "使用P格式{0:P}\n" + "使用X格式{0:X}\n",2100,2100.33);
            Console.WriteLine(str);

            for (int i = 0; i < 50; i++)
            {
                //声明变量并制定格式化类型，将循环值格式化
                string mystring = string.Format("{0:D3}", i);
                Console.WriteLine(mystring);
            }
            Console.ReadKey();




        }
    }
}
