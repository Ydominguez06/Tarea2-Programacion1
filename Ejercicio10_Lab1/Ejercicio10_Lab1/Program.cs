using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10_Lab1
{
    internal class Program
    {
        static int Centigrados(int fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        
        static int Fahrenheit(int celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        static void Main()
        {
            Console.WriteLine("tabla para conversion de temperatura");
            Console.WriteLine(".................................");
            Console.WriteLine("Celsius a fahrenheit / fahrenheit a celsius");
            Console.WriteLine(".................................");

            for (int celsius = 0, fahrenheit = 32; celsius <= 100 || fahrenheit <= 212; celsius++, fahrenheit++)
            {
                if (celsius <= 100 && fahrenheit <= 212)
                    Console.WriteLine($"{celsius,7}°C -> {Fahrenheit(celsius),7}°F  |  {fahrenheit,7}°F -> {Centigrados(fahrenheit),7}°C");
                else if (celsius <= 100)
                    Console.WriteLine($"{celsius,7}°C -> {Fahrenheit(celsius),7}°F  |");
                else
                    Console.WriteLine($"                        |  {fahrenheit,7}°F -> {Centigrados(fahrenheit),7}°C");
            }
        }
    }
}