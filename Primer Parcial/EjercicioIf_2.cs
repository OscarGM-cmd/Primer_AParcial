using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicional_If
{
    internal class EjercicioIf_2
    {
         void Main(string[] args)
        {
            System.Console.WriteLine("Escriba su puntuacion de 0 a 120: ");
            double Examen = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Escriba sus programas entregados: ");
            int programas_entregados = int.Parse(Console.ReadLine());
            if (Examen >= 70 && programas_entregados >= 8)
                { System.Console.WriteLine("Aprobado"); }
            else { System.Console.WriteLine("Reprobado"); }
            Console.ReadKey();
        }
    }
}
