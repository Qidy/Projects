using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符与字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            //char.IsLetter         是否是字母
            //char.IsDigit          是否为数字
            //char.IsLetterOrDigit  是否是数字或字母
            //char.IsLower          是否为小写
            //char.IsUpper          是否为大写
            //char.IsPunctuation    是否标点
            //char.IsSeparator      分隔符
            //char.IsWhiteSpace     是否是空格
            //char.ToLower          转化为小写
            //char.ToUpper          转化为大写


            char mychar1 = 'a';
            char mychar2 = '0';
            char mychar3 = 'M';
            if (char.IsLetter(mychar1))
            {
                
                Console.WriteLine(char.ToUpper(mychar1));
            }
            if (char.IsDigit(mychar2))
            {
                Console.WriteLine("判断为数字");

            }
            if (char.IsUpper(mychar3))
            {
                Console.WriteLine(char.ToLower(mychar3));
            }
            
            Console.ReadKey();
        }
    }
}
