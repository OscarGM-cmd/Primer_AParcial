using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicional_If
{
    internal class EjercicioIf_6
    {
         void Main(string[] args)
        {
            System.Console.WriteLine("Primer numero entero: ");
            int N1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Segundo numero entero: ");
            int N2 = int.Parse(Console.ReadLine());
            if (N1 > N2)
            { int N3 = N1 / N2;
              int Mod1 = N1 % N2;
                if (Mod1 == 0) { System.Console.WriteLine("Es multiplo del mayor"); }
                else { System.Console.WriteLine("No es multiplo del mayor"); }
            }
            else if (N1 < N2) {
                int N4 = N2 / N1;
                int Mod1 = N2 % N1;
                if (Mod1 == 0) { System.Console.WriteLine("Es multiplo del mayor"); }
                else { System.Console.WriteLine("No es multiplo del mayor"); }
            }
    }
    }
}
