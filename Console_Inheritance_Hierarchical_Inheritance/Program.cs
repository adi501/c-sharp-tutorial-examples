using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Inheritance_Hierarchical_Inheritance
{
    class HeadOffice
    {
        public void HeadOfficeAddress()
        {
            Console.WriteLine("Head Office Address");
        }
    }
    class BranchOffice1 : HeadOffice
    {
        public void BranchOfficeAddress()
        {
            Console.WriteLine("Branch Office Address");
        }
    }
    class BranchOffice2 : HeadOffice
    {
        public void BranchOfficeAddress()
        {
            Console.WriteLine("Branch Office Address");
        }
    }
    class mainClass
    {
        static void Main()
        {
            BranchOffice2 obj = new BranchOffice2();
            obj.HeadOfficeAddress();
            obj.BranchOfficeAddress();
        }
    }
}
