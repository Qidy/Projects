using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main__函数
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
                有返回值的函数，使用return关键字 

             （1）Main()函数是C#应用程序的入口点，在执行程序开始时，会执行Main()函数，当该函数执行完毕，程序执行过程即结束。
             （2）Main()函数的定义可以有4种形式：
              Main()函数定义形式
              说明
              static void Main()                           无输入参数，无返回值
              static void Main(string[],args)              有输入参数，无返回值

              下面两个返回一个int值
              static int Main()                            无输入参数，有返回值
              static int Main((string[],args)              有输入参数，有返回值
            （3）Main()函数有返回值的版本，返回一个int值，一般用于表示应用程序如何终止，通常用作错误提示。一般返回0表示程序正常终止。
            （4）可选参数string{},args是用于从外部接收参数，即被调用时提供的参数（命令行参数），类似于在命令符下输入：notepad abc.txt，
                但即使写上参数，也可以不输入任何参数。该可选参数是一个标准的参数数组，只能接收字符串，参数个数不限。对于字符串中间带空格的
                应用双引号封起来。eg：Ch06Ex04 256 myfile.txt "a longer argument"
                对于输入的256都看做是字符串。
            （5）对于命令行参数既可以在命令行手工收入，也可以在VS中给Main()函数直接指定运行输入参数：项目属性—调试—命令行参数。这样就可以无需每次都手工输入参数了。
             */
             //在项目名下，属性，调试中添加测试命令
            Console.WriteLine("{0}command line arguments were apecified:" ,args.Length);
            foreach (string item in args)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();



        }
    }
}
