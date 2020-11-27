using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adj meg egy szamot");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}", number * 2);

            Console.ReadKey();

        }
    }
}
