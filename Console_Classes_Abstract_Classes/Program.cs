using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Classes_Abstract_Classes
{

    //ref:http://www.advancesharp.com/blog/1095/abstract-class-in-c-with-example
    public abstract class Person
    {
        public void CanWalk()
        {
            Console.WriteLine("Yes, I can walk");
        }
        public virtual void CanEat()
        {
            Console.WriteLine("Yes, I can Eat Rice");
        }
        public abstract void CanSpeakLanguages();
    }
    public class American : Person
    {
        //public American()
        //{
        //    Console.WriteLine("American Class:");
        //}
        public override void CanEat()
        {
            Console.WriteLine("Yes, I can Eat Burger");
        }
        public override void CanSpeakLanguages()
        {
            Console.WriteLine("I can speak English");
        }
    }
    public class Indian : Person
    {
        //public Indian()
        //{
        //    Console.WriteLine("Indian Class:");
        //}
        public override void CanSpeakLanguages()
        {
            Console.WriteLine("I can speak Hindi, Urdu and English");
        }
    }
    public class Chinese : Person
    {
        //public Chinese()
        //{
        //    Console.WriteLine("Chinese Class:");
        //}
        public override void CanEat()
        {
            Console.WriteLine("Yes, I can Eat Noodles");
        }
        public override void CanSpeakLanguages()
        {
            Console.WriteLine("I can speak Mandolin");
        }
    }
    public class MainClass
    {
       static void Main()
        {
            Person objperson = new American();
            objperson.CanWalk();
            objperson.CanSpeakLanguages();
            objperson.CanEat();
            Console.WriteLine();

            objperson = new Indian();
            objperson.CanWalk();
            objperson.CanSpeakLanguages();
            objperson.CanEat();
            Console.WriteLine();

            objperson = new Chinese();
            objperson.CanWalk();
            objperson.CanSpeakLanguages();
            objperson.CanEat();
            Console.WriteLine();
            Console.ReadLine();
        }
    }








    //abstract class absCalculate
    //{
    //    //A Non abstract method
    //    public int Addition(int Num1, int Num2)
    //    {
    //        return Num1 + Num2;
    //    }

    //    //An abstract method, to be overridden in derived class
    //    public abstract int Multiplication(int Num1, int Num2);
    //}
    //class clsCalculate : absCalculate
    //{

    //    //using override keyword implementing the abstract method
    //    public override int Multiplication(int Num1, int Num2)
    //    {
    //        return Num1 * Num2;
    //    }
    //}



    ////Abstract class
    //abstract class Shape
    //{
    //    protected float R, L, B;
    //    //Abstract methods can have only declarations
    //    public abstract float Area();
    //    public abstract float Circumference();
    //}
    //class Rectangle : Shape
    //{
    //    public void GetLB()
    //    {
    //        Console.Write("Enter  Length  :  ");
    //        L = float.Parse(Console.ReadLine());
    //        Console.Write("Enter Breadth : ");
    //        B = float.Parse(Console.ReadLine());
    //    }
    //    public override float Area()
    //    {
    //        return L * B;
    //    }
    //    public override float Circumference()
    //    {
    //        return 2 * (L + B);
    //    }
    //}
    //class Circle : Shape
    //{
    //    public void GetRadius()
    //    {
    //        Console.Write("Enter  Radius  :  ");

    //        R = float.Parse(Console.ReadLine());
    //    }
    //    public override float Area()
    //    {
    //        return 3.14F * R * R;
    //    }
    //    public override float Circumference()
    //    {
    //        return 2 * 3.14F * R;
    //    }
    //}
    //class MainClass
    //{
    //    public static void Calculate(Shape S)
    //    {
    //        Console.WriteLine("Area : {0}", S.Area());
    //        Console.WriteLine("Circumference : {0}", S.Circumference());
    //    }
    //    static void Main()
    //    {
    //        Rectangle R = new Rectangle();
    //        R.GetLB();
    //        Calculate(R);
    //        Console.WriteLine();
    //        Circle C = new Circle();
    //        C.GetRadius();
    //        Calculate(C);
    //        Console.Read();
    //    }
    //}
}
