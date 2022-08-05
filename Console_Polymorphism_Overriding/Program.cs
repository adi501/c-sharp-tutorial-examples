using System;

namespace Console_Polymorphism_Overriding
{
    //ref:https://www.onlinebuff.com/article_oops-principle-polymorphism-in-c-with-an-example_17.html
    //ref:http://www.c-sharpcorner.com/UploadFile/0c1bb2/polymorphism-in-C-Sharp/
    //ref:http://www.aspdotnet-suresh.com/2013/09/polymorphism-in-c-with-example-types-of-polymorphism.html
    public class clsShape
    {
       // public int _radius = 5;
        public virtual double getArea(int _radius)
        {
            return 10;
        }
    }

    public class clsCircle : clsShape
    {
        public override double getArea(int _radius)
        {
            return 20;
           // return 3.14 * _radius * _radius;
        }
    }

    public class clsSphere : clsShape
    {
        public override double getArea(int _radius)
        {
            return 30;
            //return 4 * 3.14 * _radius * _radius;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {


            clsShape obj = new clsShape();
            Console.WriteLine(obj.getArea(20));

             obj = new clsCircle();
            Console.WriteLine(obj.getArea(20));

             obj = new clsSphere();
            Console.WriteLine(obj.getArea(20));


            




            //clsShape objShape1 = new clsCircle();
            //clsShape objShape2 = new clsSphere();
            //Console.WriteLine("Radius of a Cirle is - {0}", objShape1.getArea(10));
            //Console.WriteLine("Radius of a Sphere is - {0}", objShape2.getArea(10));
            Console.ReadLine();

        }
    }













    //class Empinfo
    //{
    //    int Empid;
    //    string Ename, address;
    //    double salary;

    //    public void GetData()
    //    {
    //        Empid = 10;
    //        Ename = "Rahul";
    //        address = "JubileeHills";
    //        //salary = 50000;
    //    }

    //    public virtual void ShowData()
    //    {
    //        Console.WriteLine("Empid:" + Empid);
    //        Console.WriteLine("Emp name:" + Ename);
    //        Console.WriteLine("Address:" + address);
    //        Console.WriteLine("Salary:" + salary);
    //    }

    //}

    //class managerInfo : Empinfo
    //{
    //    int basic;
    //    double pf, Tax;
    //    double netsal;

    //    public void GetmanagerInfo()
    //    {
    //        GetData();
    //        basic = 40000;
    //        pf = basic * (0.08);
    //        Tax = basic * (0.05);
    //        netsal = basic + pf + Tax;
    //    }

    //    public override void ShowData()
    //    {
    //        base.ShowData();
    //        Console.WriteLine("Manager basic salary:" + basic);
    //        Console.WriteLine("Pf:" + pf);
    //        Console.WriteLine("Income tax:" + Tax);
    //        Console.WriteLine("Net salary:" + netsal);

    //    }
    //}

    //class Overriding
    //{
    //    static void Main(string[] args)
    //    {
    //        managerInfo obj = new managerInfo();
    //        obj.GetmanagerInfo();
    //        obj.ShowData();
    //        Console.ReadLine();

    //    }
    //}
}
