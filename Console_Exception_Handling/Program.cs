using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Exception_Handling
{
    //ref: http://www.c-sharpcorner.com/article/exception-handling-in-C-Sharp/
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result;
            try
            {
                Console.Write("Enter first number");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Second number :");
                num2 = int.Parse(Console.ReadLine());
                //if(num2>0)
                //{
                //    result = num1 / num2;
                //    Console.WriteLine("Addition is:" + result);
                //}
                Data obj = new Data();
                result = obj.add(num1, num2);
                Console.WriteLine("Addition is:" + result);



            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);

            }

            //catch (DivideByZeroException aaa)
            //{
            //    Console.WriteLine(aaa.Message);

            //}
            //catch (ArithmeticException ex)
            //{

            //}
            //catch (SystemException ex)
            //{

            //}



            catch (Exception ex)
            {

            }

            finally
            {
                Console.WriteLine("Code executed");
            }
            Console.ReadLine();
        }
    }


    public class Data
    {
        public int add(int a, int b)
        {
            try
            {


                return a / b;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    }
}
