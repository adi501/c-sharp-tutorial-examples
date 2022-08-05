using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Inheritance_Single_nheritance
{
    //ref: files/Object Oriented Programming Using C# .Net

    class branch                  //BASE CLASS
    {
        int bcode;
        string bname, badd;
        public void accpbranchinfo()
        {
            Console.WriteLine("Enter branch details ");
            Console.WriteLine("Enter branch code : ");
            bcode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter branch name : ");
            bname = Console.ReadLine();
            Console.WriteLine("Enter branch address : ");
            badd = Console.ReadLine();
        }
        public void dispbranchinfo()
        {
            Console.WriteLine("\nBranch details are : ");
            Console.WriteLine("Branch code : " + bcode);
            Console.WriteLine("Branch name : " + bname);
            Console.WriteLine("Branch address : " + badd);
        }
    }
    class emps : branch                     //DERIVED CLASS 
    {
        string ename, eadd;
        int eid, eage;
        public void accpempinfo()
        {
            Console.WriteLine("Enter employee details : ");
            Console.Write("Enter employee id : ");
            eid = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter employee name : ");
            ename = Console.ReadLine();
            Console.Write("Enter employee address : ");
            eadd = Console.ReadLine();
            Console.Write("Enter employee age : ");
            eage = Convert.ToInt32(Console.ReadLine());
        }
        public void dispempinfo()
        {
            Console.WriteLine("Employee  details are : ");
            Console.WriteLine("Emp ID : " + eid);
            Console.WriteLine("Emp NAME : " + ename);
            Console.WriteLine("Emp Address : " + eadd);
            Console.WriteLine("Emp Age : " + eage);
        }
    }
    class simpleinh
    {
        static void Main()
        {
            emps obj1 = new emps();  //creating object for child class and accessing parent class member methods too
            obj1.accpbranchinfo();
            obj1.accpempinfo();
            obj1.dispbranchinfo();
            obj1.dispempinfo();
            Console.Read();
        }
    }

}
