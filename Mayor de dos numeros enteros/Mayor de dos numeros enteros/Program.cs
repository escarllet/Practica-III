using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayor_de_dos_numeros_enteros
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Ingrese un numero");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine(n1 + " es el numero mayor");
            }
            else if (n1 < n2)
            {
                Console.WriteLine(n2 + " es el numero mayor");
            }
            else { Console.WriteLine("Los numeros son iguales"); }
            Console.ReadLine();
        }
    }
}
