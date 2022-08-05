using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Methods_Dynamic_parameter
{
    class Program
    {
        static dynamic MyDynamicMethod(dynamic dynamicparam)
        {
           // dynamicparam.DoSomethingDynamic(); // Called dynamically    
            Console.WriteLine(dynamicparam);
            return dynamicparam;
        }
        static void Main(string[] args)
        {

            MyDynamicMethod("dynamicValue");
            MyDynamicMethod(1);
            MyDynamicMethod(10.20);
        }  
    }
}
