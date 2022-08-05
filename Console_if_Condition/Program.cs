
using System;
namespace Console_if_Condition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine("positive number");
            }
            else
            {
                Console.WriteLine("Negitive number");
            }
            Console.ReadLine();
        }
    }
}
