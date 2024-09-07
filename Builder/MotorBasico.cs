using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Interfaces;

namespace Builder
{
    class MotorBasico : IMotor
    {
        public string especificaciones()
        {
            return "Motor de 4 cilindros";
        }
    }
}
