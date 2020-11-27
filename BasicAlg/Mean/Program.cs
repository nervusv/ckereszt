using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mean
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elso szam");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masodik szam");
            int b = Convert.ToInt32(Console.ReadLine());

            int arithmeticMean = (a + b) / 2;
            Console.WriteLine("Szamtani kozep:{0}", arithmeticMean);

            double geometricalMean = Math.Sqrt(a * b);

            Console.WriteLine("Mertani kozep:{0}", geometricalMean);

            Console.ReadKey();
        }
    }
}
