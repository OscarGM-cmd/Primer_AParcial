using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_Parcial
{
    internal class Triangulo
    {
        void Main(string[] args)
        {
            System.Console.WriteLine("Inserte tu base");
            float Base = float.Parse(Console.ReadLine());
            System.Console.WriteLine("Inserta tu altura");
            float Altura = float.Parse(Console.ReadLine());
            float Area = (Base * Altura)/2;
            System.Console.WriteLine("El resultado del triangulo es: " + Area);
            Console.ReadKey();

        }
    }
}
