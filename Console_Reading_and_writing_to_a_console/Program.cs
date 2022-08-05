using System;


/// <summary>
/// 1. Reading from the console
///  2. Writing to the console
/// 3. Two ways to write to console
/// a) Concatenation
/// b) Place holder syntax – Most preferred 
/// </summary>
namespace Console_Reading_and_writing_to_a_console
{
    class Program
    {
        
        static void Main()
        {
            // Prompt the user for his name
            Console.WriteLine("Please enter your name");
            // Read the name from console
            string UserName = Console.ReadLine();
            // Concatenate name with hello word and print
            Console.WriteLine("Hello " + UserName);

            //Placeholder syntax to print name with hello word 
            Console.WriteLine("Hello {0}", UserName);
        }
    }
}
