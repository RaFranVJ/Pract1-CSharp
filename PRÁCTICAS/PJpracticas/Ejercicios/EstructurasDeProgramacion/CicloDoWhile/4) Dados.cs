namespace PJpracticas.Ejercicios.EstructurasDeProgramacion.CicloDoWhile
{
/// <summary> Ejemplo #4 - Simulación de un dado. </summary>

public static class Dados
{
/// <summary> Lanza dos dados hasta que se obtenga un doble. </summary>

public static void Lanzar()
{
Console.WriteLine("====== Ejercicio #4 - Dados ======\n");

Random azar = new(); // Aleatoridad
int dado1, dado2;

// Primero, lanzar los dados y mostrar el valor obtenido

do
{
dado1 = azar.Next(1, 7);
dado2 = azar.Next(1, 7);

Console.WriteLine($"[{dado1}] [{dado2}]");
} 

// Luego, verificar si ambos dados son idénticos (osea, si se obtuvo un doble)

while(dado1 != dado2);

Console.WriteLine("¡Obtuviste un doble! Fin del juego.");
}

}

}