namespace PJpracticas.Ejercicios.EstructurasDeProgramacion.CicloDoWhile
{
/// <summary> Ejemplo #3 - Imprime un patrón de hasta 6 filas. </summary>

public static class PatronDeFilas
{
/// <summary> Muestra un patrón de filas usando el ciclo Do-while. </summary>

public static void Mostrar()
{
Console.WriteLine("====== Ejercicio #3 - Patrón de filas ======\n");

int numFilas = 6;
int i = 1;

// Primero, actualizar las variables (i y j)

do
{
int j = 1;

// Posteriormente, imprimir un caracter por cada ciclo
do
{
Console.Write("* ");
j++;
}

// Continuar imprimiendo caracteres si 'j' es menor o igual que 'i'

while(j <= i);

Console.WriteLine();
i++;
} 

// Finalmente, verificar si se ha mostrado la cantidad especifica de filas (6)

while(i <= numFilas);

}

}

}