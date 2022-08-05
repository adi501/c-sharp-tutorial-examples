using System;

namespace Console_Boxing_UnBoxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            object o = i;  //implicit Boxing
            Console.WriteLine("The value of O:" + o);
            Object K = (object)i; // Explicit boxing
            Console.WriteLine("The value of K:" + K);
            int x = (int)o; // Explicit Unboxing
            Console.WriteLine("The Value Of X:" + x);
            Console.ReadLine();
        }
    }
}
