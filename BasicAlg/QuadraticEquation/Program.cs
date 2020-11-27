using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a?");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b?");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("c?");
            double c = Convert.ToDouble(Console.ReadLine());
            if (Math.Pow(b, 2) - (4 * a * c) < 0)
            {
                Console.WriteLine("nincs megoldas");
            }
            else
            {
                Console.WriteLine("van megoldas");
            }
            Console.ReadKey();
        }
    }
}
