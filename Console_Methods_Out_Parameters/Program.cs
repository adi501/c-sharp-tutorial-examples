using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Methods_Out_Parameters
{
    class Program
    {
        //ref: http://www.yoda.arachsys.com/csharp/parameters.html
        static void Foo(out int x)
        {
            // Can't read x here - it's considered unassigned

            // Assignment - this must happen before the method can complete normally
            x = 10;

            x = x + 20;

            // The value of x can now be read:
            int a = x;
        }



        static void Main(string[] args)
        {
            // Declare a variable but don't assign a value to it
           // int y;

            int x ;

            // Pass it in as an output parameter, even though its value is unassigned
            Foo(out x);

            // It's now assigned a value, so we can write it out:
            Console.WriteLine(x);
        }
    }
}
