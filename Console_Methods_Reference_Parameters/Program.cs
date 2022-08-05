using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Methods_Reference_Parameters
{
    class Program
    {
        public void swap(ref int x, ref int y)
        {
            int temp;
            temp = x; /* save the value of x */
            x = y; /* put y into x */
            y = temp; /* put temp into y */
        }
        static void Main(string[] args)
        {
            Program n = new Program(); /* local variable definition */
            // error: Any argument being passed by reference must be assigned before passing it to the method. If it is not assigned then it will give compile time error.
            //int a;
            //int b;
            int a = 100;
            int b = 200;
            Console.WriteLine("Before swap, value of a : {0}", a);
            Console.WriteLine("Before swap, value of b : {0}", b); /* calling a function to swap the values */
            n.swap(ref a, ref b);
            Console.WriteLine("After swap, value of a : {0}", a);
            Console.WriteLine("After swap, value of b : {0}", b);
            Console.ReadLine();
        }
    }
}
