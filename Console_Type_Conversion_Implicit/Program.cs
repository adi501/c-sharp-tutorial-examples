using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Type_Conversion_Implicit
{
    class Program
    {
        //ref:http://www.etechpulse.com/2013/04/difference-between-boxing-and-unboxing.html
        //ref:http://www.dotnettricks.com/learn/csharp/understanding-boxing-and-unboxing-in-csharp
        //ref:https://msdn.microsoft.com/en-us/library/yz2be5wk.aspx
        //ref:https://msdn.microsoft.com/en-us/library/ms173105.aspx
        //ref:https://www.codeproject.com/Articles/177153/Type-conversions-with-implicit-and-explicit-operat
        static void Main(string[] args)
        {
            int i = 100;
            double d;
            d = i;
            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}
