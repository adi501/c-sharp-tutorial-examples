using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Collections_Stacks
{
    //ref : files/collections.docx
    class Program
    {
        static void Main()
        {
            //Stack<int> stc = new Stack<int>();

            //stc.Push(1);
            //stc.Push(4);
            //stc.Push(3);
            //stc.Push(6);
            //stc.Push(4);

            //Console.WriteLine(stc.Pop());
            //Console.WriteLine(stc.Peek());
            //Console.WriteLine(stc.Peek());

            //Console.WriteLine();

            //foreach (int item in stc)
            //{
            //    Console.WriteLine(item);
            //}

            Stack myStack = new Stack();
            myStack.Push("Hello!!");
            myStack.Push(null);
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);

            foreach (var itm in myStack)
                Console.WriteLine(itm);

            //Stack<int> stc = new Stack<int>();

            //stc.Push("aa");
            //stc.Push(4);
            //stc.Push(3);
            //stc.Push(6);
            //stc.Push(4);


            Console.ReadLine();

        }

    }
}
