namespace PJpracticas.Ejercicios.IntroduccionACSharp
{
/// <summary> Ejercicio #5 - Simular la factura de un producto. </summary>

public class FacturaProducto
{
/// <summary> Simula la factura de un producto con la información introducida por el usuario. </summary>

public static void GenerarFactura()
{
Console.WriteLine("====== Ejercicio #5 - Factura de un producto ======\n");

Console.Write("Introduce el código del artículo que compraste: ");
string? codigoProducto = Console.ReadLine(); // Leer el codigo del producto

Console.Write("Ahora, introduce el nombre del artículo: ");
string? nombreProducto = Console.ReadLine(); // Leer el nombre del producto

Console.Write("\nSiendo honesto, introduce el precio del producto: ");
_ = float.TryParse(Console.ReadLine(), out float precioProducto); // Leer el precio del producto y convertirlo a float

Console.Write($"Bien, ahora dinos, ¿cuántos {nombreProducto} (s) compraste? ");
_ = int.TryParse(Console.ReadLine(), out int cantidadProducto ); // Leer la cantidad de producto (s) y pasarlo a float

Console.WriteLine("\nGenerando factura...");

float subTotal = cantidadProducto * precioProducto; // Calcular el sub-Total
double itebis = 0.18 * subTotal; // Agregar ITEBIS al sub-Total
double descuento = itebis - (itebis * 0.15); // Simular un descuento de un 15%
double totalCompra = itebis - descuento; // Finalmente, calcular el total de la compra + el descuento

Console.Write("¡Factura lista! Presiona una tecla para verla.");
Console.ReadKey();

Console.Clear();

// Mostrar la factura después de que el usuario presione una tecla cualquiera:

Console.WriteLine("============ SU FACTURA ============\n");

Console.WriteLine($"Código del producto: {codigoProducto}");
Console.WriteLine($"Nombre del producto: {nombreProducto}");
Console.WriteLine($"Precio del producto: {precioProducto}");
Console.WriteLine($"Cantidad comprada: {cantidadProducto}");
Console.WriteLine($"Sub-total de la compra: {subTotal}");
Console.WriteLine($"ITEBIS: {itebis}");
Console.WriteLine($"Descuento: {descuento}");
Console.WriteLine($"Total a pagar: {totalCompra}");
}

}

}