using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Classes_Static_Classes
{
    //ref: files/Object Oriented Programming Using C# .Net
    //ref: files/Static class in C#.docx
    //ref:files/Static Keyword in Details

    //Static classes :A static class is declared using the "static" keyword. If the class is declared as static then the compiler never creates an instance of the class. All the member fields, properties and functions must be declared as static and they are accessed by the class name directly not by a class instance object.


    public static  class staticDemo
    {
        //static fields
       public static  int x = 10, y;
        //static method
        public static void calcute()
        {
            y = x * x;
            Console.WriteLine(y);
        }
       
    }


    public class mainclass
    {
        static void Main(string[] args)
        {
            //function calling directly

            staticDemo.calcute();
            staticDemo.x = 0;
            staticDemo.y = 0;
        }
    }

}
