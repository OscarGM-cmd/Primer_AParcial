using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicional_If
{
    internal class EjercicioIf_7
    {
         void Main(string[] args)
        {
            System.Console.WriteLine("Primer numero entero: ");
            int N1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Segundo numero entero: ");
            int N2 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Tercer numero entero: ");
            int N3 = int.Parse(Console.ReadLine());  
            if (N1 == N2 && N2 == N3)
            { System.Console.WriteLine("Los tres son iguales"); }
            else if (N1 == N2 & N2 == N3) { System.Console.WriteLine("Hay dos que son iguales"); }
            else { System.Console.WriteLine("No son iguales ninguno de los tres"); }
            Console.ReadKey();
        }
    }
}
