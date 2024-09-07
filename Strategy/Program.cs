using Strategy;

class Program
{
    static void Main()
    {
        var context = new Context(new ConcreteStrategyA());

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Ejecutar Strategy A");
            Console.WriteLine("2. Ejecutar Strategy B");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opcion: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    context.SetStrategy(new ConcreteStrategyA());
                    context.ExecuteStrategy();
                    break;

                case "2":
                    context.SetStrategy(new ConcreteStrategyB());
                    context.ExecuteStrategy();
                    break;

                case "3":
                    Console.WriteLine("Saliendo...");
                    return;

                default:
                    Console.WriteLine("Opcion invalida.");
                    break;
            }
        }
    }
}
