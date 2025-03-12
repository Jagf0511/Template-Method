using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Clases
{
    internal class Goku: Saiyajin
    {
       
        protected override void SuperarLimites()
        {
            Console.WriteLine("Goku empuja su poder al máximo, recordando sus batallas. 💪🔥");
        }

        protected override void LograrTransformacion()
        {
            Console.WriteLine("¡Goku se transforma en Ultra Instinto! ⚡👊");
        }
    }
}
