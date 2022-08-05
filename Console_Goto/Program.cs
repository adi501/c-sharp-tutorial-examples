using System;

namespace Console_Goto
{
    class Program
    {
        static void Main(string[] args)
        {
            goto xx;

            Console.WriteLine("hello");
        xx:
            Console.WriteLine("goto called");
            Console.ReadLine();
        }
    }
}
