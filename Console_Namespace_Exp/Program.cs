using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using adi.calculator.Arithmetic;
using alias_name = adi.calculator.Arithmetic; //Namespace Aliases
using Con = System.Console; //Namespace Aliases
using xyz;

namespace Console_Namespace_Exp
{
    class Program
    {
        static void Main(string[] args)
        {

         




            // Fully Qualified Names 
            adi.calculator.Arithmetic.Arithmetic_Operations obj = new adi.calculator.Arithmetic.Arithmetic_Operations();
            obj.Add(10, 20);
            obj.Mul(10, 20);

            //Using Namespaces 
            Arithmetic_Operations obj1 = new Arithmetic_Operations();
            obj1.Add(10, 20);
            obj1.Mul(10, 20);

            //Namespace Aliases
            alias_name.Arithmetic_Operations obj2 = new alias_name.Arithmetic_Operations();
            obj2.Add(10, 20);
            obj2.Mul(10, 20);

            Con.WriteLine("Namespace Aliases");

           System.Console.WriteLine("111");

           Console.WriteLine("aaaaaaaaaaaa");

           xyzcls obj11 = new xyzcls();
           obj11.xyzmethod();

        }
    }
}



namespace adi
{
    namespace calculator
    {
        namespace Arithmetic
        {
            class Arithmetic_Operations
            {
                public int Add(int a,int b)
                {
                    return a + b;
                }
                public int Sub(int a, int b)
                {
                    return a - b;
                }
                public int Mul(int a, int b)
                {
                    return a * b;
                }
            }
        }
    }
}



namespace xyz
{
    public class xyzcls
    {
        public void xyzmethod()
        {

        }
    }
}
