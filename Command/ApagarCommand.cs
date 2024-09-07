using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class ApagarCommand : ICommand
    {
        private readonly Luz _light;

        public ApagarCommand(Luz light) => _light = light;

        public void Execute() => _light.Apagar();
    }
}
