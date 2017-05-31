using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 分部方法
{
    //生命分部类
    public partial class Program
    {
        partial void write();//声明
         partial void write()
        {
            Console.WriteLine("一个分布方法");
        }

    }
    public partial class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.write();
            Console.ReadKey();

        }
    }
}
