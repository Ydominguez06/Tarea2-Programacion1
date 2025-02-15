using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8_Lab1
{
    internal class Program
    {
        static double CalcularCargos(int horas)
        {
            if (horas <= 3)
                return 2.00;
            else
            {
                double cargo = 2.00 + (horas - 3) * 0.50;

                if (cargo > 10.00)
                    return 10.00;
                else
                    return cargo;
            }
        }

        static void Main()
        {
            int[] horasClientes = new int[3];
            double total = 0;

            Console.WriteLine("ingrese las horas de estacionamiento para los 3 clientes:");

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Cliente {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out horasClientes[i]) || horasClientes[i] < 0)
                {
                    Console.Write("Entrada inválida. Ingrese un número válido: ");
                }
            }

            Console.WriteLine("\nboucher de estacionamiento");
            Console.WriteLine("cliente  Horas  Cargo ($)");


            for (int i = 0; i < 3; i++)
            {
                double cargo = CalcularCargos(horasClientes[i]);
                total += cargo;
                Console.WriteLine($"{i + 1,4}    {horasClientes[i],5}    {cargo,7}");
            }

            Console.WriteLine($"Total: {total,15}");
        }
    }
}
