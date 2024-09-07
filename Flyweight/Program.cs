using Flyweight;
using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        FlyweightFactory flywf = new FlyweightFactory();

        List<int> Americana = new List<int>();
        List<int> Italiana = new List<int>();
        List<int> Mexicana = new List<int>();

        List<int> Carnes = new List<int>();
        List<int> Sopas = new List<int>();
        List<int> Ensaladas = new List<int>();

        List<int> Rapida = new List<int>();

        bool continuar = true;

        while (continuar)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Menú:");
            Console.WriteLine("1. Agregar receta");
            Console.WriteLine("2. Mostrar recetas en categoría");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    AgregarReceta(flywf, Americana, Italiana, Mexicana, Carnes, Sopas, Ensaladas, Rapida);
                    break;
                case "2":
                    MostrarRecetas(flywf, Americana, Italiana, Mexicana, Carnes, Sopas, Ensaladas, Rapida);
                    break;
                case "3":
                    Console.Write("Saliendo.... ");
                    continuar = false;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                    break;
            }

            if (continuar)
            {
                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
            }
        }

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Programa finalizado.");
    }

    private static void AgregarReceta(FlyweightFactory flywf, List<int> Americana, List<int> Italiana, List<int> Mexicana,
        List<int> Carnes, List<int> Sopas, List<int> Ensaladas, List<int> Rapida)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Ingrese el nombre de la receta: ");
        string nombre = Console.ReadLine();

        int index = flywf.Adicionat(nombre);

        if (index != -1)
        {
            Console.WriteLine("Receta agregada. Asignar a categorías:");
            Console.WriteLine("1. Americana");
            Console.WriteLine("2. Italiana");
            Console.WriteLine("3. Mexicana");
            Console.WriteLine("4. Carnes");
            Console.WriteLine("5. Sopas");
            Console.WriteLine("6. Ensaladas");
            Console.WriteLine("7. Rapida");
            Console.Write("Seleccione la categoría (separar con comas para múltiples): ");
            string categorias = Console.ReadLine();

            foreach (string categoria in categorias.Split(','))
            {
                switch (categoria.Trim())
                {
                    case "1":
                        Americana.Add(index);
                        break;
                    case "2":
                        Italiana.Add(index);
                        break;
                    case "3":
                        Mexicana.Add(index);
                        break;
                    case "4":
                        Carnes.Add(index);
                        break;
                    case "5":
                        Sopas.Add(index);
                        break;
                    case "6":
                        Ensaladas.Add(index);
                        break;
                    case "7":
                        Rapida.Add(index);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Categoría no válida.");
                        break;
                }
            }
        }
    }

    private static void MostrarRecetas(FlyweightFactory flywf, List<int> Americana, List<int> Italiana, List<int> Mexicana,
        List<int> Carnes, List<int> Sopas, List<int> Ensaladas, List<int> Rapida)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Seleccionar categoría para mostrar:");
        Console.WriteLine("1. Americana");
        Console.WriteLine("2. Italiana");
        Console.WriteLine("3. Mexicana");
        Console.WriteLine("4. Carnes");
        Console.WriteLine("5. Sopas");
        Console.WriteLine("6. Ensaladas");
        Console.WriteLine("7. Rapida");
        Console.Write("Seleccione una categoría: ");
        string categoria = Console.ReadLine();

        List<int> listaSeleccionada = null;

        switch (categoria)
        {
            case "1":
                listaSeleccionada = Americana;
                break;
            case "2":
                listaSeleccionada = Italiana;
                break;
            case "3":
                listaSeleccionada = Mexicana;
                break;
            case "4":
                listaSeleccionada = Carnes;
                break;
            case "5":
                listaSeleccionada = Sopas;
                break;
            case "6":
                listaSeleccionada = Ensaladas;
                break;
            case "7":
                listaSeleccionada = Rapida;
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Categoría no válida.");
                return;
        }

        foreach (int index in listaSeleccionada)
        {
            Receta receta = (Receta)flywf[index];
            receta.CalcularCosto();
            receta.Mostrar();
        }
    }
}
