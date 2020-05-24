using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplo_de_4_o_de_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, resto1, resto2;
            Console.WriteLine("Escriba un numero");
            n1 = Convert.ToInt32(Console.ReadLine());
            resto1 = n1 % 4;
            resto2 = n1 % 5;
            if (resto1 == 0)
            {
                Console.WriteLine(n1 +" es multiplo de 4");
            }
            if (resto2 == 0) 
            {
                Console.WriteLine(n1 + " es multiplo de 5");
            }
            // Decidi usar dos if en vez de un if y un else if, porque un numero puede ser multiplo de 4 y de 5 al mismo tiempo.
        }
    }
}
