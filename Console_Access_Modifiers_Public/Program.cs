using ClassLibrary_Access_Modifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Access_Modifiers_Public
{
    class ClassTest
    {
        //Public method
        public void MethodPublic()
        {
            // defination of MethodPublic
        }
    }

    // to access the method
    class Program
    {
        static void Main(string[] args)
        {
            ClassTest objClassTest = new ClassTest();

            objClassTest.MethodPublic(); // valid code to access.


            Data objdata = new Data();
            objdata.public_data = 20;
        }
    }
}
