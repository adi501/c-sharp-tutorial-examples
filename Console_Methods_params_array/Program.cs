using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Methods_params_array
{
    //ref: http://www.c-sharpcorner.com/UploadFile/efa3cf/different-types-of-method-parameters-in-C-Sharp/
    class Program
    {
        static int Sum(params int[] values)
        {
            int val = 0;
            foreach (int v in values)
            {
                val = val + v;
            }
            return val;
        }

        //static int Sum_test1(int a,params int[] values)
        //{
        //    int val = 0;
        //    foreach (int v in values)
        //    {
        //        val = val + v;
        //    }
        //    return val;
        //}

        //error : arrams array must be in last
        //static int Sum1(params int[] values,int a)
        //{
        //    int val = 0;
        //    foreach (int v in values)
        //    {
        //        val = val + v;
        //    }
        //    return val;
        //}
        static void Main()
        {
            Console.WriteLine(Sum(1, 2, 3));
            Console.WriteLine(Sum(1, 2, 3, 4, 5,4,5));
        }

    }
}
