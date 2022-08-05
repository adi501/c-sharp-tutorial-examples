using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Console_Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread objThread1 = new Thread(new ThreadStart(Method1));
            Thread objThread2 = new Thread(new ThreadStart(Method2));
            objThread1.Priority = ThreadPriority.Highest;
            objThread2.Priority = ThreadPriority.Lowest;
            objThread1.Start();

            objThread2.Start();
            Console.ReadLine();
        }

        static void Method1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Method1  " + i.ToString());
                Thread.Sleep(10);
            }
        }
        static void Method2()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Method2  " + i.ToString());
                Thread.Sleep(10);
            }
        }
    }
}
