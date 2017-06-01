using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串分割
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                字符串的分割，通过Split方法实现
               格式为：字符串.Split(字符或者字符数组)


              */
            string mystring = "51zxw-C#-h=AAA";
            Console.WriteLine("原字符串" + mystring);
            //多个分割符数组
            string[] i = mystring.Split(new char[] { '-', '=' });
            foreach (string item in i)
            {
                Console.Write(item + "\t");
            }
            Console.ReadKey();

        }
    }
}
