using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Un_numero_es_multiplo_del_otro
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, resto;
            Console.WriteLine("Escriba un numero");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba otro numero");
            n2 = Convert.ToInt32(Console.ReadLine());

            resto = n1 % n2;
            if (resto == 0)
            {
                Console.WriteLine(n1+" es multiplo de "+n2);
            }
            else
            {
                Console.WriteLine(n1 + " NO es multiplo de " + n2);
            }
            Console.ReadKey();
        }
    }
}
