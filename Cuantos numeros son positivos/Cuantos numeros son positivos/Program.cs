using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuantos_numeros_son_positivos
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

            if ((n1 > 0 && n2 < 0) || (n1 < 0 && n2>0) )
            {
                Console.WriteLine("Uno de los numeros es positivo");
            }
            else if (n1 > 0 && n2 > 0)
            {
                Console.WriteLine("Los dos numeros son positivos");
            }
            else if (n1 < 0 && n2 < 0)
            {
                Console.WriteLine("Ninguno de los numeros es positivos");
            }
            Console.ReadKey();

        }
    }
}
