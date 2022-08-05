using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fibarray = new int[] { 0, 1, 2, 3, 5, 8, 13 };
            foreach (int i in fibarray)
            {
                System.Console.WriteLine(i);
            }
            Console.ReadLine();
        }

    }
}
