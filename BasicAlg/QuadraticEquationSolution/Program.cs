using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquationSolution
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
                Console.WriteLine("Nincs megoldas");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
                double x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
                Console.WriteLine("Megoldas:\n{0}\n{1}", x1, x2);
            }
            Console.ReadKey();
        }
    }
}
