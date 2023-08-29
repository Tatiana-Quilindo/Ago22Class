namespace Ago22Class
{
    public class Program
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
                        Class1.Ejercicio1();
                        break;
                    case 2:
                        Class2.Ejercicio2();
                        break;
                    case 3:
                        Class3.Ejercicio3();
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

       

     

        
    }
}
