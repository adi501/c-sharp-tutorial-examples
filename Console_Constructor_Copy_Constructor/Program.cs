using System;

namespace Console_Constructor_Copy_Constructor
{


    class Sample
    {
        public string param1, param2;
        public Sample(string x, string y)
        {
            param1 = x;
            param2 = y;

            Console.WriteLine(param1 + " to " + param2);

            param1 = x+" 11111111";
            param2 = y+" 22222222";


        }
        public Sample(Sample obj)     // Copy Constructor
        {
            param1 = obj.param1;
            param2 = obj.param2;

            Console.WriteLine(param1 + " to " + param2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sample obj = new Sample("Welcome", "Red coin");  // Create instance to class Sample
            //Console.WriteLine(obj.param1 + " to " + obj.param2);

            Sample obj1 = new Sample(obj); // Here obj details will copied to obj1
           // Console.WriteLine(obj1.param1 + " to " + obj1.param2);
            Console.ReadLine();
        }
    }















    //class sample
    //{
    //    int id;
    //    string name;
    //    string fathername;
    //    string place;

    //    public sample(sample objsample)
    //    {
    //        this.id = objsample.id;
    //        this.name = objsample.name;
    //        this.fathername = objsample.fathername;
    //        this.place = objsample.place;
    //    }

    //    public sample()
    //    {
    //        Console.WriteLine("Enter Values:");
    //        this.id = int.Parse(Console.ReadLine());
    //        this.name = Console.ReadLine();
    //        this.fathername = Console.ReadLine();
    //        this.place = Console.ReadLine();
    //    }

    //    public void display()
    //    {
    //        Console.WriteLine("The details are:");
    //        Console.WriteLine("id:" + id);
    //        Console.WriteLine("Name:" + name);
    //        Console.WriteLine("Father Name:" + fathername);
    //        Console.WriteLine("Place:" + place);

    //    }


    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        sample obj = new sample();
    //        obj.display();
    //        Console.ReadLine();

    //    }
    //}
}
