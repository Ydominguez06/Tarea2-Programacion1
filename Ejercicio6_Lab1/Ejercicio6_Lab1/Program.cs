using System;

namespace Ejercicio6_Lab1
{
    //Un almacén de pedidos por correo vende cinco productos distintos,
    //cuyos precios de venta son los siguientes: producto 1, $2.98; producto
    //2, $4.50; producto 3, $9.98; producto 4, $4.49 y producto 5, $6.87.
    //Escriba un programa que lea una serie de pares de números, como se
    //muestra a continuación:
    //a) número del producto
    //b) cantidad vendida
    // Su programa debe utilizar una instrucción switch para determinar el
    //precio de venta de cada producto.Debe calcular y mostrar el valor total
    // de venta de todos los productos vendidos.Use un ciclo controlado por
    //centinela para determinar cuándo debe el programa dejar de iterar para
    //mostrar los resultados finales.



    class Program
    {
        static void Main(string[] args)
        {
            double totalVenta = 0;
            int numeroProducto;
            int cantidadVendida;

            while (true)
            {
                Console.Write("Ingrese el número del producto (0 para terminar): ");
                numeroProducto = int.Parse(Console.ReadLine());

                if (numeroProducto == 0)
                {
                    break;
                }

                Console.Write("Ingrese la cantidad vendida: ");
                cantidadVendida = int.Parse(Console.ReadLine());

                double precioProducto = ObtenerPrecioProducto(numeroProducto);
                if (precioProducto != 0)
                {
                    totalVenta += precioProducto * cantidadVendida;
                }
                else
                {
                    Console.WriteLine("Producto no válido.");
                }
            }

            Console.WriteLine($"El valor total de venta de todos los productos vendidos es: {totalVenta:C2}");
        }

        static double ObtenerPrecioProducto(int numeroProducto)
        {
            switch (numeroProducto)
            {
                case 1:
                    return 2.98;
                case 2:
                    return 4.50;
                case 3:
                    return 9.98;
                case 4:
                    return 4.49;
                case 5:
                    return 6.87;
                default:
                    return 0;
            }
        }
    }
}