namespace PJpracticas.Ejercicios.EstructurasDeProgramacion.CicloFor
{
/// <summary> Ejemplo #3 - Mostrar tablas de multiplicación. </summary>

public static class TablaDeMultiplicar
{
/// <summary> Muestra todos los múltiplos de un factor introducido por el usuario. </summary>

public static void MostrarMultiplos()
{
Console.WriteLine("====== Ejercicio #3 - Tabla de multiplicación ======\n");

int minMultiplo = 1;
int maxMultiplo = 12;

Console.Write($"Ingresa un múltiplo entre {minMultiplo} y {maxMultiplo}: ");
Console.WriteLine();

int multiplo;

// El bucle while se repite hasta que el valor esté dentro del rango especificado

while(!int.TryParse(Console.ReadLine(), out multiplo) || multiplo < minMultiplo || multiplo > maxMultiplo)
{
Console.WriteLine("El valor está fuera del rango permitido.");
Console.WriteLine($"Rango permitido: {minMultiplo} - {maxMultiplo}");

Console.Write("Vuelve a ingresar el valor: ");
}

// Mostrar la tabla del múltiplo introducido por el usuario (mínimo, 1; máximo, 12)

for(int i = minMultiplo; i <= maxMultiplo; i++)
Console.WriteLine($"{multiplo} x {i} = {multiplo * i}");

}

}

}