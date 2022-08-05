using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Constructor_Overloading
{
    class Sample
    {
        public string param1, param2;

        public Sample()     // Default Constructor
        {
            param1 = "Hi";
            param2 = "I am Default Constructor";
        }
        public Sample(string x, string y)     // Declaring Parameterized constructor with Parameters
        {
            param1 = x;
            param2 = y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sample obj = new Sample();   // Default Constructor will Called
            Sample obj1 = new Sample("Welcome", "Overloading");   // Parameterized Constructor will Called
            Console.WriteLine(obj.param1 + ", " + obj.param2);
            Console.WriteLine(obj1.param1 + " to " + obj1.param2);
            Console.ReadLine();
        }
    }
}
