﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Collections_List
{
    //ref : files/collections.docx
    class Program
    {
        static void Main()
        {
            List<string> langs = new List<string>();

            langs.Add("Java");
            langs.Add("C#");
            langs.Add("C");
            langs.Add("C++");
            langs.Add("Ruby");
            langs.Add("Javascript");

            Console.WriteLine(langs.Contains("C#"));

            Console.WriteLine(langs[1]);
            Console.WriteLine(langs[2]);

            langs.Remove("C#");
            langs.Remove("C");

            Console.WriteLine(langs.Contains("C#"));

            langs.Insert(4, "Haskell");

            langs.Sort();

            foreach (string lang in langs)
            {
                Console.WriteLine(lang);
            }
        }
    }
}
