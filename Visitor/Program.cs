using Visitor;

class Program
{
    static void Main()
    {
        var elements = new List<IElement> { new ElementA(), new ElementB() };
        var visitor = new ConcreteVisitor();

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Visitar Element A");
            Console.WriteLine("2. Visitar Element B");
            Console.WriteLine("3. Visitar todos los elements");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opcion: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    elements[0].Accept(visitor);
                    break;

                case "2":
                    elements[1].Accept(visitor);
                    break;

                case "3":
                    foreach (var element in elements)
                    {
                        element.Accept(visitor);
                    }
                    break;

                case "4":
                    Console.WriteLine("Saliendo...");
                    return;

                default:
                    Console.WriteLine("Opcion Invalida.");
                    break;
            }
        }
    }
}