
namespace SueldoEmpleados
{
    class Empleado
    {
        public string Nombre{ get; set; }
        public double HorasTrabajadas{ get; set; }
        public double TarifaPorHora{ get; set; }

            public Empleado(string nombre, double horasTrabajadas, double tarifaPorHora)
        {
            Nombre = nombre;
            HorasTrabajadas = horasTrabajadas;
            TarifaPorHora = tarifaPorHora;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> empleados = new List<Empleado>();
            string continuar;

            do
            {
                Console.Write("Ingrese el nombre del empleado: ");
                string nombre = Console.ReadLine();

                Console.Write("Ingrese las horas trabajadas: ");
                double horasTrabajadas = double.Parse(Console.ReadLine());

                Console.Write("Ingrese la tarifa por hora: ");
                double tarifaPorHora = double.Parse(Console.ReadLine());

                empleados.Add(new Empleado(nombre, horasTrabajadas, tarifaPorHora));

                Console.Write("¿Desea ingresar otro empleado? (s/n): ");
                continuar = Console.ReadLine().ToLower();
            } while (continuar == "s");

            Console.WriteLine("\nSueldo Bruto de los Empleados:");
            foreach(var empleado in empleados)
            {
                double sueldoBruto = CalcularSueldoBruto(empleado.HorasTrabajadas, empleado.TarifaPorHora);
                Console.WriteLine($"{empleado.Nombre}: {sueldoBruto:C2}");
            }
        }

        static double CalcularSueldoBruto(double horasTrabajadas, double tarifaPorHora)
        {
            double sueldoBruto;
            if (horasTrabajadas <= 40)
            {
                sueldoBruto = horasTrabajadas * tarifaPorHora;
            }
            else
            {
                double horasExtras = horasTrabajadas - 40;
                sueldoBruto = (40 * tarifaPorHora) + (horasExtras * tarifaPorHora * 1.5);
            }
            return sueldoBruto;
        }
    }
}
