using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Collections_Hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
           // Hashtable ht = new Hashtable();

            //ht.Add(1, "One");
            //ht.Add(2, "Two");
            //ht.Add(3, "Three");
            //ht.Add(4, "Four");
            ////ht.Add(4, "Four"); //error
            //ht.Add(6, "Four");
            //ht.Add(5, null);
            //ht.Add("Fv", "Five");
            //ht.Add(8.5F, 8.5);

            Hashtable ht = new Hashtable()
                {
                    { 1, "One" },
                    { 2, "Two" },
                    { 3, "Three" },
                    { 4, "Four" },
                    { 5, null },
                    { "Fv", "Five" },
                    { 8.5F, 8.5 }
                };


            Console.ReadLine();
        }
    }
}
