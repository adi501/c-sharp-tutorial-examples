using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Prooperties
{
    class propertiesarth
    {
        int n, m, res;
        public int pn
        {
            set { n = value; }
        }
        public int pm
        {
            set { m = value; }
        }
        public int pres
        {
            get { return res; }
        }
        public void add()
        {
            res = n + m;
        }
        public void sub()
        {
            res = n - m;
        }
        public void mul()
        {
            res = n * m;
        }
        public void div()
        {
            res = n / m;
        }
    }
    class clsprop
    {
        static void Main()
        {
            propertiesarth obj1 = new propertiesarth();
            Console.Write("enter n value : ");
            obj1.pn = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nenter m value : ");
            obj1.pm = Convert.ToInt32(Console.ReadLine());
            obj1.add();
            Console.WriteLine("Sum is : " + obj1.pres);
            obj1.sub();
            Console.WriteLine("Sub is : " + obj1.pres);
            obj1.mul();
            Console.WriteLine("Product is : " + obj1.pres);
            obj1.div();
            Console.WriteLine("Division is : " + obj1.pres);
            Console.Read();
        }
    }

    //class Empinfo
    //{
    //    int empid;
    //    string eName;
    //    double salary;

    //    public int Empid // Read and write
    //    {
    //        get
    //        {
    //            return empid;
    //        }
    //        set
    //        {
    //            empid = value;
    //        }
    //    }

    //    public string Ename  // read only proper
    //    {
    //        get
    //        {
    //            return eName;
    //        }
    //    }
    //    public double Salary  //write only property
    //    {
    //        set
    //        {
    //            salary = value;
    //        }
    //    }

    //    public void GetData()
    //    {
    //        this.Empid = 10;
    //        // this.Ename = "Ramu";
    //        eName = "ram";
    //        this.Salary = 25000;
    //    }
    //    public void showData()
    //    {
    //        Console.WriteLine("Id:" + this.Empid);
    //        Console.WriteLine("Name:" + this.Ename);
    //        Console.WriteLine("Salary:" + salary);

    //    }

    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Empinfo obj = new Empinfo();
    //        obj.GetData();
    //        obj.showData();
    //        Console.ReadLine();
    //    }
    //}
}
