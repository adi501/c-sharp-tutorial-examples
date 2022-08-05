using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Inheritance_Multi_Level_nheritance
{
    //ref: files/Object Oriented Programming Using C# .Net

    class semmarks               //BASE CLASS FOR practicles CLASS
    {
        int m1, m2, m3;
        public void accpsemmarks()
        {
            Console.WriteLine("Enter semister marks ");
            Console.WriteLine("Enter subject1 marks : ");
            m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter subject2 marks : ");
            m2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter subject3 marks : ");
            m3 = Convert.ToInt32(Console.ReadLine());
        }
        public void dispsemmarks()
        {
            Console.WriteLine("Semister marks ");
            Console.WriteLine("Subject1 marks : " + m1);
            Console.WriteLine("Subject2 marks : " + m2);
            Console.WriteLine("Subject2 marks : " + m3);
        }
    }
    class practicles : semmarks                       //DERIVED CLASS inherited from semmarks CLASS  
    {                                                 //BASE CLASS FOR student CLASS
        int pm1, pm2;
        public void accppracmarks()
        {
            Console.WriteLine("Enter Practicle marks ");
            Console.WriteLine("Enter praticle1 marks : ");
            pm1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter praticle2 marks : ");
            pm2 = Convert.ToInt32(Console.ReadLine());
        }
        public void disppracmarks()
        {
            Console.WriteLine("Praticle marks ");
            Console.WriteLine("Praticle1 marks : " + pm1);
            Console.WriteLine("Praticle2 marks : " + pm2);
        }
    }
    class student : practicles       //DERIVED CLASS inherited from practicles CLASS
    {
        string sname;
        int rno, sage;
        public void accpdata()
        {
            Console.WriteLine("Enter student details : ");
            Console.Write("Enter student roll no : ");
            rno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter student name : ");
            sname = Console.ReadLine();
            Console.Write("Enter student age : ");
            sage = Convert.ToInt32(Console.ReadLine());
        }
        public void dispdata()
        {
            Console.WriteLine("\nStudent  details are : ");
            Console.WriteLine("Student ID : " + rno);
            Console.WriteLine("Student NAME : " + sname);
            Console.WriteLine("Student Age : " + sage);
        }
    }
    class mulinh
    {
        static void Main()
        {
            student obj1 = new student();
            obj1.accpdata(); obj1.accpsemmarks(); obj1.accppracmarks();
            Console.Clear();  //this method clears the O/P window
            obj1.dispdata(); obj1.dispsemmarks(); obj1.disppracmarks();
            Console.Read();
        }
    }

}
