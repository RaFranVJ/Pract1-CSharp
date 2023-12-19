using System;
using System.Threading;

namespace PJpracticas.Ejercicios.EstructurasDeProgramacion.CicloFor
{
/// <summary> Ejemplo #4 - Simulación de un reloj. </summary>

public static class Reloj
{
/** <summary> Cuenta los segundos, los minutos y las horas. Se detiene cuando el usuario presiona una tecla. </summary>

<remarks> Al ser una simulación, el reloj no cuenta el tiempo real.<para>
</para>Este reloj cuenta más bien, el tiempo transcurrido desde que se empezó a ejecutar el programa. </remarks> */

public static void Iniciar()
{
Console.WriteLine("====== Ejercicio #4 - Reloj ======\n");

Console.WriteLine("Presiona cualquier tecla para detener el reloj.");

int posRelojArr = Console.CursorTop + 2; // Posición del cursor para mostrar el reloj en filas

// Bucle para contabilizar los segundos

for(int s = 0; s < 24; s++)
{
// Bucle para contabilizar los minutos

for(int m = 0; m < 60; m++)
{
// Bucle para contabilizar las horas

for(int h = 0; h < 60; h++)
{
Console.SetCursorPosition(0, posRelojArr); // Posicionar el cursor en la segunda línea de la consola
Console.Write($"{s} : {m} : {h}");

if(Console.KeyAvailable) // De haberse presionado una tecla, salir del programa (o sea, detener el reloj)
return;

Thread.Sleep(1000); // Delay de 1 segundo entre cada conteo
}

}

}

}

}

}