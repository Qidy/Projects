using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串复制
{
    class Program
    {


        static void Main(string[] args)
        {
            //string.copy和copyto实现复制

            string mystr = "http://www.baidu.com";
            string copymystr = string.Copy(mystr);

            char[] mychararray = new char[30];

            mystr.CopyTo(7, mychararray, 0, 13);

            Console.WriteLine("mystr:" + mystr);

            Console.WriteLine("copymystr:" + copymystr);

            Console.WriteLine("copy to:" + mychararray);

            //Console.WriteLine(mychararray);

            Console.ReadKey();


        }
    }
}
