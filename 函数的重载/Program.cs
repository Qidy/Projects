using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 函数的重载
{
    class Program
    {
        static int Maxvalue(int[] intarray)
        {
            int maxValue = intarray[0];
            for (int i = 1; i < intarray.Length; i++)
            {
                if (intarray[i] > maxValue)
                {
                    maxValue = intarray[i];
                }

            }
            return maxValue;
        }
        static double Maxvalue(double[] doublearray)
        {
            double maxValue = doublearray[0];
            for (int i = 1; i < doublearray.Length; i++)
            {
                if (doublearray[i] > maxValue)
                {
                    maxValue = doublearray[i];
                }

            }
            return maxValue;
        }

        static void Main(string[] args)
        {
            int[] myarr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            double[] doublea = { 9.1, 8.3, 7.4, 7.9, 6.7, 5.5, 3.4, 2.5,20.5 };
            Console.WriteLine(Maxvalue(myarr));
            Console.WriteLine(Maxvalue(doublea));
            Console.ReadKey();

        }
    }
}
