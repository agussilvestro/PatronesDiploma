using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Valores:IPrototype
    {
        private double sumatoria;
        private int m = 1;

        public int M { get => m; set => m = value; }
        public double Sumatoria { get => sumatoria; set => sumatoria = value; }

        public Valores(int pM)
        {
            m = pM;
            for (int i = 0; i < 90; i++)
            {
                sumatoria += Math.Sin(i * 0.0175);
            }
        }
        public override string ToString()
        {
            return string.Format("{0}", sumatoria * m);
        }
        public object Clonar()
        {
            Valores clon = new Valores();
            clon.M = m;
            clon.sumatoria = sumatoria;
            return clon;
        }
    }
}
