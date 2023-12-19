namespace PJpracticas.Ejercicios.EstructurasDeProgramacion.CicloDoWhile
{
/// <summary> Ejemplo #5 - Tiempo de espera. </summary>

public static class TiempoDeEspera
{
/// <summary> Inicia el tiempo de esperae. </summary>

public static void Iniciar()
{
Console.WriteLine("====== Ejercicio #5 - Tiempo de espera ======\n");

int tiempo = 5;

// Primero, mostrar el tiempo restante (en segundos)

do
{
Console.Write($"\rTiempo restante: {tiempo} segundo (s).");
Thread.Sleep(1000); // Delay de 1 segundo

tiempo--;
} 

// Luego, verificar si se agotó el tiempo de espera

while(tiempo > 0);

Console.WriteLine("Se ha agotado el tiempo de espera.");
}

}

}