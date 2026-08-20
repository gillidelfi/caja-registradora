const string NombreComercio = "CITYMARKET";
Console.WriteLine($"=== {NombreComercio}===");
Console.Write("Nombre del cajero: ");
string  nombreCajero = Console.ReadLine();
Console.WriteLine($"Bienvenida, {nombreCajero}. Caja abierta.");

const decimal DescuentoAlto = 0.10m;  
const decimal DescuentoMedio = 0.05m;

// --- Etapa 3: carga de varios productos ---
decimal subtotal = 0;
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
            
            subtotal += precio;
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

// --- Etapa 4: descuento según el total ---
decimal porcentajeDescuento;

if (subtotal > 50000)
{
    porcentajeDescuento = DescuentoAlto;
}
else if (subtotal > 20000)
{
    porcentajeDescuento = DescuentoMedio;
}
else
{
    porcentajeDescuento = 0m;
}

decimal descuento = subtotal * porcentajeDescuento;
decimal totalConDescuento = subtotal - descuento;

Console.WriteLine();
Console.WriteLine($"Cantidad de productos: {cantidadProductos}");
Console.WriteLine($"Subtotal: ${subtotal}");
Console.WriteLine($"Descuento aplicado: ${descuento}");
Console.WriteLine($"Total: ${totalConDescuento}");



