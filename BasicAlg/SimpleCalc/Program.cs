using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adj meg egy szamot");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adj meg egy masikat");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Osszeg: {0}\nKulonbseg: {1}\nSzorzat: {2}", a + b, a - b, a * b);

            if (a % b == 0)
            {
                Console.WriteLine("Hanyados: {0}", a / b);
            }
            else
            {
                Console.WriteLine("Nincs hanyados.");
            }

            Console.ReadKey();
        }
    }
}
