namespace PJpracticas.Ejercicios.SentenciasSelectivas.IfElse
{
/// <summary> Ejemplo #2 - Verifica si un número es par o impar. </summary>

public static class NumeroParOImpar
{
/// <summary> Usa la sentencia if-else para determinar la paridad de un número. </summary>

public static void VerificarParidad()
{
Console.WriteLine("====== Ejercicio #2 - Número par o impar ======\n");

Console.Write("Introduce un número: ");
_ = int.TryParse(Console.ReadLine(), out int numero);

// Condición 1: si el residuo de la división entre 2 da 0, entonces el número es par

if(numero % 2 == 0)
Console.WriteLine("El número es par.");

// Condición 2: de lo contrario, el número es impar

else
Console.WriteLine("El número es impar.");

}

}

}