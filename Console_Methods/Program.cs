using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Methods
{
    class Program
    {
        public int FindMax(int num1, int num2)
        {
            /* local variable declaration */
            int result;
            if (num1 > num2)
                result = num1;
            else
                result = num2;
            return result;
        }
        static void Main(string[] args)
        {
            /* local variable definition */
            int a = 100;
            int b = 200;
            int ret;
            Program n = new Program();
            //calling the FindMax method
            ret = n.FindMax(a, b);
            Console.WriteLine("Max value is : {0}", ret);
            Console.ReadLine();
        }
    }
}
