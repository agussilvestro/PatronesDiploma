using Facade;

internal class Program
{
    static void Main(string[] args)
    {
        Fachada fachada = new Fachada();
        bool continuar = true;

        while (continuar)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Menú de Compra:");
            Console.WriteLine("1. Seleccionar productos y cantidades");
            Console.WriteLine("2. Salir");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    fachada.SelectProductos();
                    break;
                case "2":
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
}
