using System;
using System.Collections;

namespace Console_Collections_ArrayList
{
    public class CSharpApp
    {
        class Empty
        { }

        static void Main()
        {
            ArrayList da = new ArrayList();

            da.Add("Visual Basic");
            da.Add(344);
            da.Add(55);
            da.Add(new Empty());
            da.Remove(55);

            foreach (object el in da)
            {
                Console.WriteLine(el);
            }
        }
    }

}
