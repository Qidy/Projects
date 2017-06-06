using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组的拆分与合并
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Array提供了copy方法，Copy方法有四个重载
            使用格式
            1和3是int类型   2和4是long类型
            1. Array.Copy(Array1,Array2,长度)
            2. Array.Copy(Array1,Array2,Int64)
            3. Array.Copy(Array1,指定索引，Array2，指定索引，长度)
            3. Array.Copy(Array1,指定索引，Array2，指定索引，长度)
            */
            int[] num1 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] num2 = { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            Console.WriteLine("原始数组数据num1为");
            foreach (int number in num1)
            {
                Console.Write(number + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("原始数组数据num2为");
            foreach (int outint in num2)
            {
                Console.Write(outint + "\t");
            }
            Console.WriteLine();
       
            Console.WriteLine("合并后的数组按升序排列为：");
            int[] resultnum = new int[20];
            //从num1中数组元素从0开始，取10个长度放入resultnum中
            Array.Copy(num1, resultnum, 10);
            //从num2索引值从0开始取10个长度，放入到resulenum中并从索引位置10开始进行存放
            Array.Copy(num2,0, resultnum, 10,10);
            //按升序排列输出
                Array.Sort(resultnum);
            foreach (int outnum in resultnum)
            {
                Console.Write(outnum + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("降序排列");
            Array.Reverse(resultnum);
            foreach (int outnum1 in resultnum)
            {
                Console.Write(outnum1 + "\t");
            }

            Console.ReadKey();
        }
    }
}
