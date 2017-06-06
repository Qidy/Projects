using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace 元素类ArrayList的遍历与查找
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myarraylist = new ArrayList(2);
            myarraylist.Add("数字");
            int[] myint = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            myarraylist.AddRange(myint);
            myarraylist.Add("字符串");
            string[] mystr = { "张三", "李四", "王五", "张三" };
            myarraylist.AddRange(mystr);
            //遍历使用foreach语句，object类型，object是所有类的基类
            foreach (object item in myarraylist) Console.Write(item + "\t");
            //元素的查找
            //IndexOf(要查找的元素)，返回一个首次出现的索引整型值，如果找不到返回-1
            Console.WriteLine(myarraylist.IndexOf("张三"));
            //LastIndexOf(要查找的元素)，返回一个首次出现的索引整型值，如果找不到返回-1
            Console.WriteLine(myarraylist.LastIndexOf("张三"));
            //BinarySearch()，找不到返回-1
            //Console.WriteLine(myarraylist.BinarySearch("张三"));
            Console.ReadKey();

        }
    }
}
