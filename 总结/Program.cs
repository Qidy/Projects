using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 总结
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                1.字符                                                       char
                2.字符串                                                     string
                3.字符串大小写转换                                           string.toLower和sting.ToUpper
                4.字符串比较    
                          比较方法
                          1. ==
                          2. equals方法Equals(字符串1，字符串2) 返回布尔值
                          3.  compare方法Compare(字符串1，字符串2,布尔值*忽略大小写*) 返回值是一个整数
                         小于0     字符串1小于字符串2
                         等于0     字符串1等于字符串2
                         大于0     字符串1大于字符串2，或者字符串2为null引用  
            
                                                         
                5.字符串格式化    
                
                             Format
                             string.Format(要转换的格式，格式化对象)；
                             string.Format(要转换的格式，格式化对象1,格式化对象2)；
                  
                             C      适用于数字类型              专用场合的或壁纸
                             D      只用与整数乐行              一般整数
                             E      数字类型                    科学记数法
                             F      数字类型                    小数点后的位数固定
                             G      数字类型                    一般整数
                             N      数字类型                    通用场合数字格式
                             P      数字类型                    百分数
                             X      只用与整数类型              十六进制格式
            
                                                        
                6.字符串截取                 string.Substring()                                           
                7.字符串分割                 string.Split()                                                                  
                8.字符串合并           
                             1.符号+
                             2.sting.concat
                             3. sting.join    
            
                                                      
                9.字符串插入填充   
                            string.Insert()
                            string.PadRight()
                            string.PadLeft()
                                                                                                    
                10.字符串删除、修剪、复制、替换、查找   
                        删除   string.Remove()
                        修剪   string.Trim()  string.TrimStart() string.TrimEnd() string.Trim("".ToCharArray())      
                        复制      
                            char[] mychararray = new char[30];            
                            string.Copy    mystr.CopyTo(7, mychararray, 0, 13);
                        替换
                              //使用Replace来实现，非静态方法
                              //字符串.Replace(要替换的源字符串，替换后的字符串)
                                    Console.WriteLine("输入后反转");
                                    string mysting = Console.ReadLine();
                                    char[] a = mysting.ToCharArray();
                                     Array.Reverse(a);
                                     foreach (char item in a)
                                         {
                                              Console.Write(item);
                                         }
                                              Console.ReadKey();

                        查找
                        IndexOf和LastIndexOf来实现
                        1. 字符转IndexOf（要查找的字符或字符串）：返回查找的字符或字符串中第一次出现的位置
                        2. 字符转IndexOf（要查找的字符或字符串）：返回要查找的字符或字符串最后一次出现的位置
                          均返回一个整数，如果所要查找的字符串内部包含朝找的字符或字符串则返回一个负数 
                                                                 
                11.类型转换                                                                     
                12.StringBuilder类    

             */













        }
    }
}
