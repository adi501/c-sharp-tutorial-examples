using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Generic_List
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<int> intList = new List<int>();
            intList.Add(10);
            intList.Add(20);
            intList.Add(30);
            intList.Add(40);


            students stu = new students();
            stu.Id = 1;
            stu.name = "aa";
            stu.cell = "9999";
            stu.email = "eee";
            stu.address = "www";

            Program obj = new Program();
            obj.display(stu);


            List<students> listofstudents = new List<students>();


            students stu1 = new students();
            stu1.Id = 1;
            stu1.name = "aa";
            stu1.cell = "9999";
            stu1.email = "eee";
            stu1.address = "www";

            listofstudents.Add(stu1);

            students stu2 = new students();
            stu2.Id = 1;
            stu2.name = "aa";
            stu2.cell = "9999";
            stu2.email = "eee";
            stu2.address = "www";
            listofstudents.Add(stu2);

            students stu3 = new students();
            stu3.Id = 1;
            stu3.name = "aa";
            stu3.cell = "9999";
            stu3.email = "eee";
            stu3.address = "www";

            listofstudents.Add(stu3);


            obj.display_all(listofstudents);




            Console.ReadLine();
        }
        public void display(students obj)
        {
            int id = obj.Id;
        }

        public void display_all(List<students> list)
        {
            foreach(var v in list)
            {
                Console.WriteLine(v.Id + "  " + v.name);
            }

            foreach (students v in list)
            {
                Console.WriteLine(v.Id + "  " + v.name);
            }
        }
    }

    class students
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string cell { get; set; }
        public string email { get; set; }
        public string address { get; set; }

    }
}
