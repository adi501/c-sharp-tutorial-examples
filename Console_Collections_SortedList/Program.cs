using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Collections_SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
           // SortedList sortedList1 = new SortedList();
           // sortedList1.Add(3, "Three");
           // sortedList1.Add(4, "Four");
           // sortedList1.Add(1, "One");
           // sortedList1.Add(5, "Five");
           // sortedList1.Add(2, "Two");
           // sortedList1.Add(10, "ten");

           // SortedList sortedList2 = new SortedList();
           // sortedList2.Add("one", 1);
           // sortedList2.Add("two", 2);
           // sortedList2.Add("three", 3);
           // sortedList2.Add("four", 4);

           // SortedList sortedList3 = new SortedList();
           // sortedList3.Add(1.5, 100);
           // sortedList3.Add(3.5, 200);
           // sortedList3.Add(2.4, 300);
           // sortedList3.Add(2.3, null);
           // sortedList3.Add(1.1, null);


           // SortedList sortedList = new SortedList();

           // sortedList.Add(3, "Three");
           // //sortedList.Add(3, "Three");
           // sortedList.Add(4, "Three");
           // sortedList.Add(5, "Three");
           //// sortedList.Add("Four", "Four"); // Throw exception: InvalidOperationException
           // sortedList.Add(1, "One");
           // sortedList.Add(8, "Five");
           // sortedList.Add(2, "Two");

            //SortedList sortedList2 = new SortedList();
            //sortedList2.Add("one", 1);
            //sortedList2.Add("two", 2);
            //sortedList2.Add("three", 3);
            //sortedList2.Add("four", 4);

            //for (int i = 0; i < sortedList2.Count; i++)
            //{
            //    Console.WriteLine("key: {0}, value: {1}",
            //                        sortedList2.GetKey(i), sortedList2.GetByIndex(i));
            //}

            //SortedList sortedList1 = new SortedList();
            //sortedList1.Add(1, "one");
            //sortedList1.Add(2, "two");
            //sortedList1.Add(3, "three");
            //sortedList1.Add(4, "four");


            //foreach (DictionaryEntry kvp in sortedList1)
            //    Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);

            SortedList sortedList = new SortedList();
            sortedList.Add(3, "Three");
            sortedList.Add(2, "Two");
            sortedList.Add(4, "Four");
            sortedList.Add(1, "One");
            sortedList.Add(8, "Five");
            sortedList.Add(9, "Five");

         bool r1=   sortedList.Contains(5); // returns true
         bool r2 = sortedList.Contains(4); // returns true
         bool r3 = sortedList.Contains(6); // returns false

         bool r4 = sortedList.ContainsKey(8); // returns true
         bool r5 = sortedList.ContainsKey(6); // returns false

         bool r6 = sortedList.ContainsValue("One"); // returns true
         bool r7 = sortedList.ContainsValue("Ten"); // returns false


            Console.ReadLine();

        }
    }
}
