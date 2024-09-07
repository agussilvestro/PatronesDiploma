using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Implementacion3 : IBridge
    {
        public void ListarProductos(Dictionary<string, double> pProductos)
        {
            double total = 0;
            int cantidad = 0;
            foreach (KeyValuePair<string, double> item in pProductos)
            {

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(item.Key);
            }

        }

        public void MostrarTotales(Dictionary<string, double> pProductos)
        {
            double total = 0;
            int cantidad = 0;
            foreach (KeyValuePair<string, double> item in pProductos)
            {
                total += item.Value;
                cantidad++;
            }
            Console.WriteLine("El total de {0} productos + Cepo es de ${1}", cantidad, total);
        }
    }
}
