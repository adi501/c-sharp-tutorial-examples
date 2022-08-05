using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Methods_Named_Parameters
{
    class Program
    {
        //ref: http://www.c-sharpcorner.com/UploadFile/efa3cf/different-types-of-method-parameters-in-C-Sharp/
        static void Main(string[] args)
        {
            Program p = new Program();
            p.SomeObject(10.0, 20.0, isConductor: true, isMetal: true, length: 50.0, weight: 100.0, density: 50.0, volume: 200.0);
            p.SomeObject(10.0, 20.0, 50.0, isConductor: true, isMetal: true, weight: 100.0, density: 50.0, volume: 200.0);
            //error : all the named parameters must appear after fixed arguments. If we provide any fixed argument after named argument then it will give the following compile time error “Named argument specifications must appear after all fixed arguments have been specified”.
            //p.SomeObject(10.0, 20.0, 50.0, isMetal: true, weight: 100.0, density: 50.0, volume: 200.0, true);
        }
        private void SomeObject(double width, double height, double length, double weight, double volume, double density, bool isMetal, bool isConductor)
        {
            //do something    
        }
    }
}
