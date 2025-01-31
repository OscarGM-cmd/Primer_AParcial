using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_Parcial
{
    internal class Suma
    {
        void Main(string[] args)
        {
            System.Console.WriteLine("Inserte 1 numero");
            int N1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Inserta 2 numero");
            int N2 = int.Parse(Console.ReadLine());
            int S = N1 + N2;
            System.Console.WriteLine("El resultado de la suma es: " + S);
            Console.ReadKey();
            
        }
    }
}
