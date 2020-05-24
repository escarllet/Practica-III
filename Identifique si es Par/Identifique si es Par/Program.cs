using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mandato_1_diga_si_es_par
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Introduzca un numero");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = n1 % 2;
            if (n2 == 0)
            {
                Console.WriteLine("El numero es par");

            }
        }
    }
}
