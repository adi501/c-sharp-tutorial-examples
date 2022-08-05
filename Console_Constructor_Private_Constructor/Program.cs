using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Constructor_Private_Constructor
{
    public class Sample
    {
        public string param1, param2;
        public Sample(string a, string b)
        {
            param1 = a;
            param2 = b;
        }
        private Sample()  // Private Constructor Declaration
        {
            Console.WriteLine("Private Constructor with no prameters");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Here we don't have chance to create instace for private constructor
            Sample obj = new Sample("Welcome", "to Aspdotnet-Suresh");
            Console.WriteLine(obj.param1 + " " + obj.param2);

            // it will not work because of inaccessability
            //Sample obj1 = new Sample();

            Console.ReadLine();
        }
    }
}
