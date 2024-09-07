using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Interfaces;

namespace Builder
{
    internal class AutoDeportivo:IBuilder
    {
        private Auto auto = new Auto();
        public void ConstruyeLlantas()
        {
            auto.ColocarLlantas(new LlantasSuper());
        }

        public void ConstruyeMotor()
        {
            auto.ColocarMotor(new MotorGrande());
        }

        public void ConstruyeCarroceria()
        {
            auto.ColocarCarroceria(new CarroceriaEspecial());
        }

        public Auto ObtenProducto()
        {
            return auto;
        }
    }
}
