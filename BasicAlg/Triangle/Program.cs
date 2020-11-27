using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *A háromszög bármely oldalának hossza kisebb a másik két oldal hosszának összegénél. Azaz: a<b+c, b<a+c, c<a+b 
 *Nem szerkesztheto: 2,3,6
 *Szerkesztheto: 6,5,3
 */
namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A oldal?");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B oldal?");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("C oldal?");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a < b + c && b < a + c && c < a + b)
            {
                Console.WriteLine("A haromszog szerkesztheto");
            }
            else
            {
                Console.WriteLine("nem.");
            }
            Console.ReadKey();
        }
    }
}
