using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串查找
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             IndexOf和LastIndexOf来实现
             1. 字符转IndexOf（要查找的字符或字符串）：返回查找的字符或字符串中第一次出现的位置
             2. 字符转IndexOf（要查找的字符或字符串）：返回要查找的字符或字符串最后一次出现的位置
                均返回一个整数，如果所要查找的字符串内部包含朝找的字符或字符串则返回一个负数             
             */

            ////IndexOf方法
            //string mystr = "www.baidu.comsdfds";
            ////0123456789
            ////存在baidu返回4
            //int muyreturnval1 = mystr.IndexOf("baidu");
            //int muyreturnval2 = mystr.LastIndexOf("com");
            ////不存在ff.com返回-1
            ////int muyreturnval1 = mystr.IndexOf("ff.com");
            ////int muyreturnval2 = mystr.LastIndexOf("ff.com");
            //Console.WriteLine(muyreturnval1);
            //Console.WriteLine(muyreturnval2);
            //Console.ReadKey();
            while(true)
            { 
            Console.WriteLine("请输入一个字符串，我们判断是否包含baidu,以及他第一次和最后一个位置");
            string str = Console.ReadLine();
            int returnval1 = str.IndexOf("baidu");
            int returnval2 = str.LastIndexOf("baidu");
            if (returnval1 < 0)
            {
                Console.WriteLine("输入的字符串中不包含baidu");
            }
            else
            {
                Console.WriteLine("输入的字符串中包含baidu,它第一次出现的位置是第{0}位，最后一次出现的位置是第{1}位", returnval1 + 1, returnval2 + 1);
            }
            }
            //Console.ReadKey();


        }
    }
}
