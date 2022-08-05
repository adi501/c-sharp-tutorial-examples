using System;

namespace Console_Inheritance
{
    public class A
    {
        public int id, age;
        public string ename, designation;
        public void getdata()
        {
            Console.WriteLine("Enter Employ Details");
            this.id = int.Parse(Console.ReadLine());
            this.age = int.Parse(Console.ReadLine());
            this.ename = Console.ReadLine();
            this.designation = Console.ReadLine();
        }

        public void displaydata()
        {
            Console.WriteLine("The Details of Employee :");
            Console.WriteLine("The Id :" + id);
            Console.WriteLine("The Name :" + ename);
            Console.WriteLine("The designation :" + designation);
            Console.WriteLine("The Age :" + age);
        }

    }

    class B : A
    {
        int projid;
        string proname;
        string projlead;
        public void getprojdata()
        {
            Console.WriteLine("Enter Project Details");
            this.projid = int.Parse(Console.ReadLine());
            this.proname = Console.ReadLine();
            this.projlead = Console.ReadLine();
        }

        public void displayprojdata()
        {
            Console.WriteLine("The Details of Employee :");
            Console.WriteLine("The Proj Id :" + projid);
            Console.WriteLine("The Proj Name :" + proname);
            Console.WriteLine("The Proj Leader :" + projlead);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            B obj = new B();

            obj.getdata();
            obj.displaydata();


            obj.getprojdata();
            obj.displayprojdata();
            Console.ReadLine();
        }
    }
}
