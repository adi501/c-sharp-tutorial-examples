using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Inheritance_Hybrid_Inheritance
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
    ////This part of code is related to combination of hierarchical inheritance and multi level inheritance

    class Employee : BranchOffice2
    {
        public void NameofEmployee()
        {
            Console.WriteLine("Name of the Employee");
        }
        public void Salary()
        {
            Console.WriteLine("Salary of the Employee");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
