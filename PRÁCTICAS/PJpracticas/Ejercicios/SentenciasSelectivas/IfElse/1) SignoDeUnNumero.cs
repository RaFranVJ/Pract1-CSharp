namespace PJpracticas.Ejercicios.SentenciasSelectivas.IfElse
{
/// <summary> Ejemplo #1 - Determina si un número es positivo o negativo. </summary>

public static class SignoDeUnNumero
{
/// <summary> Usa la sentencia if-else para determinar el signo de un número. </summary>

public static void VerificarSigno()
{
Console.WriteLine("====== Ejercicio #1 - Signo de un número ======\n");

Console.Write("Introduce un número: ");
_ = int.TryParse(Console.ReadLine(), out int numero);

// Condición 1: si el número es menor que 0, entonces es negativo

if(numero < 0)
Console.WriteLine("El número es negativo.");

// Condición 2: de lo contrario, si el número equivale a 0, mostrar un aviso en pantalla

else if(numero == 0)
Console.WriteLine("El número es 0.");

// Condición 3: de lo contrario, el número es positivo (ni es menor que 0, ni es 0)
else
Console.WriteLine("El número es positivo.");

}

}

}