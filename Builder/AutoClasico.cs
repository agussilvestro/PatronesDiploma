using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Interfaces;

namespace Builder
{
    internal class AutoClasico:IBuilder
    {
        private Auto auto = new Auto();
        public void ConstruyeLlantas()
        {
            auto.ColocarLlantas(new Llantas12());
        }

        public void ConstruyeMotor()
        {
            auto.ColocarMotor(new MotorBasico());
        }

        public void ConstruyeCarroceria()
        {
            auto.ColocarCarroceria(new CarroceriaBasica());
        }

        public Auto ObtenProducto()
        {
            return auto;
        }
    }
}
