using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串插入填充
{
    class Program
    {
        static void Main(string[] args)
        {

            //字符串填充
            string lk = "www.lsshape.cn";
            string inlk = lk.Insert(11,"n");
            Console.WriteLine(inlk);
            //Padright用来在字符串的结尾处添加制定字符以达到制定长度
            string abc = "abc";
            string abcd = "abcd";
            string abcde = "abcde";
            //结尾处填充
            string aa = abcd.PadRight(6, '/') +"\n" + abcd.PadRight(6, '/')+ "\n" +  abcde.PadRight(6, '/');
            //开始位置填充
            string ss = abcd.PadLeft(10) + "\n" + abcd.PadLeft(10) + "\n" + abcde.PadLeft(10);
            Console.WriteLine(aa);
            Console.WriteLine(ss);
            Console.ReadKey();

        }
    }
}
