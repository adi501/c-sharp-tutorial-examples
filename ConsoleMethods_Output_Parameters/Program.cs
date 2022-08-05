using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMethods_Output_Parameters
{
    class Program
    {
        public void getValue(out int x)
        {
            int temp = 5;
            x = temp;
        }
        static void Main(string[] args)
        {
            Program n = new Program(); /* local variable definition */
            int a = 100;
            Console.WriteLine("Before method call, value of a : {0}", a); /* calling a function to get the value */
            n.getValue(out a);
            Console.WriteLine("After method call, value of a : {0}", a);
            Console.ReadLine();
        }
    }
}
