using State;

class Program
{
    static void Main()
    {
        var context = new Context(new ConcreteStateA());

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Manejar Solicitud");
            Console.WriteLine("2. Salir");
            Console.Write("Seleccione una opcion: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    context.Request();
                    break;

                case "2":
                    Console.WriteLine("Saliendo...");
                    return;

                default:
                    Console.WriteLine("Opcion Invalida.");
                    break;
            }
        }
    }
}
