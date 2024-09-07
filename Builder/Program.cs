using Builder;

internal class Program
{
    static void Main(string[] args)
    {
        Director miDirector = new Director();
        bool continuar = true;

        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("Menú para construir un auto:");
            Console.WriteLine("1. Construir Auto Clásico");
            Console.WriteLine("2. Construir Auto Deportivo");
            Console.WriteLine("3. Salir");
            Console.WriteLine("Seleccione una opción:");

            string opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    AutoClasico normal = new AutoClasico();
                    miDirector.Construye(normal);
                    Auto autoClasico = normal.ObtenProducto();
                    autoClasico.MostrarAuto();
                    break;
                case "2":
                    AutoDeportivo deportivo = new AutoDeportivo();
                    miDirector.Construye(deportivo);
                    Auto autoDeportivo = deportivo.ObtenProducto();
                    autoDeportivo.MostrarAuto();
                    break;
                case "3":
                    Console.WriteLine("Saliendo...");
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                    break;
            }
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
