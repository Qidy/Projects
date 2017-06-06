using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串删除
{
    class Program
    {
        static void Main(string[] args)
        {
            string mystr = "0123456789";
            string myystr = mystr.Remove(2,1);
            string mystr1 = mystr.Substring(5);
            Console.WriteLine(mystr1);
            Console.WriteLine(mystr);
            Console.WriteLine(myystr);
            Console.ReadKey();
        }
    }
}
