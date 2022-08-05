using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Access_Modifiers
{
    class Program
    {
        static void Main(string[] args)
        {

            B B1 = new B();
            B1.show();
        }
    }
    class A
    {
        private int x;
        protected int y;
        internal int z;
        public int p;
        protected internal int q;
    }
    class B : A
    {
        public void show()
        {
            //x=10;
            y = 20;
            z = 30;
            p = 40;
            q = 50;
            // Console.WriteLine(+x);          // Error x is not accessible
            Console.WriteLine(+y);
            Console.WriteLine(+z);
            Console.WriteLine(+p);
            Console.WriteLine(+q);
            Console.ReadLine();

        }
    }
}
