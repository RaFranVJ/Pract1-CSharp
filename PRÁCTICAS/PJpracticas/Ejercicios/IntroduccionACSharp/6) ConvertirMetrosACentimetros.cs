namespace PJpracticas.Ejercicios.IntroduccionACSharp
{
/// <summary> Ejemplo #6 - Convertir de metros a centímetros. </summary>

public class ConvertirMetrosACentimetros : ConvertirCentimetrosAMetros
{
/// <summary> Convierte la cantidad de metros introducida por el usuario a centímetros. </summary>

public static void ConvertirCms()
{
Console.WriteLine("====== Ejercicio #6 - Convertir de metros a centímetros ======\n");

Console.Write("Introduce la cantidad de metros: ");
_ = float.TryParse(Console.ReadLine(), out float cantidadMts); // Leer cantidad de metros y pasarla a float

float cantidadCm = cantidadMts * metrosEnCm; // Calcular cantidad en cm (metros por 100)

Program.MostrarRespuesta();;

Console.WriteLine("$Fórmula: {simbolo_Centimetros} = {simbolo_Metros} x {metrosEnCm}"); // Mostrar formula
Console.WriteLine($"{simbolo_Centimetros} = {cantidadMts:N2} x {metrosEnCm} = {cantidadCm:N2}\n"); // Mostrar resultado
}

}

}