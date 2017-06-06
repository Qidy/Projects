using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 变量作用域
{
    class Program
    {
        static string mystring;

        static void write()
        {
            //方法内使用
            string mystring = "string in write()";
            Console.WriteLine("Local mystring={0}", mystring);
            Console.WriteLine("Global mystring={0}", Program.mystring);
        }
        static void Main(string[] args)
        {   
            //全局作用域
            Program.mystring = "Global string";
            write();
            
            string mystring = "string in Main()";
            Console.WriteLine("Local mystring={0}", mystring);
            Console.WriteLine("Global mystring={0}", Program.mystring);

            Console.ReadKey();
        }
    }
}
