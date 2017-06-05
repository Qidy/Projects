using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 结构函数
{
    class Program
    {
        
        struct customerName
        {
            
            public string firstName, lastName;
            public string Name()
            {
                return firstName + " " + lastName;
            }
        }


        static void Main(string[] args)
        {
            /*
             结构类型可以在一个地方存储多个数据元素，结构可以包含函数和数据  
             */
           
           customerName myCustomer;
            myCustomer.firstName = "Tsietsi";
            myCustomer.lastName = "qi";
            Console.WriteLine(myCustomer.firstName+" "+myCustomer.lastName);
            Console.WriteLine(myCustomer.Name());
            Console.ReadKey();
        }

    }
}



