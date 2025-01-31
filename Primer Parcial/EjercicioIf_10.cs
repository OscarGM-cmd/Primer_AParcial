using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicional_If
{
    internal class EjercicioIf_10
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Ingresa tu valor A: ");
            double A = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingresa tu valor B: ");
            double B = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingresa tu valor C: ");
            double C = double.Parse(Console.ReadLine());
            if ((Math.Pow(B,2)-4*A*C) < 0) { System.Console.WriteLine("Sin solucion real"); }
            else if ((Math.Pow(B, 2) - 4 * A * C) == 0) { System.Console.WriteLine("Una solucion real: " + (-B/2*A));}
            else if (A == 0) { System.Console.WriteLine("No tiene solucion"); }
            else if (A == 0 && B == 0) { System.Console.WriteLine("Todos los numeros son solucion: "); }
            else { System.Console.WriteLine("El resultado de x1 es: " + (-B + Math.Sqrt(Math.Pow(B, 2) - 4 * A * C)) / 2 * A + " y el resultado de x2 es: " + (-B - Math.Sqrt(Math.Pow(B, 2) - 4 * A * C)) / 2 * A); }
            Console.ReadKey();
        }
    }
}
