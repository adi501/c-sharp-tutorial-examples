using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Generic_Classes
{
    class mygen<m>          //Generic class
    {
        public void disp(m s)
        {
            Console.WriteLine("value is " + s);
        }
        //public void add(m a, m b)
        //{
        //    Console.WriteLine("sum of two numbers : " + (a + b));
        //}
    }
    class generics
    {
        static void Main()
        {
            mygen<string> obj1 = new mygen<string>();
            mygen<int> obj2 = new mygen<int>();
            mygen<float> obj3 = new mygen<float>();
            obj1.disp("APTECH");
            obj2.disp(2601);
            obj3.disp(11.45f);
            //Console.WriteLine("enter 2 values :");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //obj3.add(a, b);
            Console.Read();
        }
    }

}
