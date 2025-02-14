using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace P1_EJ12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //- Escriba un programa que juegue a “adivina el número” de la siguiente 
            //manera: su programa elige el número a adivinar, seleccionando un
            //entero aleatorio en el rango de 1 a 1000.Si la respuesta del jugador es
            //incorrecta, su programa deberá iterar hasta que el jugador adivine
            //correctamente.Su programa deberá seguir indicando al jugador los
            //mensajes Demasiado alto o bajo, para ayudar a que el jugador “se
            //acerque” a la respuesta correcta. Si la respuesta es correcta deberá
            //mostrar el siguiente mensaje 
            //¡Excelente! ¡Adivinaste el número!
            Random random = new Random();
            int numeroAdivinar = random.Next(1, 1001);
            int intentoUsuario;
            bool adivinado = false;

            Console.WriteLine("¡Bienvenido a Adivina el Número!");
            Console.WriteLine("He elegido un número entre 1 y 1000. ¿Puedes adivinarlo?");

            while (!adivinado)
            {
                Console.Write("Introduce tu intento: ");
                if (int.TryParse(Console.ReadLine(), out intentoUsuario))
                {
                    if (intentoUsuario < numeroAdivinar)
                    {
                        Console.WriteLine("Demasiado bajo. ¡Intenta de nuevo!");
                    }
                    else if (intentoUsuario > numeroAdivinar)
                    {
                        Console.WriteLine("Demasiado alto. ¡Intenta de nuevo!");
                    }
                    else
                    {
                        adivinado = true;
                        Console.WriteLine("¡Excelente! ¡Adivinaste el número!");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Por favor, introduce un número entero.");
                }
            }

            Console.WriteLine("Gracias por jugar. ¡Presiona cualquier tecla para salir!");
            Console.ReadKey();
        }
    }




}

