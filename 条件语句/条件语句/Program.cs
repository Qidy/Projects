using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cw = System.Console;

namespace 条件语句
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *流程控制语句是程序的核心部分
             * 1.分支语句
             * 2.迭代语句
             * 3.跳转语句
             */

            #region if
            //int roll = int.Parse(Console.ReadLine());
            Random kk = new Random();
            int roll = kk.Next(1, 7);
            if (roll == 1) Console.WriteLine("1");
            else if (roll == 2) Console.WriteLine("2");
            else if (roll == 3) Console.WriteLine("3");
            else if (roll == 4) Console.WriteLine("4");
            else if (roll == 5) Console.WriteLine("5");
            else if (roll == 6) Console.WriteLine("6");


            #endregion
            #region 声明变量并输入，如果小于10重新输入，输入完成计算
            //i://设置跳转点i
            //    double var1 = Convert.ToDouble(Console.ReadLine());//输入数字

            //    if (var1 < 10)//判断输入数字小于10，重新输入
            //    {
            //        Console.WriteLine("请重新输入A，大于10的数字");//提示输入小于10
            //        goto i;//跳转至i
            //    }
            //c://设置跳转点c
            //    double var2 = Convert.ToDouble(Console.ReadLine());//输入数字
            //    if (var2 < 10)//判断输入数字小于10，重新输入
            //    {
            //        Console.WriteLine("请重新输入B，大于10的数字");//提示输入小于10
            //        goto c;//跳转至c
            //    }
            //    Console.WriteLine("输入的数字A为" + var1);//输出输入的数字
            //    Console.WriteLine("输入的数字B为" + var2);//输出输入的数字
            //    Console.WriteLine("输入的数字A+B为" + (var1 + var2));//输出输入的数字
            //    Console.WriteLine("输入的数字A-B为" + (var1 - var2));//输出输入的数字
            //    Console.WriteLine("输入的数字A*B为" + var1 * var2);//输出输入的数字
            //    Console.WriteLine("输入的数字A/B为" + var1 / var2);//输出输入的数字
            //    Console.ReadKey();//输出停留
            #endregion

            #region 声明变量并输入，查看与10的大小关系
            //int.Parse将数字的字符串形式转换为它等效32位有符号的整数
            //Console.WriteLine("请输入一个数字，判定与10的关系");
            //int num = int.Parse(Console.ReadLine());
            //if (num > 10) Console.WriteLine("您输入的数值大于10");
            //else if(num ==10) Console.WriteLine("您输入的数值等于10");
            //else Console.WriteLine("您输入的数值小于10");

            #endregion
            Console.ReadKey();
        }
    }
}
