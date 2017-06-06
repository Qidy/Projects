using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 异常处理
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             1. try ...catch              捕获异常
                     try
                    {
                        包含容易产生异常的代码
                     }
                      catch （异常类，异常实例对象）
                    {
                         异常处理代码
                     }
             2. try ....finally           清楚异常
                try
                {
                      包含容易产生异常的代码
                 }
                catch （异常类，异常实例对象）
                {
                         异常处理代码
                 }
                 finally
                {
                         消除try中分配的资源
                 }

             3. try ....catch...finally   处理所有异常
             
          
             */

            //利用try catch语句补货数组的越界

            int[] myint = { 0, 2, 4, 6, 8,10,12,14,16,18, 20 };
            try
            {
                for (int i = 0; i <= myint.Length; i++)
                {
                    //Console.Write(myint[i].ToString() + " ");
                    if(myint[i] !=0)
                    {
                        Console.WriteLine("720/{0}={1}", myint[i], 720 / myint[i]);
                    }
                    

                }
            }
            //catch
            //{
            //    Console.WriteLine("发生异常");
            //}
            catch (Exception myex)
            {
                //myex.Message.ToString()获取描述当前异常的字符串
                Console.WriteLine(myex.Message.ToString());
            }
            finally
            {
                Console.WriteLine("继续执行，无论发生与否");
            }

            Console.ReadKey();

            

        }
    }
}
