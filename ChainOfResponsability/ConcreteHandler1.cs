using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    public class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(string request)
        {
            if (request == "A")
                Console.WriteLine("ConcreteHandler1 manejo la solicitud A");
            else
                _nextHandler?.HandleRequest(request);
        }
    }
}
