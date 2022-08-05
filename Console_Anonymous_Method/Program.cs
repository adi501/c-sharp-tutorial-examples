using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Anonymous_Method
{
    delegate int MathOp(int a, int b);
    class Program
    {
        //delegate for representing anonymous method
        delegate int del(int x, int y);

        static void Main(string[] args)
        {
            //anonymous method using delegate keyword
            del d1 = delegate(int x, int y) { return x * y; };


            int z1 = d1(2, 3);
            Console.WriteLine(z1);

            del d2 = delegate(int x, int y) { return x + y; };

            int add = d2(20, 30);

            Console.WriteLine(add);
            Console.ReadLine();

        }
    }
    //delegate void NumberChanger(int n);
    //class TestDelegate
    //{
    //    static int num = 10;
    //    public static void AddNum(int p)
    //    {
    //        num += p;
    //        Console.WriteLine("Named Method: {0}", num);
    //    }
    //    public static void MultNum(int q)
    //    {
    //        num *= q;
    //        Console.WriteLine("Named Method: {0}", num);
    //    }
    //    public static int getNum()
    //    {
    //        return num;
    //    }
    //    static void Main(string[] args)
    //    {
    //        //create delegate instances using anonymous method 
    //        NumberChanger nc = delegate(int x)
    //        {
    //            Console.WriteLine("Anonymous Method: {0}", x);
    //        }; //calling the delegate using the anonymous method 
    //        nc(10); //instantiating the delegate using the named methods
    //        nc = new NumberChanger(AddNum); //calling the delegate using the named methods 
    //        nc(5); //instantiating the delegate using another named methods 
    //        nc = new NumberChanger(MultNum); //calling the delegate using the named methods
    //        nc(2);
    //        Console.ReadKey();
    //    }
    //}
}
