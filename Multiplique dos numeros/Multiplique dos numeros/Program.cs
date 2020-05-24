using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplique_dos_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2,resul;
            Console.WriteLine("Escriba un numero");
            n1 = Convert.ToInt32(Console.ReadLine());
            if (n1==0)
            {
                Console.WriteLine("El producto de 0 por cualquier numero es 0");
            }
            else
            {
                Console.WriteLine("Escriba otro numero");
                n2 = Convert.ToInt32(Console.ReadLine());
                resul = n1 * n2;
                Console.WriteLine("El resultado de la multiplicacion es: "+ resul);
            }


            Console.ReadKey();
        }
    }
}
