using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Si_es_multiplo_de_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, resto,resto2;
            Console.WriteLine("Escriba un numero");
            n1 = Convert.ToInt32(Console.ReadLine());

            resto = n1 % 10;
            if (resto == 0)
            {
                Console.WriteLine(n1 + " es multiplo de 10");

                Console.WriteLine("Escriba otro numero");
                n2 = Convert.ToInt32(Console.ReadLine());
                resto2 = n2 % 10;
                if (resto2 == 0)
                {
                    Console.WriteLine("El numero " + n2 + ", tambien es multiplo de 10");
                }
            }
            Console.ReadKey();
        }
    }
}