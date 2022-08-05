using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Delegate_Multi_Cast_Delegate
{
    class delegate3
    {
        public void add(int a, int b)
        {
            Console.WriteLine("addition is : " + (a + b));
        }
        public void sub(int a, int b)
        {
            Console.WriteLine("subctraction is : " + (a - b));
        }
    }
    public delegate void mydelegate(int m, int n);
    class sample2
    {
        static void Main()
        {
            delegate3 obj1 = new delegate3();
            mydelegate dl1 = new mydelegate(obj1.add);
            //dl1 += obj1.add;
            dl1 += obj1.sub;         //adding reference to sub function
            dl1(20, 30);
            //dl1 -= obj1.add;
            //dl1 -= obj1.sub;        //deleting reference from sub,add functions
            //dl1(15, 20);
            Console.Read();
        }
    }

}
