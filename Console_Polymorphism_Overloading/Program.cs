using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Polymorphism_Overloading
{
    //ref:https://www.onlinebuff.com/article_oops-principle-polymorphism-in-c-with-an-example_17.html
    //ref:http://www.c-sharpcorner.com/UploadFile/0c1bb2/polymorphism-in-C-Sharp/
    //ref:http://www.aspdotnet-suresh.com/2013/09/polymorphism-in-c-with-example-types-of-polymorphism.html
    //class Abc
    //{
    //    public int GetSum(int a, int b)
    //    {
    //        int c = a + b;
    //        return c;
    //    }

    //    public double GetSum(double a, double b, double c)
    //    {
    //        double result = a + b + c;
    //        return result;
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            SUM obj = new SUM();
            Console.WriteLine("The sum :" + obj.GetSum(10, 20));
            Console.WriteLine("The sum :" + obj.GetSum(10, 20, 30));
            Console.WriteLine("The sum :" + obj.GetSum(10, 20, 30, 40));
            Console.WriteLine("The sum :" + obj.GetSum(10, 20, 30, 40, 50));
            Console.ReadLine();
        }
    }
}
