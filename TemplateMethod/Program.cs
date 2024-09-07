using TemplateMethod;

public class Program
{
    static void Main()
    {
        Meal meal = null;

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Preparar Pasta ");
            Console.WriteLine("2. Preparar Ensalada");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opcion: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    meal = new PastaMeal();
                    PrepararComidaPasoAPaso(meal);
                    break;

                case "2":
                    meal = new SaladMeal();
                    PrepararComidaPasoAPaso(meal);
                    break;

                case "3":
                    Console.WriteLine("Saliendo...");
                    return;

                default:
                    Console.WriteLine("Opcion Invalida.");
                    break;
            }
        }

    }
    static void PrepararComidaPasoAPaso(Meal meal)
    {
        bool ingredientesListos = false;
        bool platoCocinado = false;

        while (true)
        {
            Console.WriteLine("\nSeleccione el paso que desea ejecutar:");
            Console.WriteLine("1. Preparar Ingredientes");
            Console.WriteLine("2. Cocinar el Plato");
            Console.WriteLine("3. Servir");
            Console.WriteLine("4. Volver al menú principal");
            Console.Write("Seleccione una opción: ");

            string opcionPaso = Console.ReadLine();

            switch (opcionPaso)
            {
                case "1":
                    meal.PrepararIngredientes();
                    ingredientesListos = true;  
                    break;

                case "2":
                    if (!ingredientesListos)
                    {
                        Console.WriteLine("Primero debes preparar los ingredientes antes de cocinar.");
                        Console.ReadKey();  
                    }
                    else
                    {
                        meal.Cocinar();
                        platoCocinado = true;  
                    }
                    break;

                case "3":
                    if (!platoCocinado)
                    {
                        if (!ingredientesListos)
                        {
                            Console.WriteLine("Debes preparar los ingredientes y cocinar el plato antes de servir.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Debes cocinar el plato antes de servir.");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        meal.Servir();
                        Console.ReadKey();
                        Console.Clear();    
                    }
                    break;

                case "4":
                    Console.WriteLine("Volviendo al menu principal");
                    Console.ReadKey();
                    Console.Clear();
                    return; 

                default:
                    Console.WriteLine("Opcion Invalida.");
                    break;
            }
        }
    }
}
