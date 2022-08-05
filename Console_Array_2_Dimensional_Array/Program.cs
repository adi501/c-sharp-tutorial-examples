using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Array_2_Dimensional_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] A = new int[2, 2];
            Console.WriteLine("Enter the values into Array:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Elements of the array:");
            // Console.WriteLine("Enter the values into Array:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
            Console.ReadLine();

        }
    }
}
