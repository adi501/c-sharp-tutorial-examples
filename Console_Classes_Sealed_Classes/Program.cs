using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Classes_Sealed_Classes
{

    //ref: files/Object Oriented Programming Using C# .Net


    //Sealed Classes: Sealed classes are the reverse of abstract classes. While abstract classes are inherited and are refined in the derived class, sealed  classes cannot be inherited. You can create an instance of a sealed class. A sealed class is used to prevent further refinement through inheritance. Suppose you are a developer of a class library and some of the classes in the class library are extensible but other classes are not extensible so in that case those classes are marked as sealed.

    sealed class SealedClass
    {
        public void myfunv()
        {
        }
        static void Main(string[] args)
        {
        }
    }
    //public class test : SealedClass //wrong. will give compilation error
    //{
    //}

}
