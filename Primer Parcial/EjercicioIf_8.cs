using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicional_If
{
    internal class EjercicioIf_8
    {
         void Main(string[] args)
        {
            int AA = 2024;
            System.Console.WriteLine("Ingresa un año: ");
            int AI = int.Parse(Console.ReadLine());
            int Mod = (AA - AI) % 4;
            if (Mod == 0)
            { System.Console.WriteLine("Es año bisiesto: " + AI); }
            else { System.Console.WriteLine("No es año bisiesto: " + AI); }
            Console.ReadKey();
        }
    }
}
