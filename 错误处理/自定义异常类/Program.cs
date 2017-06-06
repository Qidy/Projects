using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 自定义异常类
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             自定义异常类

             声明异常类格式：              class 自定义的异常类名：Exception{}
             
             引发异常格式：                throw(自定义异常类名)
             
             */
            try
            {
                Console.WriteLine("引发异常前被运行");
                string mystring = "自定义信息内容";
                throw new MyException(mystring);
                Console.WriteLine("引发了异常，不会被运行");
            }
            catch (MyException me)
            {

                Console.WriteLine("自定义的异常");
                Console.WriteLine(me.Message.ToString());
            }
            Console.ReadKey();

        }
    }
}
