namespace PJpracticas.Ejercicios.SentenciasSelectivas.SwitchCase
{
/// <summary> Ejemplo #2 - Muestra los meses del año según la entrada del usuario (1-12). </summary>

public static class MesesDelAño
{
/// <summary> Según el número dado, obtiene el nombre del mes que ocupa ese lugar en el año. </summary>
	
private static string ObtenerNombreMes(int numero)
{
// Según el caso, asignarle un valor a nombreMes

string nombreMes = numero switch
{
1 => "Enero",
2 => "Febrero",
3 => "Marzo",
4 => "Abril",
5 => "Mayo",
6 => "Junio",
7 => "Julio",
8 => "Agosto",
9 => "Septiembre",
10 => "Octubre",
11 => "Noviembre",
12 => "Diciembre",
_ => "Número no válido"
};

return nombreMes;
}


/// <summary> Usa la sentencia switch-case para, según el caso, mostrar un mes del año. </summary>

public static void NombrarMes()
{
Console.WriteLine("====== Ejercicio #2 - Meses del año ======\n");

Console.Write("Introduce un número del 1 al 12: ");
_ = int.TryParse(Console.ReadLine(), out int numero);

string mes = ObtenerNombreMes(numero);
Console.WriteLine($"Seleccionaste: {mes}");
}

}

}