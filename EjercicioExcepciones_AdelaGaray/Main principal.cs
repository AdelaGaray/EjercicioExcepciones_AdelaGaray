// Adela Garay//
//Ejercicio de Excepciones//
// Realizaremos el main princpal//

using System;

class Program
{
    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            MostrarMenu();
            string opcion = Console.ReadLine();

            try
            {
                switch (opcion)
                {
                    case "1":
                        RealizarOperacion("sumar");
                        break;
                    case "2":
                        RealizarOperacion("restar");
                        break;
                    case "3":
                        RealizarOperacion("multiplicar");
                        break;
                    case "4":
                        RealizarOperacion("dividir");
                        break;
                    case "5":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada inválida. Por favor ingrese un número válido.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

    static void MostrarMenu()
    {
        Console.Clear();
        Console.WriteLine("Selecciona una opción:");
        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");
        Console.WriteLine("5. Salir");
        Console.Write("Opción: ");
    }

    static void RealizarOperacion(string operacion)
    {
        double a, b;
        Console.Write("Ingrese el primer número: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el segundo número: ");
        b = Convert.ToDouble(Console.ReadLine());

        double resultado = 0;

        switch (operacion)
        {
            case "sumar":
                resultado = Operaciones.Sumar(a, b);
                break;
            case "restar":
                resultado = Operaciones.Restar(a, b);
                break;
            case "multiplicar":
                resultado = Operaciones.Multiplicar(a, b);
                break;
            case "dividir":
                resultado = Operaciones.Dividir(a, b);
                break;
        }

        Console.WriteLine($"El resultado de la operación es: {resultado}");
        Console.WriteLine("Presione cualquier tecla para continuar...");
        Console.ReadKey();
    }
}