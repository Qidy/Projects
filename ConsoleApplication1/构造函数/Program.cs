using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 构造函数;

namespace 构造函数与析构函数
{
    class Program
    {
        static void Main(string[] args)
        {

            clerk zs = new clerk();
            zs.Name = "张三";
            zs.Gender = Gender.男;
            zs.Age = 25;
            zs.Department = "信息化";
            zs.Workyears = 10;
            zs.write();
            clerk ls = new clerk("李四", Gender.男, 25, "人力部");
         
                ls.write();
            Console.ReadKey();
        }
    }
}
