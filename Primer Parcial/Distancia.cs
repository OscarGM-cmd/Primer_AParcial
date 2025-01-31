using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_Parcial
{
    internal class Distancia
    {
        void Main(string[] args)
        {
            System.Console.WriteLine("Ingresa X1");
            float X1 = float.Parse(Console.ReadLine());
            System.Console.WriteLine("Inserta X2");
            float X2 = float.Parse(Console.ReadLine());
            System.Console.WriteLine("Inserta Y1");
            float Y1 = float.Parse(Console.ReadLine());
            System.Console.WriteLine("Inserta Y2");
            float Y2 = float.Parse(Console.ReadLine());
            float Raiz = 2;
            float Raiz2 = 1 / Raiz;
            double Distancia = Math.Pow((Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2)) , Raiz2);
            System.Console.WriteLine("El resultado de la area es: " + Distancia);
            Console.ReadKey();

        }
    }
}
