using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7Tarea2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string letra;
            Console.WriteLine("Ingrese su caractér: ");
            letra=Console.ReadLine();
            if (letra == "a")
            {
                Console.WriteLine($"La letra {letra} es una vocal");
            }
            else if (letra == "e")
            {
                Console.WriteLine($"La letra {letra} es una vocal");
            }
            else if (letra == "i")
            {
                Console.WriteLine($"La letra {letra} es una vocal");
            }
            else if (letra == "o")
            {
                Console.WriteLine($"La letra {letra} es una vocal");
            }
            else if (letra == "u")
            {
                Console.WriteLine($"La letra {letra} es una vocal");
            }
            else
            {
                Console.WriteLine($"La letra {letra} no es una vocal");
            }
            Console.ReadLine();
        }
    }
}
