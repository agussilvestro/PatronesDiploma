using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Interfaces;

namespace Builder
{
    class LlantasSuper : ILlantas
    {
        public string informacion()
        {
            return "Llantas de 18 pulgadas con rines de aluminio";
        }
    }
}
