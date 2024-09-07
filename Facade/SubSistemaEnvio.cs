using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class SubSitemaEnvio
    {
        public void EnviarPedido()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("El envío va en camino.");
        }
    }
}
