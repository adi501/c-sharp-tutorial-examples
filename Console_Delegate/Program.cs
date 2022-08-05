using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            myclass obj = new myclass();
            obj.longRunning(callback);
            Console.ReadLine();
        }
       static void callback(int i)
        {
          
            Console.WriteLine(i);
        }
    }
    public class myclass
    {
        public delegate void callback(int i);
        public void longRunning(callback obj)
        {
            for(int i=0;i<10000;i++)
            {
                //do somthing
                obj(i);
            }
        }
    }
}
