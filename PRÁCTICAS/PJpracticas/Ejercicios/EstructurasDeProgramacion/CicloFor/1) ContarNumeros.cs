namespace PJpracticas.Ejercicios.EstructurasDeProgramacion.CicloFor
{
/// <summary> Ejemplo #1 - Cuenta los números hasta el valor introducido por el usuario. </summary>

public static class ContarNumeros
{
/// <summary> Inicia un conteo usando el bucle For. </summary>

public static void IniciarConteo()
{
Console.WriteLine("====== Ejercicio #1 - Contar números ======\n");

int rangoMin = 3;
int rangoMax = 10;

Console.Write($"Ingresa un número entre {rangoMin} y {rangoMax}: ");
int contarHasta;

// El bucle while se repite hasta que el valor esté dentro del rango especificado

while(!int.TryParse(Console.ReadLine(), out contarHasta) || contarHasta < rangoMin || contarHasta > rangoMax)
{
Console.WriteLine("El valor está fuera del rango permitido.");
Console.WriteLine($"Rango permitido: {rangoMin} - {rangoMax}");

Console.Write("Vuelve a ingresar el valor: ");
}

// Iterar las veces definidas por el usuario e imprimir los números

for(int i = 0; i <= contarHasta; i++)
Console.Write(i + " "); // Imprimir el número actual (i)

Console.WriteLine();
}

}

}