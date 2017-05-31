using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 迭代do._.@while
{
    class Program
    {
        static void Main(string[] args)
        {

            double Balance = 0;
            double Rate = 0;
            int Year = 0;
            double TartetBalance = 0;
            Console.WriteLine("输入您的本金");
            Balance = double.Parse(Console.ReadLine());
            Console.WriteLine("输入当前利率百分比");
            Rate = double.Parse(Console.ReadLine()) / 100;
            Console.WriteLine("输入目标收益");
            TartetBalance = double.Parse(Console.ReadLine());
            do
            {
                Balance *= (Rate + 1);
                Year++;

            }
            while (Balance < TartetBalance);
            {
                Console.WriteLine("将在{0}年内，获得{1}元的收益", Year, Balance);
                Console.ReadKey();
            }

    }
}
}
