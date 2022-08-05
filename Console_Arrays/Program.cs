using System;

namespace Console_Arrays
{
    class Program
    {


        static void Main(string[] args)
        {



            //int[] xyz = { 1, 2, 3, 4, 5 };

            //xyz = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            ////xyz[5] = 20;

            //foreach(int xy in xyz)
            //{
            //    Console.WriteLine(xy);
            //}


            //int[] xyz;

            //xyz = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            //foreach(int xy in xyz)
            //{
            //    Console.WriteLine(xy);
            //}

            int[] xyz;
            xyz = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            foreach (int xy in xyz)
            {
                if (xy % 2 == 0)
                {
                    Console.WriteLine(xy);
                }
            }
           
            for (int i = 2; i < xyz.Length-2; i++)
            {
                Console.Write(xyz[i] + " ");
            }


           // double[] balance = new double[2];

           // balance[0] = 100.00;
           // balance[1] = 100.00;
           //// balance[2] = 100.00;

           //  balance = new double[4];

           // balance[0] = 100.00;
           // balance[1] = 100.00;
           // balance[3] = 100.00;
           // balance[2] = 100.00;


            int[] marks = new int[5] { 99, 98, 92, 97, 95};

            int mydata = marks[3];

            int n;
            Console.WriteLine("Enter the size of the array:");
            n = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[n];
            //A[0] = 10;
            //A[1] = 20;
            //A[2] = 30;
            //A[3] = 40;
            //A[4] = 50;
            Console.WriteLine("Enter elements into Array:");
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }

            //Console.Write(A[0] + " ");
            //Console.Write(A[1] + " ");
            //Console.Write(A[2] + " ");
            //Console.Write(A[3] + " ");
            //Console.Write(A[4] + " ");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }

            Console.ReadLine();



        }
    }
}
