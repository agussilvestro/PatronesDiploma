using Command;

class Program
{
    static void Main()
    {
        var light = new Luz();
        var turnOnCommand = new EncenderCommand(light);
        var turnOffCommand = new ApagarCommand(light);

        var remoteControl = new ControlRemoto();

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Encender Luz");
            Console.WriteLine("2. Apagar Luz");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opcion: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    if (light.Encendida)
                    {
                        Console.WriteLine("La luz ya está encendida.");
                    }
                    else
                    {
                        remoteControl.SetCommand(turnOnCommand);
                        remoteControl.PressButton();
                    }
                    Console.ReadKey();
                    break;

                case "2":
                    if (!light.Encendida)
                    {
                        Console.WriteLine("La luz ya está apagada.");
                    }
                    else
                    {
                        remoteControl.SetCommand(turnOffCommand);
                        remoteControl.PressButton();
                    }
                    Console.ReadKey();
                    break;

                case "3":
                    Console.WriteLine("Saliendo...");
                    Console.ReadKey();
                    return;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }
    }
}