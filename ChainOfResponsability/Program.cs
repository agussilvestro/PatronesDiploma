using ChainOfResponsability;

class Program
{
    static void Main()
    {
        var handler1 = new ConcreteHandler1();
        var handler2 = new ConcreteHandler2();
        handler1.SetNext(handler2);

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Enviar Solicitud A");
            Console.WriteLine("2. Enviar Solicitud B");
            Console.WriteLine("3. Enviar solicitud anonima");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opcion: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    handler1.HandleRequest("A");
                    break;

                case "2":
                    handler1.HandleRequest("B");
                    break;

                case "3":
                    handler1.HandleRequest("C");
                    break;

                case "4":
                    Console.WriteLine("Saliendo...");
                    return;

                default:
                    Console.WriteLine("Opcion invalida");
                    break;
            }
        }
    }
}
