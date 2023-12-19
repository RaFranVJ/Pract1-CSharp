using PJpracticas.Ejercicios.EstructurasDeProgramacion.CicloFor;

namespace PJpracticas.Ejercicios.SentenciasSelectivas.SwitchCase
{
/// <summary> Ejemplo #3 - Evaluar la calificación de un estudiante. </summary>

public class EvaluarCalificacion : DatosDe15Estudiantes
{
/// <summary> Hace la evaluación del estudiante. </summary>

public static void HacerEvaluacion()
{
Console.WriteLine("====== Ejercicio #3 - Evaluar calificación ======\n");

float calificacion = LeerNota("Evaluar"); // Leer la calificación

// Evaluar la calificación según el caso

switch(calificacion)
{
case float n when (n >= 90 && n <= 100):
Console.WriteLine("¡Excelente! Tienes una A.");
break;

case float n when (n >= 80 && n < 90):
Console.WriteLine("Obtuviste una B. ¡Buen trabajo!");
break;

default:
Console.WriteLine("Conseguiste una C. Inténtalo de nuevo, ¡ánimo!");
break;
}

}

}

}
