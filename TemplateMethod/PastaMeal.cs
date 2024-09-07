using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class PastaMeal : Meal
    {
        public override void PrepararIngredientes()
        {
            Console.WriteLine("Preparando pasta y los ingredientes de la salsa.");
        }

        public override void Cocinar()
        {
            Console.WriteLine("Cocinando pasta y preparando salsa.");
        }

        public override void Servir()
        {
            Console.WriteLine("Sirviendo pasta en el plato.");
        }
    }
}
