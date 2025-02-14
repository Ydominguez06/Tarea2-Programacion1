using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_EJ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Haga un programa para la venta de camisas que tiene una promoción,
            // esta dependerá del número de camisas que se compren Si son más de
            // diez, se les dará un 10 % de descuento sobre el total de la compra; si es
            //más de veinte, se les dará un 20 % de descuento; si son más de treinta
            //se les dará un 40 % de descuento.El precio de cada camisa es de 100.
            {
               int numeroCamisas;
                Double precioCamisa, descuento=0,subtotal,total;
                precioCamisa = 100;
                
                Console.WriteLine(" ¿Cuantas camisas esta comprando? ingrese el numero");
                numeroCamisas = int.Parse(Console.ReadLine());

                {
                    if (numeroCamisas >= 10)
                        descuento = 0.40;
                    else if (numeroCamisas >= 20)
                        descuento = 0.20;
                    else if (numeroCamisas >= 40)
                        descuento = 0.10;
                    subtotal = precioCamisa * numeroCamisas; 
                    total = subtotal - (subtotal * descuento);
                   
                    Console.WriteLine($"El subtotal es L. {subtotal}");
                    Console.WriteLine($"El tu descuento fue de L. {descuento}");
                    Console.WriteLine($"El total es L. {total} ");
                   
                }
                

                    Console.ReadLine();
            }

        }
    }
}
