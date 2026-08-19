const string NombreComercio = "CITYMARKET";
Console.WriteLine($"=== {NombreComercio}===");
Console.Write("Nombre del cajero: ");
string  nombreCajero = Console.ReadLine();
Console.WriteLine($"Bienvenida, {nombreCajero}. Caja abierta.");

// --- Etapa 2: carga de producto ---
Console.Write("Nombre del producto: ");
string nombreProducto = Console.ReadLine();

Console.Write("Precio: ");
decimal precio = decimal.Parse(Console.ReadLine());

Console.WriteLine($"Producto cargado: {nombreProducto} - ${precio}");