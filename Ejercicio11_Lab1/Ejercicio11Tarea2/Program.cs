using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ejercicio11Tarea2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double promediototal, nota1, nota2, nota3;

            Console.WriteLine("Ingrese sus notas:");
            nota1 = double.Parse(Console.ReadLine());
            nota2 = double.Parse(Console.ReadLine());
            nota3 = double.Parse(Console.ReadLine());

            promediototal = (nota1 + nota2 + nota3) / 3;

            if (promediototal < 70)
            {
                Console.WriteLine("Reprueba");
            }
            else if (promediototal <= 80)
            {
                Console.WriteLine("Buena nota");
            }
            else if (promediototal <= 90)
            {
                Console.WriteLine("Muy buena nota");
            }
            else if (promediototal <= 100)
            {
                Console.WriteLine("Sobresaliente");
            }
            else
            {
                Console.WriteLine("No se pudo calcular su promedio");
            }
            Console.ReadLine();
        }
    }
}
