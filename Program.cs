using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadratika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Ingresa a");
            float a = float.Parse(Console.ReadLine());
            System.Console.WriteLine("Inserta b");
            float b = float.Parse(Console.ReadLine());
            System.Console.WriteLine("Inserta c");
            float c = float.Parse(Console.ReadLine());
            double X = Math.Pow(b,2) - 4 * a * c;
            if (X < 0)
            {
                System.Console.WriteLine("El valor de tu x1= " + -b + "+" + Math.Sqrt(-1 * X) + "i" + " / " + 2 * a + " El valor de tu x2= " + -b + "-" + Math.Sqrt(-1 * X) + "i" + " / " + 2 * a);
            }
            else
            {
                System.Console.WriteLine("X1 = " + (-b - Math.Sqrt(X)) / (2 * a) + "X2 = " + (-b + Math.Sqrt(X)) / (2 * a));
            }   
            Console.ReadKey();
        }
    }
}
