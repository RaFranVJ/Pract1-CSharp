namespace PJpracticas.Ejercicios.SentenciasSelectivas.IfElse
{
/// <summary> Ejemplo #4 - Recibe los datos de una persona y verifica si es mayor o menor de edad. </summary>

public static class ActaDeNacimiento
{
/** <summary> Lee la edad introducido por el usuario del rango esperado (0-85). </summary>
<returns> La edad de la persona. </returns> */

private static int LeerEdad()
{
int edad;

// El bucle do-while se repite hasta que la edad esté en el rango permitido

do
Console.Write($"\rIngrese su edad: ");

while(!int.TryParse(Console.ReadLine(), out edad) || edad < 0 || edad > 85);

return edad;
}

/** <summary> Usa la sentencia if-else para verificar si una persona es mayor o menor de edad. </summary>

<paran name = "edadPersona"> La edad de la persona. </param>

<returns> La condición legal de la persona. </returns> */

private static string VerificarCondicionLegal(int edadPersona)
{
string condicionLegal;

// Condición 1: si la persona tiene 18 años o más, es mayor de edad
	
if(edadPersona >= 18)
condicionLegal = "Mayor de edad";

// Condición 2: de lo contrario, la persona es menor de edad

else
condicionLegal = "Menor de edad";

return condicionLegal;
}

/// <summary> Obtiene los datos de una persona para simular un acta de nacimiento. </summary>

public static void ObtenerDatos()
{
Console.WriteLine("====== Ejercicio #4 - Acta de nacimiento ======\n");


Console.WriteLine($"<------------- INFORMACIÓN DEL CIUDADANO ------------->\n");

Console.Write("Ingrese su cédula: ");
string? cedula = Console.ReadLine(); // Leer la cédula de la persona

Console.Write("Introduzca su nombre: ");
string? nombre = Console.ReadLine(); // Leer el nombre de la persona

Console.Write("Introduzca su apellido: ");
string? apellido = Console.ReadLine(); // Leer el apellido de la persona

int edad = LeerEdad(); // Leer la edad de la persona
DateTime fechaNacimiento = DateTime.Now.AddYears(-edad); // Calcular la fecha de nacimiento restando la edad actual al año actual

string condicionLegal = VerificarCondicionLegal(edad); // Verificar si la persona es mayor o menor de edad

Console.Clear();

// Una vez se recibe la información del ciudadano, se muestran los datos correspondientes:

Console.WriteLine($"<------------- SU ACTA DE NACIMIENTO ------------->\n");

Console.WriteLine($"Cédula: {cedula}");
Console.WriteLine($"Nombre: {nombre}");
Console.WriteLine($"Apellido: {apellido}");
Console.WriteLine($"Edad: {edad} años");
Console.WriteLine($"Fecha de nacimiento: {fechaNacimiento}");
Console.WriteLine($"Condición legal: {condicionLegal}\n");
}

}

}