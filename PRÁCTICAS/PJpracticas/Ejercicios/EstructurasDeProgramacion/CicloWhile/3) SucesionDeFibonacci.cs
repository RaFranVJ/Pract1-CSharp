namespace PJpracticas.Ejercicios.EstructurasDeProgramacion.CicloWhile
{
/// <summary> Ejemplo #3 - Realiza la sucesión de Fibonacci (suma consecutiva de números). </summary>

public static class SucesionDeFibonacci
{
/// <summary> Suma los números usando el bucle While para validar la condición dada. </summary>

public static void MostrarSerie()
{
Console.WriteLine("====== Ejercicio #3 - Sucesión de Fibonacci ======\n");

Console.Write("¿Cuántos números deseas mostrar? ");
_ = int.TryParse(Console.ReadLine(), out int longitudSerie); // Leer la longitud de sucesión y convertirla a entero (Int32)

int a = 0, b = 1;

Console.Write($"{a}, {b}");

// Ejecutar el bucle While hasta que se alcance el limite de términos establecido

int terminosGenerados = 2;

while(terminosGenerados < longitudSerie)
{
int siguiente = a + b;
Console.Write($", {siguiente}");

a = b;
b = siguiente;

terminosGenerados++;
}

Console.WriteLine();
}

}

}