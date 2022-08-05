using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringBuilder sb = new StringBuilder(50);
            //or
           // StringBuilder sb = new StringBuilder("Hello World!!", 50);

            StringBuilder sb = new StringBuilder("Hello ", 50);

            sb.Append("World!!");
            sb.AppendLine("Hello C#!");
            sb.AppendLine("This is new line.");

            Console.WriteLine(sb);


            StringBuilder amountMsg = new StringBuilder("Your total amount is ");
            amountMsg.AppendFormat("{0:C} ", 25);

            Console.WriteLine(amountMsg);


            //StringBuilder sb = new StringBuilder("Hello World!!", 50);
            //sb.Insert(5, " C#");

            //Console.WriteLine(sb);

            //StringBuilder sb = new StringBuilder("Hello World!!", 50);
            //sb.Remove(6, 7);

            //Console.WriteLine(sb);


            //StringBuilder sb = new StringBuilder("Hello World!!", 50);
            //sb.Replace("World", "C#");

            //Console.WriteLine(sb);


            Console.ReadLine();
        }
    }
}
