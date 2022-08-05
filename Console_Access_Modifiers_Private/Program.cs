using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Access_Modifiers_Private
{
    class ClassTest
    {
        //Private method
        private void MethodPrivate()
        {
            // defination of MethodPrivate
        }
    }
    // to access the method
    class Program
    {
        static void Main(string[] args)
        {
            ClassTest objClassTest = new ClassTest();

            //objClassTest.MethodPrivate(); // error: invalid code to access.
        }
    }
}
