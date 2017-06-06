using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 异常处理总结
{
    class Program
    {
       

        static void Main(string[] args)
        {
            /*
                1. 捕获异常             try....catch
                2. 清除异常             try....finally
                3. 处理所有异常         try....catch....finally
                4. 引发异常             throw new ExceptionName
                5. 预定义异常类
                6. 自定义异常类         class myException:Exceptioin,要修改自定义提示信息class myException:Exceptioin:base(message) 
             */
           
            Console.WriteLine("请输入一个整数");
            while (true)
                try
            {
                int myint = int.Parse(Console.ReadLine());
                double mydouble = 1.0 / myint;
                Console.WriteLine("该数的倒数是：" + mydouble);

            }
            catch (DivideByZeroException)
            {
                
                Console.WriteLine("除零异常");
            }
            catch (OverflowException)
            {
                Console.WriteLine("溢出异常");
            }
            catch (FormatException)
            {
                Console.WriteLine("转换异常");

            }
            catch (Exception)
            {
                Console.WriteLine("其他异常");
            }
            Console.ReadKey();
        }
    }
}
