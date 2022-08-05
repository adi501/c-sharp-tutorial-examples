using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_While_Loop
{
    class Program
    {
        static void Main()
        {

            //int x=1;
            //while(x<=30)
            //{
            //    Console.WriteLine(x);
            //    x = x + 1;
            //}
            
            //Console.ReadLine();


            int a, range;
            Console.Write("enter the value of a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the range");
            range = Convert.ToInt32(Console.ReadLine());
            while (a <= range)
            {
                if (a % 2 == 0)
                    Console.Write(a + "\t");
                a++;
            }
            Console.Read();

        }

    }
}
