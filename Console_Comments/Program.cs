using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Comments
{
    class Program
    {
        static void Main(string[] args)
        {




            //Single line comments
            // for single line comments


            //Multiple line comments
            /* for multi line comments */
            
            
            
            //XML tags comments
            /// XML tags displayed in a code comment
            /// 
           
          int sum=  Add(10, 20);

          //int sum1 = ad

          Console.WriteLine();

        }
        
        /// <summary>
        /// it will do 2 numbers add , it will take 2 int numbers and it eill return int
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
        public static void Sub(int a, int b,int c)
        {
            //return num1 - num2;
        } 
    }
}
