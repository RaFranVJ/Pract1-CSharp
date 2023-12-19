namespace PJpracticas.Ejercicios.SentenciasSelectivas.SwitchCase
{
/// <summary> Ejemplo #1 - Muestra los días de la semana según la entrada del usuario (1-7). </summary>

public static class DiasDeLaSemana
{
/// <summary> Según el número dado, obtiene el nombre del día que ocupa ese lugar en la semana. </summary>
	
private static string ObtenerNombreDia(int numero)
{
// Según el caso, asignarle un valor a nombreDia

string nombreDia = numero switch
{
1 => "Lunes",
2 => "Martes",
3 => "Miércoles",
4 => "Jueves",
5 => "Viernes",
6 => "Sábado",
7 => "Domingo",
_ => "Número no válido",
};

return nombreDia;
}


/// <summary> Usa la sentencia switch-case para según el caso, mostrar un día de la semana. </summary>

public static void NombrarDia()
{
Console.WriteLine("====== Ejercicio #1 - Días de la semana ======\n");

Console.Write("Introduce un número del 1 al 7: ");
_ = int.TryParse(Console.ReadLine(), out int numero);

string dia = ObtenerNombreDia(numero);
Console.WriteLine($"Seleccionaste: {dia}");
}

}

}