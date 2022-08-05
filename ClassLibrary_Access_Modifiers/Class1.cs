using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Access_Modifiers
{
    public class Data
    {
        public int public_data = 10;
        private int private_data = 10;
        protected int protected_data = 10;
        internal int internal_data = 10;
        protected internal int protected_internal_data = 10;
    }
    //public class Data1
    //{
    //    public void method()
    //    {
    //        Data objdata = new Data();
    //        objdata.public_data = 20;
    //        // objdata.private_data = 20;
    //        // objdata.protected_data = 20;
    //        objdata.internal_data = 20;
    //        objdata.protected_internal_data = 20;

    //    }
    //}


}


