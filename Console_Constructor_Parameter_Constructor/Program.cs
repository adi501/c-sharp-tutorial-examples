using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Constructor_Parameter_Constructor
{


    class Sample
    {
        public string param1, param2;
        public Sample(string x, string y)     // Declaring Parameterized constructor with Parameters
        {
            param1 = x;
            param2 = y;
        }

        public Sample(string x, string y,string z)     // Declaring Parameterized constructor with Parameters
        {
            param1 = x;
            param2 = y;
        }

        public Sample()     
        {
            param1 = "";
            param2 = "";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sample obj = new Sample("Welcome ", "Parameterized Constructors");   // Parameterized Constructor Called
            Console.WriteLine(obj.param1 + " to " + obj.param2);

            Sample obj1 = new Sample("Welcome ", "red coin","dd");   // Parameterized Constructor Called
            Console.WriteLine(obj1.param1 + " to " + obj1.param2);

            Sample obj2 = new Sample();   
            Console.WriteLine(obj1.param1 + " to " + obj1.param2);
            Console.ReadLine();
        }
    }






    //class csharp
    //{
    //    public int Empid, salary;
    //    public string ename, designation;

    //    public csharp(int a, int b, string c, string d)
    //    {
    //        Empid = a;
    //        salary = b;
    //        ename = c;
    //        designation = d;

    //    }
    //    public csharp(int a, int b, string c)
    //    {
    //        Empid = a;
    //        salary = b;
    //        ename = c;

    //    }

    //    public void display()
    //    {

    //        Console.WriteLine("Emply details are :");
    //        Console.WriteLine("Id :" + Empid);
    //        Console.WriteLine("salary :" + salary);
    //        Console.WriteLine("Ename:" + ename);
    //        Console.WriteLine("Designation :" + designation);

    //    }

    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        csharp obj = new csharp(10, 25000, "Suresh");
    //        obj.display();

    //        Console.ReadLine();
    //    }
    //}
}
