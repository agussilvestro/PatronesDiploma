using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Interfaces;

namespace Builder
{
    class CarroceriaEspecial : ICarroceria
    {
        public string caracteristicas()
        {
            return "Carroceria de fibra de carbono";
        }
    }
}
