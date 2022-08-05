using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Parse_and_TryParse
{
    class Program
    {
        //ref:http://dailydotnettips.com/2016/01/16/back-to-basic-difference-between-int-parse-and-int-tryparse/
        static void Main(string[] args)
        {
            // no error  --Parse
            //string val = "100";
            //int value = int.Parse(val);

            // ArgumentNullException    --Parse
            //string val = null;
            //int value = int.Parse(val);

            // FormatException   --Parse
            //string val = "100.11";
            //int value = int.Parse(val);

            // OverFlowException   --Parse
            //string val = "9999999999999999999999999999999";
            //int value = int.Parse(val);

            //// no error --TryParse
            //string val = "100";
            //int result;
            //bool ifsuccess = int.TryParse(val, out result);
            //// o/p: result =100,  ifsuccess= true

            //// no error --TryParse
            //string val = null;
            //int result;
            //bool ifsuccess = int.TryParse(val, out result);
            //// o/p: result =0,  ifsuccess= false

            //// no error --TryParse
            //string val = "100.11";
            //int result;
            //bool ifsuccess = int.TryParse(val, out result);
            //// o/p: result =0,  ifsuccess= false

            //// no error --TryParse
            //string val = "99999999999999999999999999999999";
            //int result;
            //bool ifsuccess = int.TryParse(val, out result);
            //// o/p: result =0,  ifsuccess= false



        }
    }
}
