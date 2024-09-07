using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class SistemaCompra
    {
        public bool Comprar()
        {
            string dato = "";
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Ingrese número de tarjeta: ");
            dato = Console.ReadLine();

            if (dato == "1234")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Pago aceptado.");
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Pago rechazado.");
                return false;
            }
        }
    }
}
