const string NombreComercio = "CITYMARKET";
Console.WriteLine($"=== {NombreComercio}===");
Console.Write("Nombre del cajero: ");
string  nombreCajero = Console.ReadLine();
Console.WriteLine($"Bienvenida, {nombreCajero}. Caja abierta.");



// --- Etapa 3: carga de varios productos ---
decimal total = 0;
int cantidadProductos = 0;
int opcion;

do
{
    Console.WriteLine("¿Qué desea hacer?");
    Console.WriteLine(" 1- Cargar un producto");
    Console.WriteLine(" 2- Cerra la venta");
    Console.Write(" Opción: ");
    opcion = int.Parse(Console.ReadLine());
    
    switch (opcion)
    {
        case 1:
            // --- Etapa 2: carga de un producto ---
            Console.Write("Nombre del producto: ");
            string nombreProducto = Console.ReadLine();

            Console.Write("Precio: ");
            decimal precio = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Producto cargado: {nombreProducto} - ${precio}");
            
            total += precio;
            cantidadProductos++;
            break;
        
        case 2:
            Console.WriteLine("Cerra la venta: ");
            break;
        
        default:
            Console.WriteLine("Opción inválida. Intente de nuevo.");
            break;
    }

    
} while (opcion != 2);
Console.WriteLine();
Console.WriteLine($"Cantidad de productos: {cantidadProductos}");
Console.WriteLine($"Total: ${total}");



