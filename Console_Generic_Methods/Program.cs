using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Generic_Methods
{
    class genmethods
    {
        static public void display<gm>(gm v)
        {
            Console.WriteLine(v);
        }
        static void Main()
        {
            display<int>(11);
            display<string>("Aptech");
            Console.Read();
        }
    }       

}
