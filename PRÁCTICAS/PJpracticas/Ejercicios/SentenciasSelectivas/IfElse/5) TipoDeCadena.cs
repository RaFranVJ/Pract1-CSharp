namespace PJpracticas.Ejercicios.SentenciasSelectivas.IfElse
{
/// <summary> Ejemplo #5 - Verifica el tipo de cadena introducida por el usuario. </summary>

public static class TipoDeCadena
{
/// <summary> Usa la sentencia if-else para determinar la paridad de un número. </summary>

public static void Verificar()
{
Console.WriteLine("====== Ejercicio #5 - Tipo de cadena ======\n");

Console.Write("Ingresa una cadena de texto: ");
string? cadena = Console.ReadLine();

// Bucle while para obtener la cadena de manera segura (sin errores por ser null o estar vacía)

while(string.IsNullOrEmpty(cadena) )
{
Console.WriteLine("La cadena no puede estar vacía: ");
cadena = Console.ReadLine();
}

// Condición 1: si la cadena solo tiene un caracter, entonces es una letra

if(cadena.Length == 1)
Console.WriteLine($"\"{cadena}\" es una letra.");

// Condición 2: de lo contrario, la cadena es una sílaba, una palabra o una oración

else
Console.WriteLine("La cadena puede ser una sílaba, una palabra, o incluso, una oración.");

}

}

}