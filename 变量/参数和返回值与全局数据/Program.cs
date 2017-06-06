using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 参数和返回值与全局数据
{
    class Program
    {
        static void showdouble(ref int val)
        {
            val *= 2;
            //传入参数后输出val
            Console.WriteLine("val doubled ={0}", val);
              
        }

        static int val1;
        static int showdouble1()
        {
            val1 *= 2;
            return val1; 
        }

        static void Main(string[] args)
        {
            //showdouble(ref val)传入参数
            int val = 5;
            // showdouble1()传入参数
            val1 = 3;
            //原始值val
            Console.WriteLine("val={0}", val);
            showdouble(ref val);
            //调用showdouble(ref val)方法后val值
            Console.WriteLine("val={0}", val);

            //原始值val1
            Console.WriteLine("val={0}", val1);
            showdouble1();
            //调用showdouble(ref val)方法后val值
            Console.WriteLine("val={0}", val1);
           int val3 = val1;
            //输出后发现val1值由原来的3变为了6，原始变量val1=3通过调用被修改
            Console.WriteLine("va3="+val3);

            Console.ReadKey();
            
        }
    }
}
