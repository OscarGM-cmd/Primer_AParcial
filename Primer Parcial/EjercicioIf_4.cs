using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicional_If
{
    internal class EjercicioIf_4
    {
         void Main(string[] args)
        {
            System.Console.WriteLine("Escriba su temperatura: ");
            double Temperatura = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Escriba su presion: ");
            float Presion = float.Parse(Console.ReadLine());
            if (Temperatura > 200 & Presion > 100)
            { System.Console.WriteLine("Alarmante"); }
            else { System.Console.WriteLine("Normal"); }
            Console.ReadKey();
        }
    }
}
