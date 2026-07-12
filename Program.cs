// Laboratorio 01 - Programación Estructurada
using System;

class Program
{
    static void Main(string[] args)
    {
        const int MAX_MATERIAS = 6;

        Console.WriteLine("==========================================");
        Console.WriteLine("        REGISTRO DEL ESTUDIANTE");
        Console.WriteLine("==========================================");

        Console.Write("Nombre completo: ");
        string nombre = Console.ReadLine()!;

        Console.WriteLine();
        Console.WriteLine("Bienvenido(a), " + nombre);
        Console.WriteLine();

        Console.Write("Edad: ");
        int edad = Convert.ToInt32(Console.ReadLine());

        Console.Write("Carrera: ");
        string carrera = Console.ReadLine()!;

        Console.Write("Carné o código de estudiante: ");
        string carne = Console.ReadLine()!;

        Console.Write("Correo electrónico: ");
        string correo = Console.ReadLine()!;

        Console.Write("Número de teléfono: ");
        string telefono = Console.ReadLine()!;

        Console.Write("Promedio actual: ");
        double promedio = Convert.ToDouble(Console.ReadLine());

        Console.Write("Número de materias inscritas: ");
        int materias = Convert.ToInt32(Console.ReadLine());

        int edadFutura = edad + 5;

        Console.WriteLine();
        Console.WriteLine("==========================================");
        Console.WriteLine("        REGISTRO DEL ESTUDIANTE");
        Console.WriteLine("==========================================");
        Console.WriteLine();
        Console.WriteLine("Bienvenido(a), " + nombre);
        Console.WriteLine();

        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Edad: " + edad + " años");
        Console.WriteLine("Edad dentro de 5 años: " + edadFutura + " años");

        Console.WriteLine();

        Console.WriteLine("Carrera: " + carrera);
        Console.WriteLine("Carné: " + carne);
        Console.WriteLine("Correo: " + correo);
        Console.WriteLine("Teléfono: " + telefono);

        Console.WriteLine();

        Console.WriteLine("Promedio: " + promedio.ToString("F2"));
        Console.WriteLine("Materias inscritas: " + materias);
        Console.WriteLine("Máximo permitido: " + MAX_MATERIAS);

        Console.WriteLine();

        if (materias < MAX_MATERIAS)
        {
            Console.WriteLine("Puede inscribir más materias: Sí");
        }
        else
        {
            Console.WriteLine("Puede inscribir más materias: No");
        }

        Console.WriteLine();
        Console.WriteLine("==========================================");
        Console.WriteLine("Gracias por utilizar el sistema.");
        Console.WriteLine("==========================================");

        Console.WriteLine();
        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();
    }
}