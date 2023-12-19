using System.Collections.Generic;

namespace PJpracticas.Ejercicios.SentenciasSelectivas.SwitchCase
{
/// <summary> Ejemplo #5 - Menú de un restaurante. </summary>

public static class MenuRestaurante
{
/// <summary> Las opciones del menú (Nombre del platillo y precio en pesos dominicanos). </summary>

private static readonly Dictionary<string, int> opciones = new()
{

{ "Bandera dominicana", 150 },
{ "Mangú tres golpes", 200 },
{ "Sancocho", 250 },
{ "Pica pollo", 150 },
{ "Yaroa", 200 },
{ "Pescado frito", 600 },
{ "Pasteles en hoja", 300 }

};

/// <summary> Diálogo para la selección de opciones. </summary>

private static int DialogSelecOp()
{
int rangoMin = 0;
int rangoMax = opciones.Count - 1;

// Imprimir todas las opciones disponibles

for(int i = rangoMin; i <= rangoMax; i++)
{
var infoPlato = opciones.ElementAt(i);
Console.WriteLine("Opción {0} - {1} .............. RD$ {2}", i, infoPlato.Key, infoPlato.Value);

if(i == rangoMax)
Console.WriteLine();

}

Console.Write("¿Qué desea ordenar? Escriba el número aquí: ");
int opcion;

// El bucle while se repite hasta que el valor esté dentro del rango especificado

while(!int.TryParse(Console.ReadLine(), out opcion) || opcion < rangoMin || opcion > rangoMax)
{
Console.WriteLine("¡Vaya! Parece que no tenemos eso.");
Console.WriteLine($"Opciones disponibles: números del {rangoMin} al {rangoMax}.\n");

Console.Write("Elige una opción: ");
Console.WriteLine();
}

return opcion;
}

/// <summary> Muestra las opciones del menú. </summary>

public static void Mostrar()
{
Console.WriteLine("====== Ejercicio #5 - Menú de un restaurante ======\n");

int opcion = DialogSelecOp();
var platillo = opciones.ElementAt(opcion);

Console.WriteLine("Ha seleccionado: \"{0}\" con un precio de {1} DOP.", platillo.Key, platillo.Value);

Console.WriteLine("<--------- Información del platillo --------->\n");

// Segun el caso, mostrar una breve descripción del platillo seleccionado

switch(opcion)
{
case 0:
Console.WriteLine("Arroz blanco acompañado de habichuelas rojas y carne de res guisada.");
break;

case 1:
Console.WriteLine("Puré de plátano verde acompañado de cebollas, huevos y queso (ambos fritos).");
break;

case 2:
Console.WriteLine("Caldo de carne de res o pollo y víveres (plátano, yuca, yautía, ñame).\nViene acompañado con su arroz y su tajadita de aguacate.");
break;

case 3:
Console.WriteLine("Pollo frito con una corteza crujiente, acompañado con papas fritas o plátanos fritos.");
break;

case 4:
Console.WriteLine("Papas fritas acompañada con queso fundido y carne molida.\nPuedes elegir entre carne de res o pollo.");
break;

case 5:
Console.WriteLine("Pescado acompañado de tostones o yuca frita.");
break;

case 6:
Console.WriteLine("Los puedes elegir entre diferentes variedades.\n\nMasa: de plátano o de yuca.\nRelleno: de queso, res, pollo, cerdo, queso con berenjena o de lambí.");
break;
}

}

}

}