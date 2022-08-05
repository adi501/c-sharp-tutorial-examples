using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Dynamic_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic varInt = 1;
            dynamic varChar = 'a';
            dynamic varString = "adi";
            varString = "red coin";
            varString = 10;
            Console.WriteLine(varInt);
            Console.WriteLine(varChar);
            Console.WriteLine(varString);
            Console.ReadLine();
        }
    }
}
