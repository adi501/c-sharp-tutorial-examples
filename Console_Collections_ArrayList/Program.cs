using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Collections_ArrayList
{
    //ref : files/collections.docx
    class Program
    {
        class Empty
        { }

        static void Main()
        {

            //ArrayList arryList1 = new ArrayList();
            //arryList1.Add(1);
            //arryList1.Add("Two");
            //arryList1.Add(3);
            //arryList1.Add(4.5);

            //ArrayList arryList2 = new ArrayList();
            //arryList2.Add(100);
            //arryList2.Add(200);

            ////adding entire arryList2 into arryList1
            //arryList1.AddRange(arryList2);

            //foreach (var el in arryList1)
            //{
            //    Console.WriteLine(el);
            //}

            //ArrayList myArryList = new ArrayList();
            //myArryList.Add(1);
            //myArryList.Add("Two");
            //myArryList.Add(3);
            //myArryList.Add(4.5f);

            ////Access individual item using indexer
            //int firstElement = (int)myArryList[0]; //returns 1
            //string secondElement = (string)myArryList[1]; //returns "Two"
            //int thirdElement = (int)myArryList[2]; //returns 3
            //float fourthElement = (float)myArryList[3]; //returns 4.5

            ////use var keyword
            //var firstElement1 = myArryList[0]; //returns 1


            //ArrayList myArryList = new ArrayList();
            //myArryList.Add(1);
            //myArryList.Add("Two");
            //myArryList.Add(3);
            //myArryList.Add(4.5);

            //myArryList.Insert(1, "Second Item");
            //myArryList.Insert(2, 100);

            //foreach (var val in myArryList)
            //    Console.WriteLine(val); 

            //ArrayList arryList1 = new ArrayList();
            //arryList1.Add(100);
            //arryList1.Add(200);

            //ArrayList arryList2 = new ArrayList();
            //arryList2.Add(10);
            //arryList2.Add(20);
            //arryList2.Add(30);

            //arryList2.InsertRange(2, arryList1);

            //foreach (var item in arryList2)
            //    Console.WriteLine(item);


            //ArrayList arryList1 = new ArrayList();
            //arryList1.Add(100);
            //arryList1.Add(200);
            //arryList1.Add(300);

            //arryList1.Remove(100); //Removes 1 from ArrayList

            //foreach (var item in arryList1)
            //    Console.WriteLine(item);

            //ArrayList arryList1 = new ArrayList();
            //arryList1.Add(100);
            //arryList1.Add(200);
            //arryList1.Add(300);

            //arryList1.RemoveAt(1); //Removes the first element from an ArrayList

            //foreach (var item in arryList1)
            //    Console.WriteLine(item);


            //ArrayList arryList1 = new ArrayList();
            //arryList1.Add(100);
            //arryList1.Add(200);
            //arryList1.Add(300);

            //arryList1.RemoveRange(0, 2);//Removes two elements starting from 1st item (0 index)

            //foreach (var item in arryList1)
            //    Console.WriteLine(item);

            ArrayList arryList1 = new ArrayList();
            arryList1.Add(300);
            arryList1.Add(200);
            arryList1.Add(100);
            arryList1.Add(500);
            arryList1.Add(400);

            Console.WriteLine("Original Order:");

            foreach (var item in arryList1)
                Console.WriteLine(item);

            arryList1.Reverse();
            Console.WriteLine("Reverse Order:");

            foreach (var item in arryList1)
                Console.WriteLine(item);

            arryList1.Sort();
            Console.WriteLine("Ascending Order:");

            foreach (var item in arryList1)
                Console.WriteLine(item);






            //ArrayList da = new ArrayList();

            //da.Add("Visual Basic");
            //da.Add(344);
            //da.Add(55);
            //da.Add("dd");
            //da.Remove(55);

            //foreach (object el in da)
            //{
            //    Console.WriteLine(el);
            //}

            Console.ReadLine();
        }

    }
}
