namespace PJpracticas.Ejercicios.IntroduccionACSharp
{
/// <summary> Ejercicio #2 - Calcular el área de un círculo. </summary>

public static class AreaCirculo
{
/// <summary> Calcula el área del círculo con el radio introducido por el usuario. </summary>

public static void CalcularArea()
{
Console.WriteLine("====== Ejercicio #2 - Área del círculo ======\n");

Console.Write("Introduce el valor del radio: ");
_ = float.TryParse(Console.ReadLine(), out float radio); // Leer el valor del radio y convertirlo a float

double diametro = Math.Pow(radio, 2); // Calcular el diametro (radio elevado al cuadrado)
double area = float.Pi * diametro; // Hallar el area del circulo (Pi por el diametro)

Program.MostrarRespuesta();

Console.WriteLine("Fórmula: A = \u03C0 x r\u00B2"); // Mostrar la fórmula (uso "\u03C0" para el Pi y "\u00B2" como el exponente "2")
Console.WriteLine($"A = {float.Pi:N2} x {radio:N2}\u00B2 = {area:N2}\n"); // Mostrar procedimiento y resultado ("N2" = primeras dos cifras)
}

}

}