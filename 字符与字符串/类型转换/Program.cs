using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类型转换
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             隐式转换    数据类型村粗值的范围包含就隐式转换
             隐式转换是系统自动运行，不要人为进行干预，也不需要额外的编码
              */
            //char mychar = 'a';
            //int myint = 98;           
            //Console.WriteLine(mychar);
            //Console.WriteLine(myint);
            //myint = mychar;
            //Console.WriteLine(myint);
            //Console.ReadKey();


            //显示转换   数据类型村粗值的范围不包含就需显示转换
            //需要转换的类型前面添加（转换类型）
            //checked和unchecked

            //char  mychar = 'a';
            //int myint = 65538;
            //Console.WriteLine(mychar);
            //Console.WriteLine(myint);
            //mychar = checked((char)myint);
            //Console.WriteLine(mychar);
            //Console.ReadKey();

            //Convert.ToString()
            //int myint = 100;
            //string mystr = "456";
            /*
             两种效果相同
             mystr = Convert.ToString(myint);   
             mystr = myint.ToString();
              */

            //myint = int.Parse(mystr);
            //int myint1 = Convert.ToInt32(mystr);
            //Console.WriteLine(myint);

            //Console.WriteLine(myint + myint1);
            double mydouble = 6.5;
            string mystring = "123";
            int myint = 100;
            string stresult;
            int intresult;
            //（int）方法不适用与将string类型转换为int，不能转换引用类型
            //不会进行四色黑恶如，直接舍掉小数
            intresult = (int)mydouble;
            Console.WriteLine(intresult);
            //Convert.ToInt32()它会将空值NUll转换为0
            //0-4,直接舍掉
            //5看整数位,5.5 6返回临近的偶数
            //6-9 进位
            intresult = Convert.ToInt32(mystring);
            Console.WriteLine(intresult);
            //int.Parse()不能转换为空值，只能将string转换为int，不能实现其他类型转换
            intresult = int.Parse(mystring);
            Console.WriteLine(intresult);

            //int转换为sting
            //强制罗浩转换只能转换数值类型  stringresult=(string)myint
            //stresult = Convert.ToString(myint);
            //stresult= myint.ToString()

            Console.ReadKey();


        }
    }
}
