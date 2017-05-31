using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
                //求圆的面积
        static void Aeara(double radius)
        {
            double aeara = System.Math.PI * radius * radius;
            Console.WriteLine("圆的面积为："+aeara);
        }
        //求长方形的面积
        static void Aeara(int width,int length)
        {
            int aeara = width * length;
            Console.WriteLine("长方形的面积为："+aeara);
        }
        //求三角形的面积
        static void Aeara(int a,int b,int c)
        {
            double p = (a + b + c) / 2;
            double aeara = System.Math.Sqrt(p*(p-b)* (p - a)*(p - c));
            Console.WriteLine("三角形的面积为："+aeara);
        }



        static void Main(string[] args)
        {
            Aeara(3,4,5);
            Aeara(3);
            Aeara(3,5);
            Console.ReadKey();



        }
    }
}
