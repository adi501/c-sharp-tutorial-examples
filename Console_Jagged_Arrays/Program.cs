using System;

namespace Console_Jagged_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] A = new int[4][];
            A[0] = new int[3];
            A[1] = new int[4];
            A[2] = new int[2];
            A[3] = new int[4];
            Console.WriteLine("Enter elements into Array:");
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A[i].Length; j++)
                {
                    A[i][j] = int.Parse(Console.ReadLine());
                
                
                }
            }


            Console.WriteLine("Elemetns of the Array:");
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A[i].Length; j++)
                {
                    Console.Write(A[i][j] + " ");

                }
                Console.WriteLine("");
            }

            Console.ReadLine();
        }
    }
}
