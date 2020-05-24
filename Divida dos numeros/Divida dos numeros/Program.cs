using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divida_dos_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, resul;
            Console.WriteLine("Escriba un numero");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba otro numero");
            n2 = Convert.ToInt32(Console.ReadLine());
            if (n2 != 0)
            {
                resul = n1 / n2;
                Console.WriteLine("El resultado de la divicion es: " + resul);
            }
            else
            {
                Console.WriteLine("Error: No se puede dividir entre 0");
            }


            Console.ReadKey();
        }
    }
}