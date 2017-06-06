using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//引用
using System.Collections;
namespace 元素添加Arraylist
{
    class Program
    {
        static void Main(string[] args)
        {


            //声明 ArrayList的好处是长度不固定，类型随意
            //数组的长度是固定的，不能更改，类型单一，只能为其中一种
            ArrayList myarraylist = new ArrayList(5);
            Console.WriteLine("初始化之前：" + myarraylist.Count);
            //Add方法用于向Arraylist中添加单个元素，每次只能添加1个
            myarraylist.Add(123);
            myarraylist.Add('a');
            myarraylist.Add("mystring");
            myarraylist.Add(25.6);
            myarraylist.Add(10L);
            Console.WriteLine("初始化之后：" + myarraylist.Count);
            //AddRange方法用于一次性向Arraylist添加多个元素，可以是一个数组
            string[] mystr = { "张三", "李四", "王五", "赵六" };
            myarraylist.AddRange(mystr);
            Console.WriteLine("使用AddRange后" + myarraylist.Count);
            //遍历集合元素
            //引用类型string ,object是所有类型的基类
            foreach (object item in myarraylist)
            {
                Console.Write(item + "\t");
            }
            /*
            移除方法
                1. ArrayList 名称.Remove() 
                2. ArrayList 名称.RemoveAt(索引值)
                3. 2. ArrayList 名称.RemoveRange(起始位置，删除个数)
                4. 2. ArrayList 名称.Clear();清除所有元素
             */
            Console.WriteLine();
            //使用remove移除123
            myarraylist.Remove(123);
            foreach (object item in myarraylist)
            {
                Console.Write(item + "\t" );
            }
           
            Console.WriteLine("使用Remove后:" + myarraylist.Count);
            Console.WriteLine();
            //使用removeAt移除索引位置上的元素
            myarraylist.RemoveAt(3);
            foreach (object item in myarraylist)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("使用RemoveAt后:" + myarraylist.Count);

            Console.WriteLine();
            //使用RemoveRange移除索引起始位置，删除个数
            myarraylist.RemoveRange(3,2);
            foreach (object item in myarraylist)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("使用RemoveRange后:" + myarraylist.Count);

            Console.WriteLine();
            //使用Clear()移除索引起始位置，删除个数
            myarraylist.Clear();
            foreach (object item in myarraylist)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("使用RemoveRange后:" + myarraylist.Count);
            Console.ReadKey();

        }
    }
}
