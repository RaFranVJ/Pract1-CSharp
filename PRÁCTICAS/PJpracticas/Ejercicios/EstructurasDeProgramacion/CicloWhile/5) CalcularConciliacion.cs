namespace PJpracticas.Ejercicios.EstructurasDeProgramacion.CicloWhile
{
/// <summary> Ejemplo #5 - Calcular la conciliación de un nuevo balance. </summary>

public static class CalcularConciliacion
{
/// <summary> Calcula la conciliación de un balance y un pago hasta que se recibe 0. </summary>

public static void HacerCalculos()
{
Console.WriteLine("====== Ejercicio #5 - Calcular conciliación ======\n");

float balance, pagoRealizado, diferencia;
string? codigoCliente, nombreCliente, apellidoCliente;

Console.WriteLine("<------------- INFORMACIÓN DEL CLIENTE ------------->\n");

codigoCliente = string.Empty;

// Bucle while para verificar si el codigo introducido es "0"

while(codigoCliente != "0")
{
Console.Write("Ingresa el código del cliente, o bien, '0' para salir: ");
codigoCliente = Console.ReadLine(); // Leer el código del cliente

Console.Write("Introduce el nombre del cliente: ");
nombreCliente = Console.ReadLine(); // Leer el nombre del cliente

Console.Write("Introduce el apellido del cliente: ");
apellidoCliente = Console.ReadLine(); // Leer el apellido del cliente

Console.Write("Ingresa el balance actual: ");
_ = float.TryParse(Console.ReadLine(), out balance); // Leer el balance actual y pasarlo a float

Console.Write("Ingresa el pago a realizar: ");
_ = float.TryParse(Console.ReadLine(), out pagoRealizado); // Leer el pago realizado y pasarlo a float

diferencia = balance - pagoRealizado; // Calcular la diferencia entre el balance actual y el pago realizado

// Una vez el usuario introduce la información del cliente, mostrar los datos correspondientes:

Console.Clear();

Console.WriteLine($"<------------- CONCILIACIÓN - {codigoCliente} ------------->\n");

Console.WriteLine($"Código del cliente: {codigoCliente}");
Console.WriteLine($"Nombre del cliente: {nombreCliente} {apellidoCliente}");
Console.WriteLine($"Pago realizado: {pagoRealizado:N1} DOP");
Console.WriteLine($"Balance antes del pago: {balance:N1} DOP");
Console.WriteLine($"Balance después del pago: {diferencia:N1} DOP");
}

}

}

}