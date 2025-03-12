using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Clases
{
    internal class Vegeta: Saiyajin
    {
        protected override void SuperarLimites()
        {
            Console.WriteLine("Vegeta entrena con disciplina, superando sus propios límites. 💢");
        }

        protected override void LograrTransformacion()
        {
            Console.WriteLine("¡Vegeta alcanza el Super Saiyajin Blue Evolution! 🔵💥");
        }
    }
}
