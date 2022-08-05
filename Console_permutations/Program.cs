using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_permutations
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "123445678";
            var results =
                from e in Enumerable.Range(0, 1 << str.Length)
                let p =
                    from b in Enumerable.Range(0, str.Length)
                    select (e & (1 << b)) == 0 ? (char?)null : str[b]
                select string.Join(string.Empty, p);

            foreach (var a in results)
            {
                if (a != "")
                {
                    int num, sum = 0, r;
                    num = int.Parse(a);
                    while (num != 0)
                    {
                        r = num % 10;
                        num = num / 10;
                        sum = sum + r;
                    }
                    if (sum == 8)
                    {
                        Console.WriteLine(a + "=" + sum);
                    }
                   // Console.WriteLine(a);
                }
            }

            Console.ReadLine();
        }
    }
}
