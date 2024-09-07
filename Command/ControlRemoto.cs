using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class ControlRemoto
    {
        private ICommand _command;

        public void SetCommand(ICommand command) => _command = command;

        public void PressButton() => _command.Execute();
    }
}
