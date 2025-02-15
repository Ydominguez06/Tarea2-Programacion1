
namespace Ejercicio5_Lab1
{
    //Haga un programa que diga la cantidad de cifras si es mayor a
//0 y menor a 10 dirá uno, si es mayor o igual a 10 y menor a 100
//mostrará dos, si es mayor o igual a 100 o menor a 1000 mostrará tres, si
//es mayor o igual a 1000 y menor a 10000 mostrará 4, caso contrario
//mostrará mayor a 5.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine());
            string mensaje = ObtenerMensajeCantidadCifras(numero);
            Console.WriteLine(mensaje);
        }

        static string ObtenerMensajeCantidadCifras(int numero)
        {
            if (numero > 0 && numero < 10)
            {
                return "uno";
            }
            else if (numero >= 10 && numero < 100)
            {
                return "dos";
            }
            else if (numero >= 100 && numero < 1000)
            {
                return "tres";
            }
            else if (numero >= 1000 && numero < 10000)
            {
                return "cuatro";
            }
            else
            {
                return "mayor a cinco";
            }
        }
    }
}