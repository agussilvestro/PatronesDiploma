using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Interfaces;

namespace Builder
{
    class Llantas12 : ILlantas
    {
        public string informacion()
        {
            return "Llantas de 12 pulgadas";
        }
    }
}
