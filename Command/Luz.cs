using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Luz
    {
        public bool Encendida { get; set; } = false;
        public void Encender()
        {
            Console.WriteLine("Luz encendida.");
            Encendida = true;
        }
        public void Apagar()
        {
            Console.WriteLine("Luz apagada.");
            Encendida = false;
        }
    }
}
