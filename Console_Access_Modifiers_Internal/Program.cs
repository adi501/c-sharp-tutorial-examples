using ClassLibrary_Access_Modifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Access_Modifiers_Internal
{
    class ClassTest : Data
    {
        internal void MethodInternal()
        {
            // do your code
        }
    }
    // to access the method
    class Program
    {
        static void Main(string[] args)
        {
            ClassTest objClassTest = new ClassTest();
            objClassTest.MethodInternal(); // valid code to access.
        }
    }
}
