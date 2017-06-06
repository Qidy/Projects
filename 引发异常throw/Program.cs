using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 引发异常throw
{
    class Program
    {
        private static int ConvertstringtoInt(string mystr)
        {
            int ounum = 0;
            try
            {
                ounum = Convert.ToInt32(mystr);
                return ounum;
            }
            catch (Exception)
            {

                throw new FormatException("格式转换不正确");
            }
            
            
        }
        static void Main(string[] args)
        {
            /*
                         throw new 异常类（异常信息）
                         异常类：预定义的，自定义的
                         异常信息：字符串"信息"
             */
            string mystr = "52";
            try
            {
                int myint = Program.ConvertstringtoInt(mystr);
                Console.WriteLine(myint);
                
            }
            catch (FormatException exf)
            {

                Console.WriteLine(exf.Message.ToString());
            }

            Console.ReadKey();
        }
    }
}
