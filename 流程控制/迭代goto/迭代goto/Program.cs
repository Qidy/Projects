using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 迭代goto
{
    class Program
    {
        static void Main(string[] args)
        {

            i://设置跳转点i
            
            Console.WriteLine("请输入数字");
            double var1 = Convert.ToDouble(Console.ReadLine());//输入数字

            if (var1 < 10)//判断输入数字小于10，重新输入
            {
                Console.WriteLine("请重新输入A，大于10的数字");//提示输入小于10
                goto i;//跳转至i
            }
           
            c://设置跳转点c
            
            Console.WriteLine("请输入数字");
            double var2 = Convert.ToDouble(Console.ReadLine());//输入数字
            if (var2 < 10)//判断输入数字小于10，重新输入
            {
                Console.WriteLine("请重新输入B，大于10的数字");//提示输入小于10
                goto c;//跳转至c
            }
            
            Console.WriteLine("输入的数字A为" + var1);//输出输入的数字
            Console.WriteLine("输入的数字B为" + var2);//输出输入的数字
            Console.WriteLine("输入的数字A+B为" + (var1 + var2));//输出输入的数字
            Console.WriteLine("输入的数字A-B为" + (var1 - var2));//输出输入的数字
            Console.WriteLine("输入的数字A*B为" + var1 * var2);//输出输入的数字
            Console.WriteLine("输入的数字A/B为" + var1 / var2);//输出输入的数字
            Console.ReadKey();//输出停留


        }
    }
}
