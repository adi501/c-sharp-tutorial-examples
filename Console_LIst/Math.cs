using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_LIst
{
    class Math
    {

        public int Add(int a1,int a2)
        {
            return a1 + a2;

        }

        public int add_list(List<int> listdata)
        {
            int total = 0;

            foreach(int a in listdata)
            {
                if (a % 2 == 0)
                {

                    total = total + a;
                }
                
            }
            return total;

        }

    }
}
