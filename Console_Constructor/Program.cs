using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Constructor
{
    //class Sample
    //{
    //    public string param1, param2;
    //    public Sample()     // Default Constructor
    //    {
    //        param1 = "Welcome";
    //        param2 = "Default Constructor";
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Sample obj = new Sample();   // Once object of class created automatically constructor will be called
    //        Console.WriteLine(obj.param1);
    //        Console.WriteLine(obj.param2);
    //        Console.ReadLine();
    //    }
    //}


    class abc
    {
        public int eid = 10;
        public int salary = 25000;
        public string ename = "rajesh";
        public string job = "Programer";

        public void getdata()
        {
            Console.WriteLine("ENter Employ id,name,job,salary:");
            eid = int.Parse(Console.ReadLine());
            ename = Console.ReadLine();
            job = Console.ReadLine();
            salary = int.Parse(Console.ReadLine());


            Console.WriteLine("Employe id is:" + eid);
            Console.WriteLine("Employe Name is:" + ename);
            Console.WriteLine("Employe Job is:" + job);
            Console.WriteLine("Employe Salary is:" + salary);
        }
        public abc() // constructor
        {

            Console.WriteLine("Employe id is:" + eid);
            Console.WriteLine("Employe Name is:" + ename);
            Console.WriteLine("Employe Job is:" + job);
            Console.WriteLine("Employe Salary is:" + salary);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            abc obj = new abc();
             obj.getdata();
            Console.ReadLine();
        }
    }
}
