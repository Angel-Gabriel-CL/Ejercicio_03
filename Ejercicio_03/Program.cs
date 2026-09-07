//--------------------------------------------------------------------      Encabezado del programa
using System.ComponentModel.Design;

Console.WriteLine("EJERCICIO_1");                                           //Numero de la practica
Console.WriteLine("CÁLCULO DEL PROMEDIO DE TRES CALIFICACIONES");           //Nombre del ejercicio
Console.WriteLine();                                                        //Instruccion para dejar un espacio en blanco en la consola
//Entradas, en esta parte pide los datosy el ReadLine es para mostrar y guardar el texto
Console.Write("Ingrese la primera calificación: ");
double calificacion1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la segunda calificación: ");
double calificacion2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la tercera calificación: ");
double calificacion3 = Convert.ToDouble(Console.ReadLine());
//--------------------------------------------------------------------      Operaciones
double promedio = (calificacion1 + calificacion2 + calificacion3) / 3.0;
//--------------------------------------------------------------------      Salidas, el sigo de $" es para unir los caracteres, conactenar(texto+variale double), el F2 es para indicar las cantidad de decimales a indicar o dar en el programa
Console.WriteLine();
Console.WriteLine($"El promedio de las tres calificaciones es: {promedio:F2}");
Console.WriteLine();

if (promedio >= 70)
{
    Console.WriteLine("Felicidades Alumno aprobado");
}
else
{
    Console.WriteLine("Alumno reprobado, sigue intentando");
}
Console.WriteLine();

if (promedio >= 90 && promedio <= 100)
{
    Console.WriteLine("Excelente");
}
else if (promedio >= 80 && promedio <= 89)
{
    Console.WriteLine("Alumno bueno");
}
else if (promedio >= 70 && promedio <= 79)
{ 
    Console.WriteLine("Alumno regular"); 
}
else if (promedio >= 60 && promedio <= 69)
{
    Console.WriteLine("Requiere apoyo");
}
if (promedio >= 10 && promedio <= 59)
{
    Console.WriteLine("Alumno eficiente");
}
if (promedio >= 0 && promedio <= 9)
{
    Console.WriteLine("Baja definitiva");
}