namespace PJpracticas.Ejercicios.EstructurasDeProgramacion.CicloWhile
{
/// <summary> Ejemplo #4 - Adivinar un número aleatorio del 1 al 100. </summary>

public static class AdivinarNumero
{
/// <summary> Empieza con la adivinanza. </summary>

public static void Empieza()
{
Console.WriteLine("====== Ejercicio #4 - Adivina un número ======\n");

Random azar = new(); // La clase Random sirve para generar resultados al azar
int numAleatorio = azar.Next(1, 101); // Generar un número aleatorio entre 1 y 100

int numIntentos = 1;
int numUsuario;

Console.Write("Adivina el número entre 1 y 100: ");

// El bucle While se repite hasta que el usuario adivine el número

while( (numUsuario = Convert.ToInt32(Console.ReadLine() ) ) != numAleatorio)
{

if(numUsuario < numAleatorio)
Console.Write("Demasiado bajo. Intenta de nuevo: ");

else
Console.Write("Demasiado alto. Prueba otra vez: ");
    
numIntentos++;
}

Console.WriteLine($"¡Has acertado! Eso te tomó {numIntentos} intento (s).");
}

}

}