namespace PJpracticas.Ejercicios.EstructurasDeProgramacion.CicloDoWhile
{
/// <summary> Ejemplo #1 - Filtra un número positivo introducido por el usuario. </summary>

public static class FiltrarNumeroPositivo
{
/// <summary> Usa el bucle do-While para filtrar el valor ingresado por el usuario. </summary>

public static void FiltrarValor()
{
Console.WriteLine("====== Ejercicio #1 - Filtrar número positivo ======\n");

int numero;

// Primero, obtener un número por el teclado

do
Console.Write("Introduce un número que sea mayor que 0: ");

// Luego, verificar si el número es negativo/menor que 0

while(!int.TryParse(Console.ReadLine(), out numero) || numero <= 0);

Console.WriteLine($"El número que seleccionaste: {numero}");
}

}

}