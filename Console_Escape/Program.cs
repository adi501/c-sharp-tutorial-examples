using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Escape
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Red Coin");
            Console.WriteLine("\"Red Coin\"");
            Console.WriteLine("\"Red Coin");
            Console.WriteLine("\'Red Coin\'");
            Console.WriteLine("C:\\Users\\Adi\\Desktop\\dot net");
            Console.WriteLine(@"C:\\Users\\Adi\\Desktop\\dot net");
            Console.WriteLine(@"C:\Users\Adi\Desktop\dot net");
            Console.WriteLine("Red \nCoin");


            Console.ReadLine();

        }
    }
}
