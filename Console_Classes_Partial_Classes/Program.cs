using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Classes_Partial_Classes
{
    //ref: files/Object Oriented Programming Using C# .Net

    //ref: files/Partial Classes in C#.docx
    public partial class partialclassDemo
    {
        public void method1()
        {
            Console.WriteLine("method from part1 class");
        }

    }
    public partial class partialclassDemo
    {
        public void method2()
        {
            Console.WriteLine("method from part2 class");
        }
        //error
        //public void method1()
        //{
        //    Console.WriteLine("method from part1 class");
        //}
    }

    class Program
    {
        static void Main(string[] args)
        {
            //partial class instance
            partialclassDemo obj = new partialclassDemo();
            obj.method1();
            obj.method2();
            obj.method3();
            obj.method4();
        }

    }
}
