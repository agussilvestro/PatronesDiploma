using Bridge;

internal class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, double> productos = new Dictionary<string, double>();

        productos.Add("Agua", 1500);
        productos.Add("Jugo", 1600);
        productos.Add("Gaseosas", 2240);
        productos.Add("Arroz", 5000);
        productos.Add("Carne", 8049);

        bool continuar = true;
        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("Menú para demostrar el Patrón Bridge:");
            Console.WriteLine("1. Mostrar lista de productos y totales con Implementación Estándar");
            Console.WriteLine("2. Mostrar lista original y lista con Aumento");
            Console.WriteLine("3. Mostrar lista original y lista con Descuento");
            Console.WriteLine("4. Salir");
            Console.WriteLine("Seleccione una opción:");

            string opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    Abstraccion abstraccion1 = new Abstraccion(new Implementacion(), productos);
                    MostrarListaProductos(productos);
                    abstraccion1.MostrarTotales();
                    break;
                case "2":
                    Abstraccion abstraccion2 = new Abstraccion(new Implementacion2(), productos);
                    MostrarListaProductos(productos);
                    MostrarListaModificada(productos, 1.21); // IVA
                    abstraccion2.MostrarTotales();
                    break;
                case "3":
                    Abstraccion abstraccion3 = new Abstraccion(new Implementacion3(), productos);
                    MostrarListaProductos(productos);
                    MostrarListaModificada(productos, 1.3); // CEPO
                    abstraccion3.MostrarTotales();
                    break;
                case "4":
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
    static void MostrarListaProductos(Dictionary<string, double> productos)
    {
        Console.WriteLine("\nLista de productos (ORIGINAL):");
        foreach (var producto in productos)
        {
            Console.WriteLine($"Producto: {producto.Key}, Precio: {producto.Value}");
        }
    }
    static void MostrarListaModificada(Dictionary<string, double> productos, double factor)
    {
        Console.WriteLine("\nLista de productos (NUEVA):");
        foreach (var producto in productos)
        {
            double precioModificado = producto.Value * factor;
            Console.WriteLine($"Producto: {producto.Key}, Precio Modificado: {precioModificado}");
        }
    }
}
