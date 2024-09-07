using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    internal class FlyweightFactory
    {
        private List<IFlyweight> flyweights = new List<IFlyweight>();
        private int conteo = 0;

        public int Conteo { get => conteo; set => conteo = value; }

        public int Adicionat(string pNombre)
        {
            bool existe = false;
            foreach (IFlyweight flyweight in flyweights)
            {
                if (flyweight.ObtenerNombre() == pNombre)
                {
                    existe = true;
                }
            }
            if (existe)
            {
                Console.WriteLine("El objeto existe");
                return -1;
            }
            else
            {
                Receta miReceta = new Receta();
                miReceta.ColocarNombre(pNombre);
                flyweights.Add(miReceta);
                conteo = flyweights.Count;
                return conteo - 1;
            }
        }
        public IFlyweight this[int index]
        {
            get { return flyweights[index]; }
        }
    }
}
