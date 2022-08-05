using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Type_Conversion_Explicit
{
    class Program
    {
        //ref:https://www.tutorialspoint.com/csharp/csharp_type_conversion.htm
        static void Main(string[] args)
        {
            double d = 5673.74;
            int i;

            // cast double to int.
            i = (int)d;
            Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
