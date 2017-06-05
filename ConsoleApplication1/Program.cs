using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法
{
    class Program
    {
        //方法Maxval(int[] intarray)
        static int Maxval(int[] intarray)
        {
            //声明并初始化为数组第一个值
            int maxVal = intarray[0];
            //循环intarray，
            for (int i = 0; i < intarray.Length; i++)
            {
                //如果intarray[i]值大于初始化数组中maxVal值
                if (intarray[i] > maxVal)
                {
                    //将intarray[i]值赋予maxVal
                    maxVal = intarray[i];
                }
            }
            //返回最大值
            return maxVal;
        }

        static double Maxval(double[] intarray)
        {
            //声明并初始化为数组第一个值
            double maxVal = intarray[0];
            //循环intarray，
            for (int i = 0; i < intarray.Length; i++)
            {
                //如果intarray[i]值大于初始化数组中maxVal值
                if (intarray[i] > maxVal)
                {
                    //将intarray[i]值赋予maxVal
                    maxVal = intarray[i];
                }
            }
            //返回最大值
            return maxVal;
        }


        static double getval1(double var1,double var2)
        {
            return var1 * var2;
        }
        static double getval()
        {
            Console.WriteLine("请输入getval值");
            double a = Convert.ToDouble(Console.ReadLine());
            if (a < 5)
            {
                return 0;
            }
            else return a;
        }
        static string getstring()
        {
            return "hello,world";
        }
        static void Main(string[] args)
        {
            /*
             调用方法时候，如有参数传入，必须与方法中参数匹配
             */


            int[] myarray = { 1, 8, 3, 6, 2, 5,15 ,9, 3, 0, 2 };
            //调用Maxval()方法，把值赋给maxVal
            int maxVal = Maxval(myarray);
            Console.WriteLine("数组中最大数是：{0}",maxVal);

            double[] myarray1 = { 1.3, 8.5, 3.6, 6.8, 2.4, 5.1, 15.9, 9.8, 3.4, 2.6 };
            //调用Maxval()方法，把值赋给maxVal
            double maxVala = Maxval(myarray1);
            Console.WriteLine("数组中最大的double是：{0}", maxVala);

            string mystring;
            //调用getstring()方法
            mystring = getstring();
            Console.WriteLine(mystring);
            double myval;
            double multipler = 5.3;
            //调用getval()方法
            myval = getval() * multipler;
            Console.Write("getval() * multipler值为：");
            Console.WriteLine(myval);
            Console.WriteLine("getval1:"+getval1(3,5));
            Console.ReadKey();

        }
    }
}
