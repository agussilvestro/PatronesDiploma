using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class Fachada
    {
        private SistemaCompra compra = new SistemaCompra();
        private SubSistemaAlmacen almacen = new SubSistemaAlmacen();
        private SubSitemaEnvio envio = new SubSitemaEnvio();
        private int cantidadSeleccionada = 0;

        public void SelectProductos()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Seleccione la cantidad de productos:");
            Console.Write("Cantidad: ");
            if (int.TryParse(Console.ReadLine(), out cantidadSeleccionada))
            {
                if (almacen.VerificarStock(cantidadSeleccionada))
                {
                    Console.WriteLine("\nProducto disponible. Proceda con el pago.");
                    Compra();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No hay suficiente stock para la cantidad solicitada.");
                    cantidadSeleccionada = 0;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Cantidad no válida.");
            }
        }

        public void Compra()
        {
            if (compra.Comprar())
            {
                Console.ReadKey(); 

                if (almacen.SacarAlmacen(cantidadSeleccionada))
                {
                    Console.ReadKey(); 

                    envio.EnviarPedido();
                    Console.ReadKey(); 
                }
            }
        }
    }

}
