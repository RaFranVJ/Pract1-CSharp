namespace PJpracticas.Ejercicios.IntroduccionACSharp
{
/// <summary> Ejercicio #4 - Calcular el área de un triángulo. </summary>

public class AreaTriangulo
{
/// <summary> Calcula el área del tríangulo con la información introducida por el usuario. </summary>

public static void CalcularArea()
{
Console.WriteLine("====== Ejercicio #4 - Área del tríangulo ======\n");

Console.Write("Introduce el valor de la base: ");
_ = float.TryParse(Console.ReadLine(), out float b); // Leer el valor de la base y convertirlo a float

Console.Write("Introduce el valor de la altura: ");
_ = float.TryParse(Console.ReadLine(), out float h); // Leer el valor de la altura y convertirlo a float

float area = b * h / 2; // Calcular el area del triangulo (base por altura entre 2)

Program.MostrarRespuesta();

Console.WriteLine("Fórmula: A = (b x h) ÷ 2"); // Mostrar la formula utilizada
Console.WriteLine($"A = ({b:N2} x {h:N2}) ÷ 2 = {area:N2}\n"); // Mostrar procedimientos y resultado
}

}

}