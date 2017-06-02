using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {

        public static string stringaddsymbol(string x)
        {
            string[] mywords; string outword = "";
            char[] separator = { ' ' };
            mywords = x.Split(separator);
            foreach (string wordss in mywords)
            {
                string abs = '"' + wordss + '"'; outword += abs + " ";
            }

            outword.TrimEnd();
            return outword;
        }


        static void Main(string[] args)
        {
            //字符转换no TO yes   
            string fanstring = Console.ReadLine();

            char[] fanchar = fanstring.ToCharArray();
            string stringresult = "";
            for (int i = 0; i < fanstring.Length; i++)
            {
                if (i == fanstring.Length - 1)
                {
                    stringresult += fanchar[i];
                    continue;
                }
                if (fanchar[i].ToString().ToLower() == fanchar[i].ToString().ToLower() == "o")

                {
                    stringresult += "yes";
                    i++;
                    continue;
                }
                stringresult += fanchar[i]; && (fanchar[i]("n") )
                Console.WriteLine(stringaddsymbol(stringresult));
                Console.ReadLine();

            }
        }
    }

