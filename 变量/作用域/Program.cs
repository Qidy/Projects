using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作用域
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             错误1：
              static void Main(string[] args)
            {
             
            for (int i = 0; i < 10; i++)
            {
                string text = "Line" + Convert.ToString(i);
                Console.WriteLine(text);
            }
            无法调用for循环内字符串text
            Console.WriteLine("Last text output is :" + text);
             
             }

             错误2：
              static void Main(string[] args)
            {
             string text;
            for (int i = 0; i < 10; i++)
            {
                text = "Line" + Convert.ToString(i);
                Console.WriteLine(text);
            }
            使用前字符串text变量未初始化
            Console.WriteLine("Last text output is :" + text);
             
             }
             */


            string text = "";
            for (int i = 0; i < 10; i++)
            {
                text = "Line" + Convert.ToString(i);
                Console.WriteLine(text);
            }
            Console.WriteLine("Last text output is :" + text);
            Console.ReadKey();
        }
    }
}
