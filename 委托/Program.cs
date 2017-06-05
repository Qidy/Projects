using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托
{
    class Program
    {
        delegate double processDelegate(double param1, double param2);

        static double Multiply(double param1, double param2)
        {
            return param1 * param2;
        }

        static double Divide(double param1, double param2)
        {
            return param1 / param2;
        }
        static void Main(string[] args)
        {
            processDelegate process;
            Console.WriteLine("Enter 2 number separated with a comma:");
            string input = Console.ReadLine();
            //输入的中文标点替换为英文，并查找
            int commaPos = input.Replace('，',',').IndexOf(',');
            //输出占位符位置
            Console.WriteLine("commaPos占位符："+commaPos);
            //param1截取位置，从开始位置0-commaPos位
            double param1 = Convert.ToDouble(input.Substring(0, commaPos));
            //param2截取位置，从开始位置commaPos+1位和 input.Length -commaPos - 1之间
            double param2 = Convert.ToDouble(input.Substring(commaPos + 1, input.Length -commaPos - 1));
            Console.WriteLine("Enter M to multiply or D to divede");
            input = Console.ReadLine();
            input.Replace('m', 'M');

            if (input == "M") 
            {
                process = new processDelegate(Multiply);
            }
            else
           {
                process = new processDelegate(Divide);
            }
            Console.WriteLine("Result:{0}", process(param1, param2));
            Console.ReadKey();
        }
    }
}
