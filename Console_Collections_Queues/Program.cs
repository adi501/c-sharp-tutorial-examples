using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Collections_Queues
{
    //ref : files/collections.docx
    class Program
    {
        static void Main()
        {

            //Queue queue = new Queue();
            //queue.Enqueue(3);
            //queue.Enqueue(2);
            //queue.Enqueue(1);
            //queue.Enqueue("Four");

            //Queue queue = new Queue();
            //queue.Enqueue(3);
            //queue.Enqueue(2);
            //queue.Enqueue(1);
            //queue.Enqueue("Four");

            //Console.WriteLine("Number of elements in the Queue: {0}", queue.Count);

            //while (queue.Count > 0)
            //    Console.WriteLine(queue.Dequeue());

            //Console.WriteLine("Number of elements in the Queue: {0}", queue.Count);

            Queue queue = new Queue();
            queue.Enqueue(3);
            queue.Enqueue(2);
            queue.Enqueue(1);
            queue.Enqueue("Four");

            Console.WriteLine("Number of elements in the Queue: {0}", queue.Count);

            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Peek());

            Console.WriteLine("Number of elements in the Queue: {0}", queue.Count);




           // Queue<string> msgs = new Queue<string>();

            //msgs.Enqueue("Message 1");
            //msgs.Enqueue("Message 2");
            //msgs.Enqueue("Message 3");
            //msgs.Enqueue("Message 4");
            //msgs.Enqueue("Message 5");

            //Console.WriteLine(msgs.Dequeue());
            //Console.WriteLine(msgs.Peek());
            //Console.WriteLine(msgs.Peek());

            //Console.WriteLine();

            //foreach (string msg in msgs)
            //{
            //    Console.WriteLine(msg);
            //}
            Console.ReadLine();
        }

    }
}
