﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Collections_LinkedList
{
    //ref : files/collections.docx
    class Program
    {
        static void Main()
        {
            LinkedList<int> nums = new LinkedList<int>();

            nums.AddLast(23);
            nums.AddLast(34);
            nums.AddLast(33);
            nums.AddLast(11);
            nums.AddLast(6);
            nums.AddFirst(9);
            nums.AddFirst(7);

            LinkedListNode<int> node = nums.Find(6);
            nums.AddBefore(node, 5);

            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }
        }

    }
}
