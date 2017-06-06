using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 迭代return
{
    class Program
    {
        //新建方法，并返回值
        static double dd(int a,int b,int c)
        {
            return (a + b + c) / 3;
        }
        //新建方法，无返回值
        static void ff(int a, int b, int c)
        {
            Console.WriteLine((a + b + c) / 3);
            return;
        }

        static void Main(string[] args)
        {
            for(;;)//while(true)
            { 
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
                //double d = (a + b + c) / 3;
                //调用dd()方法
                double ee = dd(a, b, c);
                //调用无返回值方法
                ff(a, b, c);
                Console.WriteLine("输入值得平均数为" + ee);

//            Console.ReadKey();
            }
        }
    }
}
