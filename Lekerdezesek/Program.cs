using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekerdezesek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nevek = { "János", "Tamás", "Andi", "József", "Tündi", "Trixi", "Alajos" };

            var csoportok = from nev in nevek
                      group nev by nev[0];

            foreach (var csoport in csoportok.OrderBy(x => x.Key))
            {
                Console.WriteLine(csoport.Key + $" ({csoport.Count()} db):");

                foreach (var tag in csoport.OrderBy(x => x))
                {
                    Console.WriteLine("\t" + tag);
                }
            }

            Console.ReadKey();
        }
    }
}
