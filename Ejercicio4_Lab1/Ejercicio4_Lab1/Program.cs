
using Microsoft.VisualBasic;

namespace Ejercicio4_Lab1
{
    class Empleado
    {
        //Desarrolle un programa que utilice una instrucción while para determinar
//el sueldo bruto para cada uno de varios empleados.La empresa paga la
//“cuota normal” en las primeras 40 horas de trabajo de cada empleado, y
//paga “cuota y media” en todas las horas trabajadas que excedan de 40.
//Usted recibe una lista de los empleados de la empresa, el número de
//horas que trabajó cada empleado la semana pasada y la tarifa por horas
//de cada empleado.Su programa debe recibir como entrada esta
//información para cada empleado, debe determinar y mostrar el sueldo
//bruto de cada empleado. 
        public string Nombre { get; set; }
        public double HorasTrabajadas { get; set; }
        public double TarifaPorHora { get; set; }

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
            foreach (var empleado in empleados)
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