using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    //enum oritentation : byte
    //{
    //    north = 1,
    //    south = 2,
    //    east = 3,
    //    west = 4,

    //}
    //struct route
    //{
    //    public oritentation direction;

    //    public double distance;

    //}
    class Program
    {

        static void Main(string[] args)
        {

            #region 声明变量并输入，如果小于10重新输入，输入完成计算
            //        i://设置跳转点i
            //            double var1 = Convert.ToDouble(Console.ReadLine());//输入数字

            //            if (var1 < 10)//判断输入数字小于10，重新输入
            //            {
            //                Console.WriteLine("请重新输入A，大于10的数字");//提示输入小于10
            //                goto i;//跳转至i
            //            }
            //        c://设置跳转点c
            //            double var2 = Convert.ToDouble(Console.ReadLine());//输入数字
            //            if (var2 < 10)//判断输入数字小于10，重新输入
            //            {
            //                Console.WriteLine("请重新输入B，大于10的数字");//提示输入小于10
            //                goto c;//跳转至c
            //            }
            //            Console.WriteLine("输入的数字A为" + var1);//输出输入的数字
            //            Console.WriteLine("输入的数字B为" + var2);//输出输入的数字
            //            Console.WriteLine("输入的数字A+B为" + (var1 + var2));//输出输入的数字
            //            Console.WriteLine("输入的数字A-B为" + (var1 - var2));//输出输入的数字
            //            Console.WriteLine("输入的数字A*B为" + var1 * var2);//输出输入的数字
            //            Console.WriteLine("输入的数字A/B为" + var1 / var2);//输出输入的数字
            //            Console.ReadKey();//输出停留
            #endregion

            #region MyRegion 转换
            //byte destinationcar;
            //short sourcecvar = 281;
            //destinationcar =checked((byte) sourcecvar);
            //Console.WriteLine(sourcecvar);
            //Console.WriteLine(destinationcar);
            //Console.ReadKey();

            #endregion

            #region 使用枚举A
            //oritentation my = oritentation.north;
            //Console.WriteLine(my);
            //Console.ReadKey();

            #endregion

            #region 使用枚举B

            //byte directionbyte;
            //string directionstring;
            //oritentation asdmy = oritentation.north;
            //Console.WriteLine(asdmy);
            //directionbyte = (byte)my;
            //directionstring = Convert.ToString(my);
            //Console.WriteLine(directionbyte);
            //Console.WriteLine(directionstring);
            //Console.ReadKey();

            #endregion

            #region 使用结构
            //route myroute;
            //int direction = -1;
            //double distabce;
            //Console.WriteLine("1 North \n2 South \n3 East \n4 West");
            //do
            //{
            //    Console.WriteLine("Select a Direction");
            //    direction = Convert.ToInt32(Console.ReadLine());
            //}
            //while ((direction < 1 || direction > 4));
            //Console.WriteLine("In put a Direction");
            //distabce = Convert.ToDouble(Console.ReadLine());
            //myroute.direction = (oritentation)direction;
            //myroute.distance = distabce;
            //Console.WriteLine("{0}{1}",myroute.direction,myroute.distance);
            //Console.ReadKey();

            #endregion

            #region 数组For循环

            //string[] firendnames = { "zhangwj", "weiyuan", "xugao", "xiaorui", "chuixin" };
            //Console.WriteLine(firendnames.Length);
            //int i;
            //for (i = 0; i < firendnames.Length; i++)
            //    Console.WriteLine(firendnames[i]);
            //Console.ReadKey();

            #endregion

            #region 数组Foreach循环

            //string[] firendnames = { "zhangwj", "weiyuan", "xugao", "xiaorui", "chuixin" };
            //Console.WriteLine(firendnames.Length);
            //foreach (string firendnam in firendnames)
            //{
            //    Console.WriteLine(firendnam);
            //}
            //Console.ReadKey();

            #endregion

            #region 字符串处理

            //string Mystring = "A string";
            //char Mychar = Mystring[1];
            //foreach (char charter in Mystring)
            //{
            //    Console.WriteLine(charter);

            //}
            //string mystring = Console.ReadLine();
            //Console.WriteLine(mystring);

            //Console.ReadKey();

            #endregion

            #region 大小写转换
            //小写转换为大写
            //ToUpper大写
            //ToLower小写
            //string userrespones = Console.ReadLine();
            //if (userrespones.ToUpper() == "YES")
            //{
            //    Console.WriteLine(userrespones.ToLower());
            //    Console.ReadKey();

            //字符分割
            //string mystring = "this a test";
            //char[] separator = { ' ' };
            //string[] mywords;
            //mywords = mystring.Split(separator);
            //foreach (string world in mywords)
            //{
            //    Console.WriteLine(world);
            //}
            //Console.ReadKey();
            #endregion

            #region 字符反转

            string user = Console.ReadLine();
            char[] a = user.ToCharArray();
            Array.Reverse(a);
            foreach (char c in a)
            {
                Console.Write("{0}", c);
            }
            Console.ReadKey();

            #endregion

            #region 字符操作


            #region（1）字符访问（下标访问s[i]）
            string s = "";
            s = "ABCD";
            Console.WriteLine(s[0]); // 输出"A";
            Console.WriteLine(s.Length); // 输出4
            Console.WriteLine();
            #endregion

            #region （2）打散为字符数组（ToCharArray）
            s = "ABCD";
            char[] arr = s.ToCharArray(); // 把字符串打散成字符数组{'A','B','C','D'}
            Console.WriteLine(arr[0]); // 输出数组的第一个元素，输出"A"
            Console.WriteLine();
            #endregion

            #region （3）截取子串（Substring）
            s = "ABCD";
            Console.WriteLine(s.Substring(1)); // 从第2位开始（索引从0开始）截取一直到字符串结束，输出"BCD"
            Console.WriteLine(s.Substring(1, 2)); // 从第2位开始截取2位，输出"BC"
            Console.WriteLine();
            #endregion

            #region（4）匹配索引（IndexOf()）
            s = "ABCABCD";
            Console.WriteLine(s.IndexOf('A')); // 从字符串头部开始搜索第一个匹配字符A的位置索引，输出"0"
            Console.WriteLine(s.IndexOf("BCD")); // 从字符串头部开始搜索第一个匹配字符串BCD的位置，输出"4"
            Console.WriteLine(s.LastIndexOf('C')); // 从字符串尾部开始搜索第一个匹配字符C的位置，输出"5"
            Console.WriteLine(s.LastIndexOf("AB")); // 从字符串尾部开始搜索第一个匹配字符串BCD的位置，输出"3"
            Console.WriteLine(s.IndexOf('E')); // 从字符串头部开始搜索第一个匹配字符串E的位置，没有匹配输出"-1";
            Console.WriteLine(s.Contains("ABCD")); // 判断字符串中是否存在另一个字符串"ABCD"，输出true
            Console.WriteLine();
            #endregion

            #region（5）大小写转换（ToUpper和ToLower）
            s = "aBcD";
            Console.WriteLine(s.ToLower()); // 转化为小写，输出"abcd"
            Console.WriteLine(s.ToUpper()); // 转化为大写，输出"ABCD"
            Console.WriteLine();
            #endregion

            #region（6）填充对齐（PadLeft和PadRight）
            s = "ABCD";
            Console.WriteLine(s.PadLeft(6, '_')); // 使用'_'填充字符串左部，使它扩充到6位总长度，输出"__ABCD"
            Console.WriteLine(s.PadRight(6, '_')); // 使用'_'填充字符串右部，使它扩充到6位总长度，输出"ABCD__"
            Console.WriteLine();
            #endregion

            #region（7）截头去尾（Trim）
            s = "__AB__CD__";
            Console.WriteLine(s.Trim('_')); // 移除字符串中头部和尾部的'_'字符，输出"AB__CD"
            Console.WriteLine(s.TrimStart('_')); // 移除字符串中头部的'_'字符，输出"AB__CD__"
            Console.WriteLine(s.TrimEnd('_')); // 移除字符串中尾部的'_'字符，输出"__AB__CD"
            Console.WriteLine();
            #endregion

            #region（8）插入和删除（Insert和Remove）
            s = "ADEF";
            Console.WriteLine(s.Insert(1, "BC")); // 在字符串的第2位处插入字符串"BC"，输出"ABCDEF"
            Console.WriteLine(s);
            Console.WriteLine(s.Remove(1)); // 从字符串的第2位开始到最后的字符都删除，输出"A"
            Console.WriteLine(s);
            Console.WriteLine(s.Remove(0, 2)); // 从字符串的第1位开始删除2个字符，输出"EF"
            Console.WriteLine();
            #endregion

            #region（9）替换字符（串）（Replace）
            s = "A_B_C_D";
            Console.WriteLine(s.Replace('_', '-')); // 把字符串中的'_'字符替换为'-'，输出"A-B-C-D"
            Console.WriteLine(s.Replace("_", "")); // 把字符串中的"_"替换为空字符串，输出"A B C D"
            Console.WriteLine();
            #endregion

            #region（10）分割为字符串数组（Split）——互逆操作：联合一个字符串静态方法Join(seperator,arr[])
            s = "AA,BB,CC,DD";
            string[] arr1 = s.Split(','); // 以','字符对字符串进行分割，返回字符串数组
            Console.WriteLine(arr1[0]); // 输出"AA"
            Console.WriteLine(arr1[1]); // 输出"BB"
            Console.WriteLine(arr1[2]); // 输出"CC"
            Console.WriteLine(arr1[3]); // 输出"DD"
            Console.WriteLine();
            
            s = "AA--BB--CC--DD";
            string[] arr2 = s.Replace("--", "-").Split('-'); // 以字符串进行分割的技巧：先把字符串"--"替换为单个字符"-"，然后以'-'字符对字符串进行分割，返回字符串数组
            Console.WriteLine(arr2[0]); // 输出"AA"
            Console.WriteLine(arr2[1]); // 输出"BB"
            Console.WriteLine(arr2[2]); // 输出"CC"
            Console.WriteLine(arr2[3]); // 输出"DD"
            Console.WriteLine();
            #endregion

            #region（11）格式化（静态方法Format）
            Console.WriteLine(string.Format("{0} + {1} = {2}", 1, 2, 1 + 2));
            Console.WriteLine(string.Format("{0} / {1} = {2:0.000}", 1, 3, 1.00 / 3.00));
            Console.WriteLine(string.Format("{0:yyyy年MM月dd日}", DateTime.Now));
            #endregion

            #region（12）连接成一个字符串（静态方法Concat、静态方法Join和实例方法StringBuilder.Append）
            s = "A,B,C,D";
            string[] arr3 = s.Split(','); // arr = {"A","B","C","D"}

            Console.WriteLine(string.Concat(arr3)); // 将一个字符串数组连接成一个字符串，输出"ABCD"

            Console.WriteLine(string.Join(",", arr3)); // 以","作为分割符号将一个字符串数组连接成一个字符串，输出"A,B,C,D"

            StringBuilder sb = new StringBuilder(); // 声明一个字符串构造器实例
            sb.Append("A"); // 使用字符串构造器连接字符串能获得更高的性能
            sb.Append('B');
            Console.WriteLine(sb.ToString());// 输出"AB"

            Console.ReadKey();
            #endregion
            #endregion

            #region Main()函数


            #endregion
        }
    }
}


