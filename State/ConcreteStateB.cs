using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class ConcreteStateB : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("State B manejando solicitud.");
            context.SetState(new ConcreteStateA());
        }
    }
}
