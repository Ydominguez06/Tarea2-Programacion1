
public class Boleto
{
    public int IdBoleto { get; set; }
    public string Pasajero { get; set; }
    public string Destino { get; set; }
    public DateTime Fecha { get; set; }
    public string Asiento { get; set; }
    public decimal Precio { get; set; }
    public string Clase { get; set; }
    public string NumeroVuelo { get; set; } 

    public Boleto(int idBoleto, string pasajero, string destino, DateTime fecha, string asiento, decimal precio, string clase, string numeroVuelo)
    {
        IdBoleto = idBoleto;
        Pasajero = pasajero;
        Destino = destino;
        Fecha = fecha;
        Asiento = asiento;
        Precio = precio;
        Clase = clase;
        NumeroVuelo = numeroVuelo;
    }

    public override string ToString()
    {
        return $"ID: {IdBoleto}, Pasajero: {Pasajero}, Destino: {Destino}, Fecha: {Fecha}, Asiento: {Asiento}, Precio: {Precio}, Clase: {Clase}, Vuelo: {NumeroVuelo}";
    }
}

public class Avion
{
    public int IdAvion { get; set; }
    public string Modelo { get; set; }
    public int CapacidadPasajeros { get; set; }
    public string Marca { get; set; }
    public string NumeroVuelo { get; set; }
    public string Piloto { get; set; }
    public string Estado { get; set; }

    public Avion(int idAvion, string modelo, int capacidadPasajeros, string marca, string numeroVuelo, string piloto, string estado)
    {
        IdAvion = idAvion;
        Modelo = modelo;
        CapacidadPasajeros = capacidadPasajeros;
        Marca = marca;
        NumeroVuelo = numeroVuelo;
        Piloto = piloto;
        Estado = estado;
    }

    public override string ToString()
    {
        return $"ID: {IdAvion}, Modelo: {Modelo}, Capacidad: {CapacidadPasajeros}, Marca: {Marca}, Vuelo: {NumeroVuelo}, Piloto: {Piloto}, Estado: {Estado}";
    }
}

public class Factura
{
    public int IdFactura { get; set; }
    public string Cliente { get; set; }
    public DateTime FechaEmision { get; set; }
    public decimal Total { get; set; }
    public List<Boleto> Detalles { get; set; } 
    public string MetodoPago { get; set; }
    public string NumeroReferencia { get; set; }

    public Factura(int idFactura, string cliente, DateTime fechaEmision, string metodoPago, string numeroReferencia)
    {
        IdFactura = idFactura;
        Cliente = cliente;
        FechaEmision = fechaEmision;
        Total = 0; 
        Detalles = new List<Boleto>();
        MetodoPago = metodoPago;
        NumeroReferencia = numeroReferencia;
    }

    public void AgregarDetalle(Boleto boleto)
    {
        Detalles.Add(boleto);
        Total += boleto.Precio;
    }

    public override string ToString()
    {
        string detalles = "";
        foreach (var boleto in Detalles)
        {
            detalles += boleto.ToString() + "\n";
        }
        return $"ID: {IdFactura}, Cliente: {Cliente}, Fecha: {FechaEmision}, Total: {Total:C}, Detalles:\n{detalles}, Método de pago: {MetodoPago}, Número de referencia: {NumeroReferencia}";
    }
}

public class Aerolinea
{
    private List<Boleto> boletos = new List<Boleto>();
    private List<Avion> aviones = new List<Avion>();
    private List<Factura> facturas = new List<Factura>();

    public static void Main(string[] args)
    {
        Aerolinea aerolinea = new Aerolinea();
        int opcion;

        do
        {
            aerolinea.MostrarMenu();
            opcion = aerolinea.ObtenerOpcion();
            aerolinea.ProcesarOpcion(opcion);
        } while (opcion != 0);
    }

    public void MostrarMenu()
    {
        Console.WriteLine("\nMenú de Aerolínea:");
        Console.WriteLine("1. Agregar Boleto");
        Console.WriteLine("2. Visualizar Boletos");
        Console.WriteLine("3. Imprimir Posición de Boleto");
        Console.WriteLine("4. Agregar Avión");
        Console.WriteLine("5. Visualizar Aviones");
        Console.WriteLine("6. Imprimir Posición de Avión");
        Console.WriteLine("7. Agregar Factura");
        Console.WriteLine("8. Visualizar Facturas");
        Console.WriteLine("9. Imprimir Posición de Factura");
        Console.WriteLine("10. Buscar Boletos por Destino"); 
        Console.WriteLine("11. Generar Reporte de Ingresos por Vuelo"); 
        Console.WriteLine("0. Salir");
    }

    public int ObtenerOpcion()
    {
        Console.Write("Ingrese una opción: ");
        string input = Console.ReadLine();
        int opcion;
        if (int.TryParse(input, out opcion))
        {
            return opcion;
        }
        else
        {
            Console.WriteLine("Opción inválida. Intente de nuevo.");
            return -1; 
        }
    }

    public void ProcesarOpcion(int opcion)
    {
        switch (opcion)
        {
            case 1:
                AgregarBoleto();
                break;
            case 2:
                VisualizarBoletos();
                break;
            case 3:
                ImprimirPosicionBoleto();
                break;
            case 4:
                AgregarAvion();
                break;
            case 5:
                VisualizarAviones();
                break;
            case 6:
                ImprimirPosicionAvion();
                break;
            case 7:
                AgregarFactura();
                break;
            case 8:
                VisualizarFacturas();
                break;
            case 9:
                ImprimirPosicionFactura();
                break;
            case 10:
                break;
            case 0:
                Console.WriteLine("Saliendo del programa.");
                break;
            default:
                Console.WriteLine("Opción inválida.");
                break;
        }
    }

  
    public void AgregarBoleto()
    {
        Console.WriteLine("\nAgregar Boleto:");
        Console.Write("ID: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Pasajero: ");
        string pasajero = Console.ReadLine();
        Console.Write("Destino: ");
        string destino = Console.ReadLine();
        Console.Write("Fecha (yyyy-MM-dd): ");
        DateTime fecha = DateTime.Parse(Console.ReadLine());
        Console.Write("Asiento: ");
        string asiento = Console.ReadLine();
        Console.Write("Precio: ");
        decimal precio = decimal.Parse(Console.ReadLine());
        Console.Write("Clase: ");
        string clase = Console.ReadLine();
        Console.Write("Número de vuelo: ");
        string numeroVuelo = Console.ReadLine();

        Boleto boleto = new Boleto(id, pasajero, destino, fecha, asiento, precio, clase, numeroVuelo);
        boletos.Add(boleto);
        Console.WriteLine("Boleto agregado.");
    }

    public object VisualizarBoletos()
    {
        Console.WriteLine("\nBoletos:");
        if (boletos.Count == 0)
        {
            Console.WriteLine("No hay boletos registrados."); 
            return null; 
        }
        foreach (var boleto in boletos)
        {
            Console.WriteLine(boleto);
        }
        return null; 
    }
                 public void ImprimirPosicionBoleto()
    {
        Console.WriteLine("\nImprimir Boleto por Posición:");
        if (boletos.Count == 0)
        {
            Console.WriteLine("No hay boletos registrados.");
            return;
        }

        Console.Write("Ingrese la posición del boleto a imprimir (0-" + (boletos.Count - 1) + "): ");
        if (int.TryParse(Console.ReadLine(), out int posicion) && posicion >= 0 && posicion < boletos.Count)
        {
            Console.WriteLine(boletos[posicion]);
        }
        else
        {
            Console.WriteLine("Posición inválida.");
        }
    }

    public void AgregarAvion()
    {
        Console.WriteLine("\nAgregar Avión:");
        Console.Write("ID: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Modelo: ");
        string modelo = Console.ReadLine();
        Console.Write("Capacidad: ");
        int capacidad = int.Parse(Console.ReadLine());
        Console.Write("Marca: ");
        string marca = Console.ReadLine();
        Console.Write("Número de Vuelo: ");
        string numeroVuelo = Console.ReadLine();
        Console.Write("Piloto: ");
        string piloto = Console.ReadLine();
        Console.Write("Estado: ");
        string estado = Console.ReadLine();

        Avion avion = new Avion(id, modelo, capacidad, marca, numeroVuelo, piloto, estado);
        aviones.Add(avion);
        Console.WriteLine("Avión agregado.");
    }

    public void VisualizarAviones()
    {
        Console.WriteLine("\nAviones:");
        if (aviones.Count == 0)
        {
            Console.WriteLine("No hay aviones registrados.");
            return;
        }
        foreach (var avion in aviones)
        {
            Console.WriteLine(avion);
        }
    }

    public void ImprimirPosicionAvion()
    {
        Console.WriteLine("\nImprimir Avión por Posición:");
        if (aviones.Count == 0)
        {
            Console.WriteLine("No hay aviones registrados.");
            return;
        }

        Console.Write("Ingrese la posición del avión a imprimir (0-" + (aviones.Count - 1) + "): ");
        if (int.TryParse(Console.ReadLine(), out int posicion) && posicion >= 0 && posicion < aviones.Count)
        {
            Console.WriteLine(aviones[posicion]);
        }
        else
        {
            Console.WriteLine("Posición inválida.");
        }
    }


    public void AgregarFactura()
    {
        Console.WriteLine("\nAgregar Factura:");
        Console.Write("ID: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Cliente: ");
        string cliente = Console.ReadLine();
        Console.Write("Fecha (yyyy-MM-dd): ");
        DateTime fecha = DateTime.Parse(Console.ReadLine());
        Console.Write("Método de Pago: ");
        string metodoPago = Console.ReadLine();
        Console.Write("Número de Referencia: ");
        string referencia = Console.ReadLine();

        Factura factura = new Factura(id, cliente, fecha, metodoPago, referencia);

        Console.WriteLine("Ingrese los IDs de los boletos a agregar a la factura (separados por comas):");
        string[] boletoIds = Console.ReadLine().Split(',');
        foreach (string boletoId in boletoIds)
        {
            if (int.TryParse(boletoId.Trim(), out int idBoleto))
            {
                Boleto boletoEncontrado = boletos.Find(b => b.IdBoleto == idBoleto);
                if (boletoEncontrado != null)
                {
                    factura.AgregarDetalle(boletoEncontrado);
                }
                else
                {
                    Console.WriteLine($"No se encontró el boleto con ID {idBoleto}.");
                }
            }
        }

        facturas.Add(factura);
        Console.WriteLine("Factura agregada.");
    }

    public void VisualizarFacturas()
    {
        Console.WriteLine("\nFacturas:");
        if (facturas.Count == 0)
        {
            Console.WriteLine("No hay facturas registradas.");
            return;
        }
        foreach (var factura in facturas)
        {
            Console.WriteLine(factura);
        }
    }

    public void ImprimirPosicionFactura()
    {
        Console.WriteLine("\nImprimir Factura por Posición:");
        if (facturas.Count == 0)
        {
            Console.WriteLine("No hay facturas registradas.");
            return;
        }

        Console.Write("Ingrese la posición de la factura a imprimir (0-" + (facturas.Count - 1) + "): ");
        if (int.TryParse(Console.ReadLine(), out int posicion) && posicion >= 0 && posicion < facturas.Count)
        {
            Console.WriteLine(facturas[posicion]);
        }
        else
        {
            Console.WriteLine("Posición inválida.");
        }
    }

}
    