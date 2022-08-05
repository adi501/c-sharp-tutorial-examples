using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Do_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            do
            {
                Console.WriteLine(x);
                x++;
            }
            while (x <= 100);
            Console.ReadLine();


            //int x = 0;
            //while (x < 0)
            //{
            //    Console.WriteLine(x);
            //    x = x + 1;
            //}

            //Console.ReadLine();


            //int x = 0;
            //do
            //{
            //    Console.WriteLine(x);
            //    x++;
            //}
            //while (x < 0);
            //Console.ReadLine();

        }
    }
}
