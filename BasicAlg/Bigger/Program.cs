using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bigger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adj meg egy szamot");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adj meg egy masik szamot");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }
            Console.ReadKey();
        }
    }
}
