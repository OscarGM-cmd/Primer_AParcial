using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicional_If
{
    internal class EjercicioIf_5
    {
         void Main(string[] args)
        {
            System.Console.WriteLine("Primer numero entero: ");
            int N1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Segundo numero entero: ");
            int N2 = int.Parse(Console.ReadLine());
            int N3 = N1 / N2;
            double Mod = N1 % N2;
            if (Mod == 0 )
            { System.Console.WriteLine("Es una division exacta: " + N3 + " es el resultado"); }
            else { System.Console.WriteLine("Es inexacta: " + N3 + " es la division y el residuo es: " + Mod); }
            Console.ReadKey();
        }
    }
}
