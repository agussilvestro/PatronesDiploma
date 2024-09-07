using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class SaladMeal : Meal
    {
        public override void PrepararIngredientes()
        {
            Console.WriteLine("Preparando vegetales vegetables y aderezos.");
        }

        public override void Cocinar()
        {
            Console.WriteLine("Mezclando ingredientes con el aderezo.");
        }

        public override void Servir()
        {
            Console.WriteLine("Sirviendo ensalada en bowl.");
        }
    }
}
