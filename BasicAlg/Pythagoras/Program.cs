using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pythagoras
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            Console.WriteLine(c.ToString("F2"));

            Console.ReadKey();
        }
    }
}
