namespace PJpracticas.Ejercicios.EstructurasDeProgramacion.CicloFor
{
/// <summary> Ejemplo #5 - Obtener datos de 15 estudiantes. </summary>

public class DatosDe15Estudiantes
{
/// <summary> Continua con el registro del próximo estudiante cuando el usuario presiona una tecla cualquiera. </summary>

private static void ContConSigteEstudiante()
{
Console.Write("Presiona una tecla para continuar con el registro del siguiente estudiante.");
Console.ReadKey(true);

Console.Clear();
}

/** <summary> Obtiene una calificación dentro del rango permitido (0-100). </summary>

<param name = "nombreNota"> El nombre de la nota a obtener (puede ser de un periodo o de una materia). </param>

<returns> El valor de la nota. </returns> */

protected static float LeerNota(string nombreNota)
{
float nota;

// El bucle do-while se repite hasta que el valor de la nota esté en el rango permitido

do
Console.Write($"\rIntroduce la nota para {nombreNota}: ");

while(!float.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 100);

return nota;
}

/** <summary> Verifica si el estudiante aprobó o reprobó la materia según la calificación obtenida. </summary>

<param name = "nota"> La nota del estudiante. </param>

<returns> La condición de la materia. </returns> */

private static string ValidarCondicionDeMateria(float nota) => (nota < 70) ? "Reprobado" : "Aprobado";

/** <summary> Obtiene los datos de 15 estudiantes usando el bucle for. </summary>
<remarks> Datos a obtener: nombre, apellido, matrícula, nota (P1 y P2) y nota final (promedio de P1 y P2). </remarks> */

public static void ObtenerDatos()
{
Console.WriteLine("====== Ejercicio #5 - Obtener datos de estudiantes ======\n");

string? matricula, nombre, apellido, condicionMateria;
float P1, P2, notaFinal;

int numEstudiantes = 15;

// Por cada estudiante se procesa cada dato y se muestra la misma en pantalla usando el bucle For

for(int i = 1; i <= numEstudiantes; i++)
{
Console.WriteLine($"<------------- INFORMACIÓN DEL ESTUDIANTE #{i} de {numEstudiantes} ------------->\n");

Console.Write("Ingresa la matrícula del estudiante: ");
matricula = Console.ReadLine(); // Leer la matrícula del estudiante

Console.Write("Ingresa el nombre del estudiante: ");
nombre = Console.ReadLine(); // Leer el nombre del estudiante

Console.Write("Ingresa el apellido del estudiante: ");
apellido = Console.ReadLine(); // Leer el apellido del estudiante

P1 = LeerNota("P1"); // Leer nota del P1
P2 = LeerNota("P2"); // Leer nota del P2

notaFinal = (P1 + P2) / 2; // Sacar promedio de las dos notas para la nota final
condicionMateria = ValidarCondicionDeMateria(notaFinal); // Verificar si el estudiante aprobó o reprobó la materia

Console.Clear();

// Una vez el usuario registra al estudiante, se muestran los datos correspondientes:

Console.WriteLine($"<------------- REGISTRO DE NOTAS #{i} de {numEstudiantes} ------------->\n");

Console.WriteLine($"Nombre del estudiante: {nombre}");
Console.WriteLine($"Apellido del estudiante: {apellido}");
Console.WriteLine($"Matrícula del estudiante: {matricula}");
Console.WriteLine($"Nota del P1: {P1:N1}");
Console.WriteLine($"Nota del P2: {P2:N1}");
Console.WriteLine($"Nota final: {notaFinal:N1}");
Console.WriteLine($"Nota final: {notaFinal:N1}");
Console.WriteLine($"Condición: {condicionMateria}\n");

ContConSigteEstudiante();
}

}

}

}