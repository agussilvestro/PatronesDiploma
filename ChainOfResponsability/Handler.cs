using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    public abstract class Handler
    {
        protected Handler _nextHandler;

        public void SetNext(Handler nextHandler) => _nextHandler = nextHandler;

        public abstract void HandleRequest(string request);
    }
}
