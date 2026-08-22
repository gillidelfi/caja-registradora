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
    Console.WriteLine(" 2- Cerrar la venta");
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
            Console.WriteLine("Cerrar la venta: ");
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


// --- Etapa 5: medio de pago ---
const decimal DescuentoEfectivo = 0.10m;
const decimal RecargoCredito = 0.15m;

int opcionPago;
bool opcionValida;

do
{
    Console.WriteLine("Medio de pago: ");
    Console.WriteLine("1 - Efectivo");
    Console.WriteLine("2 - Débito");
    Console.WriteLine("3 - Crédito ");
    Console.Write(" Opción: ");
    opcionPago = int.Parse(Console.ReadLine());

    opcionValida = opcionPago == 1 || opcionPago == 2 || opcionPago == 3;
    if (!opcionValida)
    {
        Console.WriteLine("Opción inválida. Intente de nuevo.");

    }
} 
while (!opcionValida);

decimal totalFinal = totalConDescuento;
decimal descuentoMedioPago = 0m;
decimal recargoMedioPago = 0m;
string nombreMedioPago = "";

switch (opcionPago)
{
    case 1: 
        descuentoMedioPago = totalConDescuento * DescuentoEfectivo;
        totalFinal = totalConDescuento - descuentoMedioPago;
        nombreMedioPago = "efectivo";
        break;
    case 2:
        totalFinal = totalConDescuento;
        nombreMedioPago = "débito";
        break;
    case 3:
        recargoMedioPago = totalConDescuento * RecargoCredito;
        totalFinal = totalConDescuento + recargoMedioPago;
        nombreMedioPago = "crédito";
        break;
}
// --- Etapa 6: ticket final ---

decimal descuentoTotal = descuento + descuentoMedioPago;

Console.WriteLine();
for (int i = 0; i < 30; i++)
{
    Console.Write("-");
}
Console.WriteLine();

Console.WriteLine($"       {NombreComercio}");

for (int i = 0; i < 30; i++)
{
    Console.Write("-");
}

Console.WriteLine();
Console.WriteLine($"Cajero: {nombreCajero}");
Console.WriteLine($"Productos: {cantidadProductos}");
Console.WriteLine($"Subtotal: {subtotal}");
Console.WriteLine($"Descuento: {descuentoTotal}");
Console.WriteLine($"Recargo {recargoMedioPago}");

for (int i = 0; i < 30; i++)
{
    Console.Write("-");
}
Console.WriteLine();

Console.WriteLine($"TOTAL: {totalFinal}");

for (int i = 0; i < 30; i++)
{
    Console.Write("-");
}
Console.WriteLine();

Console.ReadLine();




