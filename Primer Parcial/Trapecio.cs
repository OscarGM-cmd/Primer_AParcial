using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_Parcial
{
    internal class Trapecio
    {
        void Main(string[] args)
        {
            System.Console.WriteLine("Base Mayor: ");
            float BaM = float.Parse(Console.ReadLine());
            System.Console.WriteLine("Base Menor: ");
            float Bam = float.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingresa tu Altura: ");
            float Altura = float.Parse(Console.ReadLine());
            float Area = ((BaM + Bam) * Altura) / 2;
            System.Console.WriteLine("El resultado de la area es: " + Area);
            Console.ReadKey();

        }
    }
}
