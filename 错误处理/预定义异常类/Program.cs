using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 预定义异常类
{
    class Program
    {
        static int DivideByTwo(int num)
        {
            if (num % 2 == 1)
            {
                throw new ArgumentException("此处需为偶数", " num");

            }
            return num / 2;
        }

        static void Main(string[] args)
        {
            /*
             Exception                              所有已查过对象的基类

            system.Exception                        运行时产生的所有错误的基类

            IndexOutOfRangeException                当一个足足的下表超出范围时运行时引发

            NullReferenceException                  当一个空对象被引用时运行时引发

            ArgumentException                       所有参数异常的基类

            InvalidCastException                    类型的显示转换在运行时失败时，引发次异常

            FormatException                         参数格式无效时引发异常

            OverflowException                       溢出时引发

            DivideByZeroException                   试图除以零引发

            ArithmeticException                     算数运算期间异常发生的基类

            ArrayTypeMismatchException              当存储一个数组时，如果由于被存储的元素的实际类型
                                                    与数组的实际类型不兼容而导致存储失败，引发异常
             */
            #region IndexOutOfRangeException
            //int[] myint = { 1, 2, 3, 4, 5, 6, 7, 8, 9 ,0};
            //try
            //{
            //    for (int i = 0; i < 11; i++)
            //    {
            //        Console.WriteLine(myint[i]);
            //    }
            //}
            //catch (IndexOutOfRangeException exIOR)
            //{

            //    Console.WriteLine(exIOR.Message.ToString());
            //}
            #endregion
            #region   NullReferenceException

            //string mystring = null;
            //try
            //{
            //    Console.WriteLine(mystring.ToString());
            //}
            //catch (NullReferenceException exNre)
            //{

            //    Console.WriteLine(exNre.Message.ToString());
            //}
            #endregion
            #region InvalidCastException
            //bool mybool = true;
            //try
            //{
            //    char mychar = Convert.ToChar(mybool);
            //    Console.WriteLine(mychar);
            //}
            //catch (InvalidCastException exICE)
            //{

            //    Console.WriteLine(exICE.Message.ToString());
            //}
            #endregion
            #region ArrayTypeMismatchException
            //string[] mystring = { "Cat", "Dog", "Pig" };
            //object[] myjob = mystring;
            //try
            //{
            //    foreach (object outobj in myjob)
            //    {
            //        Console.WriteLine(outobj);
            //        Console.WriteLine(outobj.GetType());

            //    }
            //    myjob[2] = 13;
            //}
            //catch (ArrayTypeMismatchException exATM)
            //{

            //    Console.WriteLine(exATM.Message.ToString());
            //}
            #endregion
            #region
            //try
            //{
            //    int num = 10;
            //    Console.WriteLine(num / 0);
            //}
            //catch (DivideByZeroException exdbz)
            //{

            //    Console.WriteLine(exdbz.Message.ToString());
            //}

            #endregion
            #region OverflowException
            try
            {
                byte mybyte = Convert.ToByte(Console.ReadLine());
                Console.WriteLine(mybyte);
            }
            catch (OverflowException exovl)
            {

                Console.WriteLine(exovl.Message.ToString());
            }
            #endregion


            Console.ReadKey();
        }
    }
}
