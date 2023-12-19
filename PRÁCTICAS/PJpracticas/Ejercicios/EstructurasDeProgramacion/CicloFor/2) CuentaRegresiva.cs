namespace PJpracticas.Ejercicios.EstructurasDeProgramacion.CicloFor
{
/// <summary> Ejemplo #1 - Mostrar cuenta regresiva del 5 al 1. </summary>

public static class CuentaRegresiva
{
/// <summary> Inicia una cuenta regresiva usando el bucle For. </summary>

public static void IniciarConteo()
{
Console.WriteLine("====== Ejercicio #1 - Cuenta regresiva del 5 al 1 ======\n");

// Iterar 5 veces usando el operador de decremento (i--) para la cuenta regresiva

for(int i = 5; i >= 1; i--)
Console.Write(i + " "); // Imprimir el número actual (i)

Console.WriteLine();
}

}

}