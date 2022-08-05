using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Constructor_Static_Constructor
{



    class Sample
    {
        public string param1, param2;
        static Sample()
        {
            Console.WriteLine("Static Constructor");
        }
        public Sample()
        {
            Console.WriteLine("Sample Instance Constructor");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Here Both Static and instance constructors are invoked for first instance
            Sample obj = new Sample();
            // Here only instance constructor will be invoked
            Sample obj1 = new Sample();

            Sample obj3 = new Sample();

            Sample obj4 = new Sample();
            Console.ReadLine();
        }
    }

    //static class Sample
    //{
    //    //public string param1, param2;
    //    static Sample()
    //    {
    //        Console.WriteLine("Static Constructor");
    //    }
    //    static public void add()
    //    {
    //        Console.WriteLine("Static add");
    //    }
    //    //public Sample()
    //    //{

    //    //    Console.WriteLine("Instance Constructor");
    //    //    //param1 = "Sample";
    //    //    //param2 = "Instance Constructor";
    //    //}
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Here Both Static and instance constructors are invoked for first instance
    //        //Sample obj = new Sample();
    //        // Console.WriteLine(obj.param1 + " " + obj.param2);
    //        // Here only instance constructor will be invoked
    //        // Sample obj1 = new Sample();
    //        // Console.WriteLine(obj1.param1 + " " + obj1.param2);
    //        Sample.add();
    //        Sample.add();
    //        Sample.add();
    //        Console.ReadLine();
    //    }
    //}













    //class staticcon
    //{
    //    int i;
    //    static int j;
    //    public staticcon()
    //    {
    //        i = 100;
    //        //j=100;  //a static variable can be initialized in normal constructor but looses its static nature.
    //    }
    //    static staticcon()
    //    {
    //        j = 100;
    //        //i=101; //a non-static variable can not be initialized in the static constructor.
    //    }
    //    public void disp()
    //    {
    //        Console.WriteLine("Value of i : " + i);
    //        i++;
    //        Console.WriteLine("\n\nValue of j : " + j);
    //        j++;
    //    }
    //}
    //class stcon
    //{
    //    static void Main()
    //    {
    //        staticcon objs = new staticcon();
    //        staticcon obj = new staticcon();
    //        obj.disp();
    //        objs.disp();
    //        Console.Read();
    //    }
    //}

}
