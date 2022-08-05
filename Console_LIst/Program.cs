using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

  namespace Console_LIst
{
    class Program
    {
        static void Main(string[] args)
        {
            Math objmath = new Math();
            List<student> objstudent_List = new List<student>();
            student s1 = new student();
            s1.Id = 10;
            s1.Name = "a";
            objstudent_List.Add(s1);

            student s2 = new student();
            s2.Id = 10;
            s2.Name = "a";
            objstudent_List.Add(s2);

            student s3 = new student();
            s3.Id = 10;
            s3.Name = "a";
            objstudent_List.Add(s3);




            List<int> listdata = new List<int>();
            Console.WriteLine("plz enter total number of values count:");
            int total = Convert.ToInt32(Console.ReadLine());

            for(int i=1;i<=total;i++)
            {
                Console.WriteLine("Plz enter " + i + " num :");
                listdata.Add(Convert.ToInt32(Console.ReadLine()));
            }
            //listdata.Add(10);
            //listdata.Add(20);
            Console.WriteLine("Total=" + objmath.add_list(listdata));
            Console.ReadLine();
        }
    }

    class student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
