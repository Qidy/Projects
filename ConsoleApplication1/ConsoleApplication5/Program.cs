using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ConsoleApplication5
{
    class class1
    {
        public virtual void virtualmethon()
        {
            Console.WriteLine("virtual");
        }
        public void novirtualmethon()
        {
            Console.WriteLine("static virtual");
        }
    }

    class class2:class1
    {
        public new void novirtualmethon()
        {
            Console.WriteLine("new fuction");

        }
        //public new void virtualmethon()
        //{
        //    Console.WriteLine("new1 fuction");

        //}
        public override void virtualmethon()
        {
            Console.WriteLine("这是一个新鞋的");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            class1 c1 = new class1();
            c1.virtualmethon();
            c1.novirtualmethon();
            class2 c2 = new class2();
            c2.novirtualmethon();
            c2.virtualmethon();
            Console.ReadKey();
            

        }
    }
}
