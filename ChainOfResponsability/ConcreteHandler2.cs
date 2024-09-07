using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    public class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(string request)
        {
            if (request == "B")
                Console.WriteLine("ConcreteHandler2 manejo la solicitud B");
            else
                _nextHandler?.HandleRequest(request);
        }
    }
}
