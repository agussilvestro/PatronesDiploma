using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class Meal
    {
        public void PrepararComida()
        {
            PrepararIngredientes();
            Cocinar();
            Servir();
        }

        public abstract void PrepararIngredientes();
        public abstract void Cocinar();
        public abstract void Servir();
    }
}
