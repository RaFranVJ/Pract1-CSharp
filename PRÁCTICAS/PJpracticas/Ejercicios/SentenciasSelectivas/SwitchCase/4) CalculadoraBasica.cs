namespace PJpracticas.Ejercicios.SentenciasSelectivas.SwitchCase
{
/// <summary> Ejemplo #4 - Calculadora con operaciones básicas. </summary>

public class CalculadoraBasica
{
/// <summary> Suma dos números introducidos por el usuario. </summary>

public static void Suma()
{
Console.Write("Ingresa un número: ");
_ = int.TryParse(Console.ReadLine(), out int a); // Leer primer número

Console.Write("Ingresa otro número: ");
_ = int.TryParse(Console.ReadLine(), out int b); // Leer segundo número

Program.MostrarRespuesta();

int c = a + b; // Sumar a y b
Console.WriteLine("\n{0:N} + {1:N} = {2:N}", a, b, c); // Mostrar la suma y su resultado
}

/// <summary> Resta dos números introducidos por el usuario. </summary>

public static void Resta()
{
Console.Write("Ingresa un valor para el minuendo: ");
_ = int.TryParse(Console.ReadLine(), out int a); // Leer primer número

Console.Write("Ingresa un valor para el sustraendo: ");
_ = int.TryParse(Console.ReadLine(), out int b); // Leer segundo número

Program.MostrarRespuesta();

int c = a - b; // Restar a de b
Console.WriteLine("\n{0:N} - {1:N} = {2:N}", a, b, c); // Mostrar la resta y su resultado
}

/// <summary> Multiplica dos números introducidos por el usuario. </summary>

public static void Multiplicacion()
{
Console.Write("Ingresa un valor para el multiplicando: ");
_ = int.TryParse(Console.ReadLine(), out int a); // Leer multiplicando

Console.Write("Ingresa un valor para el multiplicador: ");
_ = int.TryParse(Console.ReadLine(), out int b); // Leer multiplicador

Program.MostrarRespuesta();

int c = a * b; // Multiplicar a por b
Console.WriteLine("\n{0:N} × {1:N} = {2:N}", a, b, c); // Mostrar la multiplicación y su resultado
}

/// <summary> Divide dos números introducidos por el usuario. </summary>

public static void Division()
{
Console.Write("Ingresa un valor para el dividendo: ");
_ = int.TryParse(Console.ReadLine(), out int a); // Leer dividendo

Console.Write("Ingresa un valor para el divisor: ");
_ = int.TryParse(Console.ReadLine(), out int b); // Leer divisor

Program.MostrarRespuesta();
int c;

// Si el divisor es diferente de 0, hacer la división

if(b != 0)
{
c = a / b; // Como el divisor no es 0, se puede dividir sin problemas
Console.WriteLine("\n{0:N} ÷ {1:N} = {2:N}", a, b, c); // Mostrar la división y su resultado
}

// De lo contrario, mostrar un mensaje de advertencia al usuario

else
Console.WriteLine("\u221E Imposible dividir entre cero.");

}

/// <summary> Eleva la base por el exponente seleccionado por el usuario. </summary>

public static void Potencia()
{
Console.Write("Ingresa un valor para la base: ");
_ = int.TryParse(Console.ReadLine(), out int a); // Leer valor de la base

Console.Write("Ingresa un valor para el exponente: ");
_ = int.TryParse(Console.ReadLine(), out int b); // Leer valor del exponente

Program.MostrarRespuesta();

double c = Math.Pow(a, b); // Elevar la base a al exponente b
Console.WriteLine("\n{0:N} ^ {1:N} = {2:N}", a, b, c); // Mostrar la potencia y su resultado
}

/// <summary> Obtiene la raiz del número seleccionado por el usuario. </summary>

public static void Raiz()
{
Console.Write("Ingresa un valor para el índice: ");
_ = int.TryParse(Console.ReadLine(), out int a); // Leer índice

Console.Write("Ingresa un valor para el exponente: ");
_ = int.TryParse(Console.ReadLine(), out int b); // Leer radicando

Program.MostrarRespuesta();

double c = Math.Pow(b, 1/a); // Elevar la base b (radicando) entre el inverso del índice para encontrar la raíz
Console.WriteLine("\n{0:N}√{1:N} = {2:N}", a, b, c); // Mostrar la raíz y su resultado
}

/// <summary> Hace una de las 6 operaciones básicas. </summary>

private static void HacerOperacion(int operacion)
{
// Según el caso, realizar una operacion

switch(operacion)
{
case 1:
Suma();
break;

case 2:
Resta();
break;

case 3:
Multiplicacion();
break;

case 4:
Division();
break;

case 5:
Potencia();
break;

case 6:
Raiz();
break;

default:
Console.WriteLine("Operación no válida");
break;
}

}

/// <summary> Enciende la calculadora. </summary>

public static void Encender()
{
Console.WriteLine("====== Ejercicio #4 - Calculadora básica ======\n");

Console.WriteLine("1) Suma");
Console.WriteLine("2) Resta");
Console.WriteLine("3) Multiplicación");
Console.WriteLine("4) División");
Console.WriteLine("5) Potencia");
Console.WriteLine("6) Raíz\n");

Console.Write("Selecciona una operación: ");
_ = int.TryParse(Console.ReadLine(), out int operacion);

Console.WriteLine();
HacerOperacion(operacion);
}

}

}