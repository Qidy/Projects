using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    //创建枚举
    //public enum week
    //{
    //    星期一,
    //    星期二,
    //    星期三,
    //    星期四,
    //    星期五,
    //    星期六,
    //    星期日
    //}
    ////创建结构
    //public struct clerk
    //{
    //    public string Name;
    //    public int age;
    //    public string department;
    //}

    class Program
    {


        static void Main(string[] args)
        {
            //将class_clerk进行实例化
            class_clerk zs = new class_clerk();
            zs.Name = "张三";
            zs.Gender = '中';
            zs.Age = -25;
            zs.Department = "信息化";
            zs.Workyears = 10;
            zs.write();
            Console.ReadKey();



            //clerk zs = new clerk();
            //clerk ls = new clerk();
            //zs.Name = "张三";
            //zs.department="IT";
            //zs.age = 25;
            //ls.age = 18;
            //ls.Name = "李四";
            //ls.department = "信息化";
            //Console.WriteLine("我叫{0}，我是{1}部，今年{2}岁",zs.Name, zs.department, zs.age);//输出
            //Console.WriteLine("我叫{0}，我是{1}部，今年{2}岁", ls.Name, ls.department, ls.age);
            //week myworkday = week.星期三;
            //Console.WriteLine(myworkday);
            //Console.ReadKey();

        }
    }
}
