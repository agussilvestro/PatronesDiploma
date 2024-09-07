using Proxy;

internal class Program
{
    static void Main(string[] args)
    {
        while (true) 
        {
            ISujeto proxy = null;
            int opcionProxy = 0;

            //MENU PARA ELEGIR TIPO DE PROXY
            while (true)
            {
                Console.WriteLine("Selecciona el tipo de proxy:");
                Console.WriteLine("1. Proxy Sencillo");
                Console.WriteLine("2. Proxy Seguro");
                Console.WriteLine("3. Salir del programa");
                opcionProxy = Convert.ToInt32(Console.ReadLine());

                if (opcionProxy == 1)
                {
                    proxy = new ProxySencillo();
                    break;
                }
                else if (opcionProxy == 2)
                {
                    proxy = new ProxySeguro();
                    break;
                }
                else if (opcionProxy == 3)
                {
                    Console.WriteLine("Saliendo del programa.");
                    return; 
                }
                else
                {
                    Console.WriteLine("Opción inválida. Intente Nuevamente");
                }
            }

            //MENU PARA OPERACIONES
            while (true)
            {
                Console.WriteLine("Selecciona la operación:");
                Console.WriteLine("1. Mostrar receta secreta");
                Console.WriteLine("2. Cocinar");
                Console.WriteLine("3. Volver al menú principal");
                int opcionOperacion = Convert.ToInt32(Console.ReadLine());

                if (opcionOperacion == 1 || opcionOperacion == 2)
                {
                    proxy.Peticion(opcionOperacion);
                }
                else if (opcionOperacion == 3)
                {
                    Console.WriteLine("Volviendo al menú principal.");
                    Console.ReadKey();  
                    Console.Clear();
                    break; 
                }
                else
                {
                    Console.WriteLine("Opción inválida. Intente Nuevamente");
                }
            }
        }
    }

}
