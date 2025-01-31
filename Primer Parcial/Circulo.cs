using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_Parcial
{
    internal class Circulo
    {
        void Main(string[] args)
        {
            System.Console.WriteLine("Inserte el radio");
            double Radio = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Inserta tu pi");
            double FI = double.Parse(Console.ReadLine());
            double A = (Math.Pow(Radio,2)) *(FI);
            System.Console.WriteLine("El resultado de la area es: " + A);
            Console.ReadKey();

        }
    }
}
