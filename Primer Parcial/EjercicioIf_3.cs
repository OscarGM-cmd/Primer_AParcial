using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicional_If
{
    internal class EjercicioIf_3
    {
         void Main(string[] args)
        {
            System.Console.WriteLine("Escriba su ahorro: ");
            double Ahorro = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Valor del gasto: ");
            int Gasto = int.Parse(Console.ReadLine());
            if (Ahorro > Gasto)
            { System.Console.WriteLine("Solvente " + (Ahorro - Gasto) + " Ahorro restante"); }
            else { System.Console.WriteLine("Quiebra " + (Ahorro - Gasto) + " Gasto existente"); }
            Console.ReadKey();
        }
    }
}
