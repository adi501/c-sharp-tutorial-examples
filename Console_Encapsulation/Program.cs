using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Encapsulation
{
    //Encapsulation is implemented by using access specifiers. An access specifier defines the scope and visibility of a class member. C# supports the following access specifiers:(Public,Private,Protected,Internal,Protected internal)

    // ref :https://www.tutorialspoint.com/csharp/csharp_encapsulation.htm
    //ref : http://www.c-sharpcorner.com/article/encapsulation-in-C-Sharp/

    #region Encapsulation with Public Access Specifier
    class Rectangle
    {
        //member variables
        public double length;
        public double width;

        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }//end class Rectangle

    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.length = 4.5;
            r.width = 3.5;
            r.Display();
            Console.ReadLine();
        }
    }
    #endregion

    //#region Encapsulation with Private  Access Specifier
    //class Rectangle
    //{
    //    //member variables
    //    private double length;
    //    private double width;

    //    public void Acceptdetails()
    //    {
    //        Console.WriteLine("Enter Length: ");
    //        length = Convert.ToDouble(Console.ReadLine());
    //        Console.WriteLine("Enter Width: ");
    //        width = Convert.ToDouble(Console.ReadLine());
    //    }
    //    public double GetArea()
    //    {
    //        return length * width;
    //    }
    //    public void Display()
    //    {
    //        Console.WriteLine("Length: {0}", length);
    //        Console.WriteLine("Width: {0}", width);
    //        Console.WriteLine("Area: {0}", GetArea());
    //    }
    //}//end class Rectangle

    //class ExecuteRectangle
    //{
    //    static void Main(string[] args)
    //    {
    //        Rectangle r = new Rectangle();
    //        r.Acceptdetails();
    //        r.Display();
    //        Console.ReadLine();
    //    }
    //}
    //#endregion

    //#region Encapsulation with Internal Access Specifier
    //class Rectangle
    //{
    //    //member variables
    //    internal double length;
    //    internal double width;

    //    double GetArea()
    //    {
    //        return length * width;
    //    }
    //    public void Display()
    //    {
    //        Console.WriteLine("Length: {0}", length);
    //        Console.WriteLine("Width: {0}", width);
    //        Console.WriteLine("Area: {0}", GetArea());
    //    }
    //}//end class Rectangle

    //class ExecuteRectangle
    //{
    //    static void Main(string[] args)
    //    {
    //        Rectangle r = new Rectangle();
    //        r.length = 4.5;
    //        r.width = 3.5;
    //        r.Display();
    //        Console.ReadLine();
    //    }
    //}
    //#endregion
}


