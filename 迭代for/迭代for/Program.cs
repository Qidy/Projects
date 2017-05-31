using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 迭代for
{
    class Program
    {
        static void Main(string[] args)
        {
             /*
              * for语句格式
              *  for (初始条件;判断条件；循环条件)
              *  {
              *  循环语句
              *  }
              *  for(;;)其他条件可以不存在，但是必须要有;(死循环)
              *  
              * 
              */
            Console.WriteLine("请输入的阶乘的值为");
            //for (;;) { 
            int a = int.Parse(Console.ReadLine());
            int jc = 1;
            for (int i=1;i<=a;i++)
            {
                jc *= i;
            }
            Console.WriteLine("阶乘的值为" + jc);
            Console.ReadKey(); 
        }
        //}
    }
}
