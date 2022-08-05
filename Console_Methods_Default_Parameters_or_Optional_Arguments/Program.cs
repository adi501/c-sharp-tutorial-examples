using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Methods_Default_Parameters_or_Optional_Arguments
{
    class Program
    {
        //ref:http://www.c-sharpcorner.com/UploadFile/efa3cf/different-types-of-method-parameters-in-C-Sharp/
        private void Add(int w, int x = 10, int y = 0, int z = 5)
        {
            //do something    
        }

        // error :Optional parameter must be defined after any required parameter.
        //private void sub(int w, int x = 10, int y = 0, int z)
        //{
        //    //do something    
        //}
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Add(15);
            // pass 10 for y    
            p.Add(15, 15); //but it will consider it as value for x not for y.  

            //If you want to pass value for y, then you must specify value for x also. e.g.
            p.Add(15, 10, 10);
            //But this can be done using named parameter,
            p.Add(15, y: 10);
        }
    }
}
