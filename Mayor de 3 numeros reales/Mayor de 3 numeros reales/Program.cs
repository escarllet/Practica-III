using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayor_de_3_numeros_reales
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3;
            //double y float son tipos de variables numericas reales
            Console.WriteLine("Ingrese un numero");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el ultimo numero");
            n3 = Convert.ToDouble(Console.ReadLine());

            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine("El numero mayor es: " + n1);
            }
            else if (n2 > n1 && n2 > n3)
            {
                Console.WriteLine("El numero mayor es: " + n2);
            }
            else if (n3 > n2 && n3 > n1)
            {
                Console.WriteLine("El numero mayor es: " + n3);
            }
            Console.ReadKey();
        }
    }
}
