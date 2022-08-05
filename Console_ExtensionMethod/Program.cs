using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_ExtensionMethod;

namespace Console_ExtensionMethod
{

    //ref:http://www.c-sharpcorner.com/uploadfile/puranindia/extension-methods-in-C-Sharp-3-0/
    class Program
    {
        static void Main(string[] args)
        {


            Math_Operations ob = new Math_Operations();
            ob.Add(10, 4);
            ob.Sub(10, 2);
            ob.NewMethod();
            ob.Mul(20, 30);
            Console.ReadKey();
        }
        //public int mul(int a,int b)
        //{
        //    return a * b;
        //}
    }
    public static class XX
    {
        public static void NewMethod(this Math_Operations ob)
        {
            Console.WriteLine("Hello I m extended method");
        }
        public static int Mul(this Math_Operations ob, int a, int b)
        {
            return a * b;
        }
    }

    public static class ExtMetClass
    {
        public static int IntegerExtension(this string str)
        {
            return Int32.Parse(str);
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string str = "123456";
    //        int num = str.IntegerExtension();
    //        Console.WriteLine("The output using extension method: {0}", num);
    //        Console.ReadLine();
    //    }
    //}
}
