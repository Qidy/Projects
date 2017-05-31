using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace 引入命名空间
{
    class Program
    {
        //引入命名空间
        [DllImport("User32.dll")]
        //MessageBox切记大小写，否则无法执行，dll中无法找到messagebox
        public static extern int MessageBox(int h,string m,string c,int Type);
        static int Main(string[] args)
        {
            Console.WriteLine("请输入姓名：");
            string name = Console.ReadLine();
            return MessageBox(0,"欢迎："+name+"\n "+"欢迎来到C#","提示",0);
        }
    }
}
