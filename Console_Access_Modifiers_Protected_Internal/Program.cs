using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_Access_Modifiers;

namespace Console_Access_Modifiers_Protected_Internal
{
    class ClassTest
    {
        protected internal string name; // protected internal
        protected internal void print()
        {
            Console.WriteLine("\nMy name is " + name);
        }
    }
    // to access the method
    class Program:Data
    {
        static void Main(string[] args)
        {

            Program obj = new Program();
           // obj.internal_data = 20;
            obj.protected_data = 20;
            obj.protected_internal_data = 20;
            obj.public_data = 20;

            ClassTest objClassTest = new ClassTest();
            // Accepting value in protected internal variable
            objClassTest.name = "adi";
            objClassTest.print();
        }
    }
}
