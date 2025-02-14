using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_EJ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Desarrolle una aplicación que determine si alguno de los clientes de una 
            //tienda de departamentos se ha excedido del límite de crédito en una
            //cuenta.Para cada cliente se tienen los siguientes datos: 
            //a) Número de cuenta(un entero)
            //b) Saldo al inicio del mes
            //c) Total de todos los artículos cargados por el cliente en el mes
            //d) Total de todos los créditos aplicados a la cuenta del cliente en el mes
            //e) Límite de crédito permitido. 
            //El programa debe usar una instrucción while para recibir como entrada
            //cada uno de estos datos, debe calcular
            //el nuevo saldo(= saldo inicial + cargos – créditos) y determinar si éste
            //excede el límite de crédito del cliente.
            // Paralos clientes cuyo límite de crédito se ha excedido, el programa debe
            //mostrar el número de cuenta del cliente, su límite crédito, el nuevo saldo y el mensaje “Se excedió el límite de su crédito”.

            uint numeroCuenta;
            double saldoCuenta, limiteCredito = 0, saldoInicioMes = 0, articulosCargos = 0, creditoAplicado,nuevoSaldo = 0;

            while (true)
            {
                Console.WriteLine("Ingrese el numero de cuenta");
                numeroCuenta = uint.Parse(Console.ReadLine());
                if (numeroCuenta <0) 
                {
                    break;
                }
                Console.WriteLine("Ingrese el saldo del inicial del mes");
                saldoCuenta = uint.Parse(Console.ReadLine());   
                Console.WriteLine("Ingrese el total de articulos  cargados por el cliente del mes");
                articulosCargos = double.Parse(Console.ReadLine()); 
                Console.WriteLine("Ingrese el creditos aplicados a la cuenta del cliente del mes");
                    creditoAplicado= double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el total de saldos aplicados");
               saldoInicioMes= double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese  el saldo el limite del credito ");
                limiteCredito= double.Parse(Console.ReadLine());
                nuevoSaldo = saldoInicioMes + articulosCargos - creditoAplicado;

                
                if (nuevoSaldo > limiteCredito)
                {
                   
                    Console.WriteLine($"Numero de cuenta: {numeroCuenta}");
                    Console.WriteLine($"Limite de crédito: {limiteCredito}");                   
                    Console.WriteLine($"El numero de cuenta del cliente es {numeroCuenta} su limite de credito es L. {limiteCredito} su nuevo saldo L. {nuevoSaldo} Se excedió el limite de tu saldo.");
                }
                else
                {
                    
                    Console.WriteLine("El cliente no se ha excedido del límite de crédito.");
                }

                // Espacio para el siguiente cliente
                Console.WriteLine("\n-----------------------------------\n");
            }
        }
    }
} 
