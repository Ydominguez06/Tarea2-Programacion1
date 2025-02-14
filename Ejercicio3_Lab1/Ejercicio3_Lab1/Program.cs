
namespace PanaderiaFacturacion
{
    class Program
    {
        //Haga un programa para facturar en una panadería, da un descuento por
//comprar a sus clientes con membresía dependiendo el tipo, si es tipo A
//da 10% de descuento, si es tipo B da 15% de descuento y 20% de
//descuento
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la Panadería Servellon");

            Console.Write("Ingrese el total de la compra: ");
            double totalCompra = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el tipo de membresía (A, B, C): ");
            string tipoMembresia = Console.ReadLine().ToUpper();

            double descuento = ObtenerDescuento(tipoMembresia);

            double totalConDescuento = totalCompra - (totalCompra * descuento / 100);

            Console.WriteLine($"El descuento aplicado es del {descuento}%");
            Console.WriteLine($"Total a pagar: {totalConDescuento}");
        }

        static double ObtenerDescuento(string tipoMembresia)
        {
            switch (tipoMembresia)
            {
                case "A":
                    return 10.0;
                case "B":
                    return 15.0;
                case "C":
                    return 20.0;
                default:
                    Console.WriteLine("Tipo de membresía no válida. No se aplicará descuento.");
                    return 0.0;
            }
        }
    }
}