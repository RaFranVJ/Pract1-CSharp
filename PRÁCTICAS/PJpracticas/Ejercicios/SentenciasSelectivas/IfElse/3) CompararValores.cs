namespace PJpracticas.Ejercicios.SentenciasSelectivas.IfElse
{
/// <summary> Ejemplo #3 - Verifica si dos valores son menores, mayores o iguales. </summary>

public static class CompararValores
{
/// <summary> Usa la sentencia if-else para comparar los valores. </summary>

public static void HacerComparacion()
{
Console.WriteLine("====== Ejercicio #3 - Comparar valores ======\n");

Console.Write("Ingresa un valor para X: ");
_ = int.TryParse(Console.ReadLine(), out int X);

Console.Write("Ingresa un valor para Y: ");
_ = int.TryParse(Console.ReadLine(), out int Y);

Console.WriteLine();

// Condición 1: si X es menor que Y, mostrarlo en pantalla

if(X < Y)
{
Console.WriteLine("X es menor que Y:");
Console.WriteLine($"{X} < {Y}");
}

// Condición 2: de lo contrario, si X es mayor que Y, mostrarlo en pantalla

if(X > Y)
{
Console.WriteLine("X es mayor que Y:");
Console.WriteLine($"{X} > {Y}");
}

// Condición 3: de lo contrario, ambos valores son iguales

else
{
Console.WriteLine("Ambos valores son iguales:");
Console.WriteLine($"{X} = {Y}");
}

}

}

}