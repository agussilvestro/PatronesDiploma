using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class SubSistemaAlmacen
    {
        private int cantidad;

        public SubSistemaAlmacen()
        {
            cantidad = 3; 
        }

        public bool VerificarStock(int cantidadSolicitada)
        {
            return cantidad >= cantidadSolicitada;
        }

        public bool SacarAlmacen(int cantidadSolicitada)
        {
            if (cantidad >= cantidadSolicitada)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Producto listo para enviarse.");
                cantidad -= cantidadSolicitada;
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Producto no disponible.");
                return false;
            }
        }
    }
}
