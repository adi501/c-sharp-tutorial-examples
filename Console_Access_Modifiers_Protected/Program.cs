using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Access_Modifiers_Protected
{
    class ClassTest
    {
        //Protected variable
        protected int _a;
       // public int _b;
    }

    class ClassTest2 : ClassTest
    {
        protected int _b;
        ClassTest2()
        {
            _a = 10; // can access from this class
        }
    }

    class ClassTest3 
    {
        ClassTest3()
        {
           // _a = 10; // can't access from this class
        }
    }
    class Program 
    {
        static void Main(string[] args)
        {
          
        }
    }
}
