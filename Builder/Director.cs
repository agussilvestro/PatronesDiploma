using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Interfaces;

namespace Builder
{
    internal class Director
    {
        public void Construye(IBuilder pConstructor)
        {
            pConstructor.ConstruyeLlantas();
            pConstructor.ConstruyeMotor();
            pConstructor.ConstruyeCarroceria();
        }
    }
}
