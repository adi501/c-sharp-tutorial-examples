using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Delegate_Single_Cast_Delegate
{
    class delegate1
    {
        static void display(string s)
        {
            Console.WriteLine("value is : " + s);
        }
        delegate void x(string d);
        static void Main()
        {
            x obj1 = new x(display);
            obj1("aptech");
            Console.Read();
        }
    }

}
