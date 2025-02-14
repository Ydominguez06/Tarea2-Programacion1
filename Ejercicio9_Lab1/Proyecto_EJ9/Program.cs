using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_EJ9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Haga un programa que de acuerdo al salario calculará el aumento 
            //De 0 a 4999 aumentará 20 %
            //De 5000 a 9999 aumentará 10 %
            //De 10000 a 14999 aumentará 5 %
            //
            //De 15000 adelante 3 %

                        int Salario;
            double salarioAumento;
            double aumento = 0;

            Console.WriteLine("Ingrese su salario");
            Salario = int.Parse(Console.ReadLine());

            if (Salario <= 4999)
            {
                aumento = 0.20;
            }
            else if (Salario >= 5000 && Salario <= 9999)
            {
                aumento = 0.10;
            }
            else if (Salario >= 10000 && Salario <= 14999)
            {
                aumento = 0.05;
            }
            else if (Salario >= 15000)
            {
                aumento = 0.03;
            }

            salarioAumento = Salario * ( 1+ aumento);
            Console.WriteLine($"Su aumento fue L. {Salario * aumento} y su nuevo salario es de L. {salarioAumento}");
            Console.ReadLine();
        }
    }
}
