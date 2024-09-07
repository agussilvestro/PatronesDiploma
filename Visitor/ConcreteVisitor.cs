using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class ConcreteVisitor : IVisitor
    {
        public void Visit(ElementA elementA) => Console.WriteLine("ElementA visitado");
        public void Visit(ElementB elementB) => Console.WriteLine("ElementB visitado");
    }
}
