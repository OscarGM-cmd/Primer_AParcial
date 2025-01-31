using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicional_If
{
    internal class EjercicioIf_9
    {
         void Main(string[] args)
        {
            System.Console.WriteLine("Ingresa tu valor A: ");
            double A = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingresa tu valor B: ");
            double B = double.Parse(Console.ReadLine());
            if (A == 0)
            { System.Console.WriteLine("No tiene solucion" ); }
            else if (A == 0 && B == 0) { System.Console.WriteLine("Todos los numeros son solucion: "); }
            else { System.Console.WriteLine("El resultado de x es: " + (-B/A) ); }
            Console.ReadKey();
        }
    }
}
