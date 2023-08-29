

using System;

class Program
{
    static void Main(string[] args)
    {
        int option;

        do
        {
            Console.WriteLine("Elija una opción:");
            Console.WriteLine("1. Ejercicio 1: Número aleatorio y aumento");
            Console.WriteLine("2. Ejercicio 2: Porcentaje de hombres y mujeres");
            Console.WriteLine("3. Ejercicio 3: Conversión de temperatura");
            Console.WriteLine("4. Salir");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Ejercicio1();
                    break;
                case 2:
                    Ejercicio2();
                    break;
                case 3:
                    Ejercicio3();
                    break;
                case 4:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        } while (option != 4);
    }

    static void Ejercicio1()
    {
        Random random = new Random();
        int numeroAleatorio = random.Next(201); // Genera un número entre 0 y 200
        Console.WriteLine("Número aleatorio: " + numeroAleatorio);

        double aumento = numeroAleatorio * 1.3;
        Console.WriteLine("Número aumentado en un 30%: " + aumento);
    }

    static void Ejercicio2()
    {
        Console.WriteLine("Ingrese el total de hombres:");
        int totalHombres = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el total de mujeres:");
        int totalMujeres = int.Parse(Console.ReadLine());

        double porcentajeHombres = (double)totalHombres / (totalHombres + totalMujeres) * 100;
        double porcentajeMujeres = (double)totalMujeres / (totalHombres + totalMujeres) * 100;

        Console.WriteLine("Porcentaje de hombres: " + porcentajeHombres.ToString("0.00") + "%");
        Console.WriteLine("Porcentaje de mujeres: " + porcentajeMujeres.ToString("0.00") + "%");
    }

    static void Ejercicio3()
    {
        Console.WriteLine("Ingrese la temperatura en Celsius:");
        double tempCelsius = double.Parse(Console.ReadLine());

        double tempFahrenheit = (tempCelsius * 9 / 5) + 32;
        Console.WriteLine("Temperatura en Fahrenheit: " + tempFahrenheit.ToString("0.00") + " °F");
    }
}