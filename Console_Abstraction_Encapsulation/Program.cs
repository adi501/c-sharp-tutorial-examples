using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Abstraction_Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            User objUser = new User();
            bool f = objUser.AddUser("adi", "jc.adi101@gmail.com", "1234567890");
        }
    }
}
