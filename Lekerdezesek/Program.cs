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
            int[] szamok = { 4, 5, 1, 2, 8, 9, 7, 3 };

            string[] nums = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var kicsi = (from szam in szamok
                        where szam >= 2 && szam <= 6
                        orderby szam descending
                        select nums[szam]).ToList();

            foreach (var k in kicsi)
            {
                Console.WriteLine(k);
            }

            Console.ReadKey();
        }
    }
}
