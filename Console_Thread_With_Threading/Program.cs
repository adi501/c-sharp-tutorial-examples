using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Console_Thread_With_Threading
{
    class Program
    {
        public static void Main()
        {

            //Creates thread objects

            Thread objthread1 = new Thread(Method1);
            Thread objthread2 = new Thread(Method2);

            objthread1.Start();
            objthread2.Start();
            //Method1();
            //Method2();
            Console.ReadLine();

        }

        static void Method1()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Method One Executed " + i.ToString());

                if (i == 20)
                {
                    Thread.Sleep(4000); //Sleep for 1 seconds
                }


            }
        }

        static void Method2()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Method Two Executed " + i.ToString());
               // Thread.Sleep(4000); //Sleep for 4 seconds
                if (i == 10)
                {
                    Thread.Sleep(3000); //Sleep for 1 seconds
                }

            }
        }

    }
}
