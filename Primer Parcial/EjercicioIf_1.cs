using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicional_If
{
    internal class Ejercicio_1
    {
         void Main(string[] args)
        {
            System.Console.WriteLine("Escriba su puntuacion de 0 a +100: " );
            int Puntuacion = int.Parse(Console.ReadLine());
            if (Puntuacion > 100) {System.Console.WriteLine("Alto");}
            else {System.Console.WriteLine("Bajo");}
            Console.ReadKey();
        }
    }
}
