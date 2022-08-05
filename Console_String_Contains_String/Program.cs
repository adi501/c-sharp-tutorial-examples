using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_String_Contains_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "This is test";
            if (str.Contains("test")) 
            {
                Console.WriteLine("The sequence 'test' was found.");
            } 
            Console.ReadKey();
        }
    }
}
