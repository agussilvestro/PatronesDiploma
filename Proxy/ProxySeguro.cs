using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class ProxySeguro : ISujeto
    {
        private Cocina cocina;
        public void Peticion(int pOpcion)
        {
            string password;
            Console.WriteLine("Dame el password:");
            password = Console.ReadLine();
            if (password == "1234")
            {
                if (cocina == null)
                {
                    Console.WriteLine("Activando sujeto");
                    cocina = new Cocina();
                }
                if (pOpcion == 1)
                {
                    cocina.RecetaSecreta();
                }
                if (pOpcion == 2)
                {
                    cocina.Cocinar(5);
                }
            }
            else
            {
                Console.WriteLine("Acceso denegado");
            }
        }
    }
}
