namespace PJpracticas.Ejercicios.IntroduccionACSharp
{
/// <summary> Ejercicio #3 - Convertir de centímetros a metros. </summary>

public class ConvertirCentimetrosAMetros
{
/// <summary> Constante para convertir de metros a centímetros y viceversa. </summary>
protected const ushort metrosEnCm = 100;

/// <summary> El símbolo usado para representar los metros. </summary>
protected static readonly char simbolo_Metros = 'm';

/// <summary> El símbolo usado para representar los centímetros. </summary>
protected static readonly string simbolo_Centimetros = "cm";

/// <summary> Convierte la cantidad de centímetros introducida por el usuario a metros. </summary>

public static void ConvertirMts()
{
Console.WriteLine("====== Ejercicio #3 - Convertir de centímetros a metros ======\n");

Console.Write("Introduce la cantidad de centímetros: ");
_ = float.TryParse(Console.ReadLine(), out float cantidadCm); // Leer la cantidad de cm y convertirla a float

float cantidadMts = cantidadCm / metrosEnCm; // Calcular la cantidad en metros (dividir cm entre 100)

Program.MostrarRespuesta();

Console.WriteLine($"Fórmula: {simbolo_Metros} = {simbolo_Centimetros} ÷ {metrosEnCm}"); // Mostrar fórmula
Console.WriteLine($"{simbolo_Metros} = {cantidadCm:N2} ÷ {metrosEnCm} = {cantidadMts:N2}\n"); // Mostrar resultado
}

}

}