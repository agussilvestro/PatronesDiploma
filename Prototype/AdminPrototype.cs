using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class AdminPrototype
    {
        private Dictionary<string, IPrototype> prototipos = new Dictionary<string, IPrototype>();

        public AdminPrototype()
        {
            Valores valores = new Valores(10);
            prototipos.Add("Valores", valores);
        }

        public void AdicionarPrototipos(string pLlave, IPrototype pPrototype)
        {
            prototipos.Add(pLlave, pPrototype);
        }
        public object ObtenPrototipo(string pLlave)
        {
            return prototipos[pLlave].Clonar();
        }
    }
}
