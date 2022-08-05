using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Polymorphism_Overloading
{
    class SUM
    {
        public int GetSum(int a, int b)
        {
            int c = a + b;
            return c;
        }
        public int GetSum(int a, int b, int c)
        {
            int result = a + b + c;
            return result;
        }
        public int GetSum(int a, int b, int c, int d)
        {
            int result = a + b + c + d;
            return result;
        }
        public int GetSum(int a, int b, int c, int d, int e)
        {
            int result = a + b + c + d + e;
            return result;
        }
    }
}
