namespace PJpracticas.Ejercicios.EstructurasDeProgramacion.CicloWhile
{
/// <summary> Ejemplo #1 - Suma dos números mientras el segundo sea mayor que 0. </summary>

public static class SumaMayorQue0
{
/// <summary> Suma los números usando el bucle While para validar la condición dada. </summary>

public static void SumarValores()
{
Console.WriteLine("====== Ejercicio #1 - Suma mayor que 0 ======\n");

int a, b;

Console.Write("Introduce un número: ");
_ = int.TryParse(Console.ReadLine(), out a); // Leer el primer número y convertirlo a entero (Int32)

Console.Write("Introduce otro numero: ");

// El bucle while se repite hasta que el valor esté dentro del rango especificado

while(!int.TryParse(Console.ReadLine(), out b) || b <= 0)
{
Console.WriteLine("El segundo valor no puede ser menor o igual que 0.");
Console.Write("Vuelve a ingresar el valor: ");
}

int c = a + b; // Sumar a y b
Console.WriteLine("\n{0} + {1} = {2}", a, b, c); // Mostrar la suma y su resultado
}

}

}