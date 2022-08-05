using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Abstraction_Encapsulation
{
    class User
    {
        public bool AddUser(string name, string email, string phone)
        {
            if (ValidateUser(name, email, phone))
            {
                if (AddtoDb(name, email, phone) > 0)
                {
                    return true;
                }
            }
            return false;
        }

        private bool ValidateUser(string name, string email, string phone)
        {
            // do your validation
            return true;
        }

        private int AddtoDb(string name, string email, string phone)
        {
            // Write the Db code to insert the data
            return 1;
        }
    }
}
