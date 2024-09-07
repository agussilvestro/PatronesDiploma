using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class ProxySencillo : ISujeto
    {
        private Cocina cocina;
        public void Peticion(int pOpcion)
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
    }
}
