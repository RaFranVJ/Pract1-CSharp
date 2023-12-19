namespace PJpracticas.Ejercicios.EstructurasDeProgramacion.CicloWhile
{
/// <summary> Ejemplo #2 - Imprime números pares hasta un límite dado. </summary>

public static class NumerosPares
{
/// <summary> Lee un número que sea par, y que esté dentro del rango definido (2-20). </summary>

private static int LeerNumeroPar()
{
int rangoMin = 2;
int rangoMax = 20;

Console.Write($"Introduce un número par entre {rangoMin} y {rangoMax}: ");
int numeroPar;

// Bucle while para validar la entrada

while(!int.TryParse(Console.ReadLine(), out numeroPar) )
{
// Si el número es par y está dentro del rango permitido, devolver el valor y finalizar ciclo

if(numeroPar >= rangoMin && numeroPar <= rangoMax && numeroPar % 2 == 0)
return numeroPar;

// De lo contrario, seguir recibiendo valores hasta que se introduzca uno válido

else
{
Console.WriteLine("El número ingresado no es par, o bien, está fuera del rango permitido.");
Console.WriteLine($"Rango permitido: {rangoMin} - {rangoMax}");

Console.Write("Vuelve a ingresar el valor: ");
}
	
}

return numeroPar;
}

/// <summary> Muestra los números pares. </summary>

public static void Mostrar()
{
Console.WriteLine("====== Ejercicio #2 - Números pares ======\n");

int limite = LeerNumeroPar();
int num = 2;

// El bucle while se repite hasta que se alcance el valor límite

while(num <= limite)
{
Console.Write(num + " "); // Imprimir el número actual (num)
num += 2; // Incremento en 2
}

}

}

}