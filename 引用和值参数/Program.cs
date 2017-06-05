using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 引用和值参数
{
    class Program
    {


        //关键字params定义方法 SumVals ，该方法可以接受任意个int参数（不接受其他类型参数）
        static int SumVals(params int[] vals)
        {
            int sum = 0;
            foreach (int item in vals)
            {
                sum += item;
            }
            return sum;
        }

        static void Showdouble(ref int Val)
        {
            Val *= 2;
            Console.WriteLine(Val);
        }

        /*  首先：两者都是按地址传递的，使用后都将改变原来参数的数值。
            其次：ref可以把参数的数值传递进函数，但是out是要把参数清空，
            就是说你无法把一个数值从out传递进去的，out进去后，参数的数值为空，
            所以你必须初始化一次。这个就是两个的区别，或者说就像有的网友说的，
            ref是有进有出，out是只出不进。
        */

        static int Showdouble2( int Val)
        {
            Val *= 2;
            return Val;
        }
        static void Main(string[] args)
        {
            int number = 6;
            int mynumber = 5;
            Console.WriteLine(mynumber);
            Showdouble(ref number);
            //使用ref后，原值被修改
            Console.WriteLine(number);
            mynumber = Showdouble2(mynumber);
            Console.WriteLine( mynumber);
            Console.WriteLine(mynumber);



            int sum = SumVals(1, 5, 2, 9, 8);
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
