using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Cocina
    {
        public void RecetaSecreta()
        {
            Console.WriteLine("Pan-Aceite de oliva-Especias-Jamon-Queso");
        }
        public void Cocinar(int n)
        {
            Console.WriteLine("Cocinando {0} recetas", n);
        }
    }
}
