using PJpracticas.Ejercicios.IntroduccionACSharp;
using PJpracticas.Ejercicios.EstructurasDeProgramacion.CicloFor;
using PJpracticas.Ejercicios.EstructurasDeProgramacion.CicloWhile;
using PJpracticas.Ejercicios.EstructurasDeProgramacion.CicloDoWhile;
using PJpracticas.Ejercicios.SentenciasSelectivas.IfElse;
using PJpracticas.Ejercicios.SentenciasSelectivas.SwitchCase;

namespace PJpracticas
{
/// <summary> Clase principal del programa. </summary>

public static class Program
{
/// <summary> Muestra la respuesta de un método después de que el usuario presione una tecla. </summary>

public static void MostrarRespuesta()
{
Console.WriteLine();

Console.Write("Presiona una tecla para ver la respuesta.");
Console.ReadKey(true);

Console.Clear();

Console.WriteLine("----------> Respuesta <----------\n");
}

/// <summary> Diálogo para la selección de funciones. </summary>

private static int DialogSelecFun()
{
Console.Write("Ingresa un número para llamar una función: ");
_ = int.TryParse(Console.ReadLine(), out int numFuncion);

Console.WriteLine();
return numFuncion;
}

/// <summary> Diálogo para la selección de ejercicios. </summary>

private static char DialogSelecEj()
{
Console.Write("Selecciona un ejercicio presionando la tecla correspondiente al mismo: ");
var teclaPres = Console.ReadKey(); // Capturar la tecla presionada por el usuario

Console.WriteLine("\n");
return char.ToUpper(teclaPres.KeyChar); // Solo se aceptan caracteres en mayúsculas
}

/// <summary> Menú de la primera Unidad (Introduccción a C#). </summary>

private static void Menu1()
{
Console.WriteLine("<----------- Introducción a C# ---------->\n");

Console.WriteLine("1) Sumar dos números");
Console.WriteLine("2) Calcular área de un círculo");
Console.WriteLine("3) Convertir de metros a centímetros");
Console.WriteLine("4) Calcular área de un triángulo");
Console.WriteLine("5) Generar factura de un producto");
Console.WriteLine("6) Convertir de centímetros a metros\n");

int numFuncion = DialogSelecFun();

switch(numFuncion)
{
case 1:
Suma2Numeros.SumarValores();
break;

case 2:
AreaCirculo.CalcularArea();
break;

case 3:
ConvertirCentimetrosAMetros.ConvertirMts();
break;

case 4:
AreaTriangulo.CalcularArea();
break;

case 5:
FacturaProducto.GenerarFactura();
break;

case 6:
ConvertirMetrosACentimetros.ConvertirCms();
break;

default:
Console.WriteLine($"La función '{numFuncion}' no existe.");
break;
}

}

/// <summary> Sub-menú para los ejercicios del ciclo for. </summary>
private static void SubMenuCicloFor()
{
Console.WriteLine("<----------- Ejercicios del Ciclo for ---------->\n");

Console.WriteLine("A. Contar números");
Console.WriteLine("B. Cuenta regresiva");
Console.WriteLine("C. Tabla de multiplicar");
Console.WriteLine("D. Reloj");
Console.WriteLine("E. Obtener datos de 15 estudiantes\n");

char ejercicio = DialogSelecEj();

switch(ejercicio)
{
case 'A':
ContarNumeros.IniciarConteo();
break;

case 'B':
CuentaRegresiva.IniciarConteo();
break;

case 'C':
TablaDeMultiplicar.MostrarMultiplos();
break;

case 'D':
Reloj.Iniciar();
break;

case 'E':
DatosDe15Estudiantes.ObtenerDatos();
break;

default:
Console.WriteLine("Ejercicio no disponible.");
break;
}

}

/// <summary> Sub-menú para los ejercicios del ciclo while. </summary>
private static void SubMenuCicloWhile()
{
Console.WriteLine("<----------- Ejercicios del Ciclo while ---------->\n");

Console.WriteLine("A. Suma mayor que 0");
Console.WriteLine("B. Mostrar números pares");
Console.WriteLine("C. Hacer sucesión de Fibonacci");
Console.WriteLine("D. Juego de adivinanza");
Console.WriteLine("E. Calcular conciliación de clientes\n");

char ejercicio = DialogSelecEj();

switch(ejercicio)
{
case 'A':
SumaMayorQue0.SumarValores();
break;

case 'B':
NumerosPares.Mostrar();
break;

case 'C':
SucesionDeFibonacci.MostrarSerie();
break;

case 'D':
AdivinarNumero.Empieza();
break;

case 'E':
CalcularConciliacion.HacerCalculos();
break;

default:
Console.WriteLine("Ejercicio no disponible.");
break;
}

}

/// <summary> Sub-menú para los ejercicios del ciclo do-while. </summary>
private static void SubMenuCicloDoWhile()
{
Console.WriteLine("<----------- Ejercicios del Ciclo do-While ---------->\n");

Console.WriteLine("A. Filtrar un número positivo");
Console.WriteLine("B. Adivinar la clave secreta");
Console.WriteLine("C. Mostrar patrón de filas");
Console.WriteLine("D. Juego de dados");
Console.WriteLine("E. Iniciar tiempo de espera\n");

char ejercicio = DialogSelecEj();

switch(ejercicio)
{
case 'A':
FiltrarNumeroPositivo.FiltrarValor();
break;

case 'B':
ClaveSecreta.ValidarClave();
break;

case 'C':
PatronDeFilas.Mostrar();
break;

case 'D':
Dados.Lanzar();
break;

case 'E':
TiempoDeEspera.Iniciar();
break;

default:
Console.WriteLine("Ejercicio no disponible.");
break;
}

}

/// <summary> Menú de la segunda Unidad (Estructuras de programación). </summary>

private static void Menu2()
{
Console.WriteLine("<----------- Estructuras de programación ---------->\n");

Console.WriteLine("1) Ver 5 ejercicios con el ciclo for");
Console.WriteLine("2) Ver 5 ejercicios con el ciclo while");
Console.WriteLine("3) Ver 5 ejercicios del ciclo do-while\n");

int numFuncion = DialogSelecFun();

switch(numFuncion)
{
case 1:
SubMenuCicloFor();
break;

case 2:
SubMenuCicloWhile();
break;

case 3:
SubMenuCicloDoWhile();
break;

default:
Console.WriteLine($"La función '{numFuncion}' no existe.");
break;
}

}

/// <summary> Sub-menú para los ejercicios con la sentencia if-else. </summary>
private static void SubMenuSentenciaIfElse()
{
Console.WriteLine("<----------- Ejercicios con la sentencia if-else ---------->\n");

Console.WriteLine("A. Obtener signo de un número");
Console.WriteLine("B. Determinar si un número es par o impar");
Console.WriteLine("C. Comparar dos valores");
Console.WriteLine("D. Acta de nacimiento");
Console.WriteLine("E. Analizar tipo de cadena\n");

char ejercicio = DialogSelecEj();

switch(ejercicio)
{
case 'A':
SignoDeUnNumero.VerificarSigno();
break;

case 'B':
NumeroParOImpar.VerificarParidad();
break;

case 'C':
CompararValores.HacerComparacion();
break;

case 'D':
ActaDeNacimiento.ObtenerDatos();
break;

case 'E':
TipoDeCadena.Verificar();
break;

default:
Console.WriteLine("Ejercicio no disponible.");
break;
}

}

/// <summary> Sub-menú para los ejercicios con la sentencia switch-case. </summary>
private static void SubMenuSentenciaSwitchCase()
{
Console.WriteLine("<----------- Ejercicios con la sentencia switch-case ---------->\n");

Console.WriteLine("A. Días de la semana");
Console.WriteLine("B. Meses del año");
Console.WriteLine("C. Evaluar calificación de un estudiante");
Console.WriteLine("D. Calculadora básica");
Console.WriteLine("E. Menú de un restaurante\n");

char ejercicio = DialogSelecEj();

switch(ejercicio)
{
case 'A':
DiasDeLaSemana.NombrarDia();
break;

case 'B':
MesesDelAño.NombrarMes();
break;

case 'C':
EvaluarCalificacion.HacerEvaluacion();
break;

case 'D':
CalculadoraBasica.Encender();
break;

case 'E':
MenuRestaurante.Mostrar();
break;

default:
Console.WriteLine("Ejercicio no disponible.");
break;
}

}

/// <summary> Menú de la tercera Unidad (Sentencias selectivas). </summary>

private static void Menu3()
{
Console.WriteLine("<----------- Sentencias selectivas ---------->\n");

Console.WriteLine("1) Ver 5 ejercicios con la sentencia if-else");
Console.WriteLine("2) Ver 5 ejercicios con la sentencia swich-case\n");

int numFuncion = DialogSelecFun();

switch(numFuncion)
{
case 1:
SubMenuSentenciaIfElse();
break;

case 2:
SubMenuSentenciaSwitchCase();
break;

default:
Console.WriteLine($"La función '{numFuncion}' no existe.");
break;
}

}

/// <summary> Permite al usuario seleccionar una Unidad y visualizar sus respectivos ejercicios. </summary>

private static void SelecUnidad()
{
Console.WriteLine("<----------- Unidades---------->\n");

Console.WriteLine("I. Introducción a C#");
Console.WriteLine("II. Estructuras de programación");
Console.WriteLine("III. Sentencias selectivas\n");

Console.Write("Ingresa el número romano de la unidad a visualizar: ");
string? unidad = Console.ReadLine();

Console.WriteLine();

switch(unidad)
{
case "I":
Menu1();
break;

case "II":
Menu2();
break;

case "III":
Menu3();
break;

default:
Console.WriteLine($"La unidad '{unidad}' no está disponible.");
break;
}

}

/// <summary> Método principal del programa </summary>

public static void Main()
{
Console.WriteLine("<----------- Programación I ---------->\n");

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Práctica final hecha por Francisco Villanueva (1-23-6951).\n");
Console.ResetColor();

SelecUnidad();
Console.WriteLine();

Console.Write("Presiona una tecla para salir del programa.");
Console.ReadKey();
}

}

}