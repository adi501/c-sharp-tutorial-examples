using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Static_Keyword
{
    //ref:files/Static Keyword in Details

    //#region static data member
    //public class StaticDataMember
    //{
    //    private int StudId;
    //    private static int nextStudId = 1;

    //    public StaticDataMember()
    //    {
    //        StudId = nextStudId++;
    //    }

    //    public void PrintRecord()
    //    {
    //        Console.WriteLine("Student Id is {0}", StudId);
    //    }

    //}
    //class StaticKeyword
    //{
    //    static void Main(string[] args)
    //    {
    //        StaticDataMember sd1 = new StaticDataMember();
    //        StaticDataMember sd2 = new StaticDataMember();

    //        //printing
    //        Console.WriteLine("*** Static Keyword Demo ***");
    //        sd1.PrintRecord();
    //        sd2.PrintRecord();
    //        Console.ReadKey();
    //    }
    //}
    //#endregion


    //#region Static Method Member
    //public class StaticMethodMember
    //{
    //    private int EmpId;
    //    private static int nextEmpId = 100;

    //    public static void PrintNextEmp()
    //    {
    //        Console.WriteLine("Next Employee Id is {0}", nextEmpId);
    //    }
    //}

    //class StaticKeyword
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("*** Static Keyword Demo ***");

    //        StaticMethodMember.PrintNextEmp();

    //        Console.ReadKey();
    //    }
    //}

    //#endregion


    #region Static Constructor
    public class StaticConstructor
    {
        private static int nextEmpId;
        private int EmpId;
        private string EmpName = "Krishn";

        static StaticConstructor()
        {
            nextEmpId = 100;
        }

        public StaticConstructor()
        {
            EmpId = nextEmpId++;
        }

        public StaticConstructor(string empName)
        {
            EmpId = nextEmpId++;
            this.EmpName = empName;
        }

        public void PrintInfo()
        {
            Console.WriteLine("EmpId : {0}", EmpId);
            Console.WriteLine("EmpName : {0}", EmpName);
        }
    }

    class StaticKeyword
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Static Keyword Demo ***");

            StaticConstructor sc1 = new StaticConstructor();
            sc1.PrintInfo();
            Console.WriteLine();
            StaticConstructor sc2 = new StaticConstructor("Jeetendra");
            sc2.PrintInfo();

            Console.ReadKey();
        }
    }



    #endregion

}
