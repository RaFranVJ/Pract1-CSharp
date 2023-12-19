namespace PJpracticas.Ejercicios.EstructurasDeProgramacion.CicloDoWhile
{
/// <summary> Ejemplo #2 - Verifica si una clave introducida por el usuario es la correcta. </summary>

public static class ClaveSecreta
{
/// <summary> Valida la clave introducida por el usuario. </summary>

public static void ValidarClave()
{
Console.WriteLine("====== Ejercicio #2 - Clave secreta ======\n");

string claveEsperada = "MiClave123"; // Clave genérica, no usar para cifrar información
string? claveIngresada;

// Primero, leer la clave introdcida por el usuario

do
{
Console.Write("Ingresa la clave secreta: ");
claveIngresada = Console.ReadLine();
} 

// Luego, verificar si hay discrepancia en ambas claves

while(claveIngresada != claveEsperada);

Console.WriteLine("¡La clave es correcta! Acceso concedido.");
Console.ReadLine();
}

}

}