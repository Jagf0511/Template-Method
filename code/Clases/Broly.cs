using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Clases
{
    internal class Broly: Saiyajin
    {
        protected override void SuperarLimites()
        {
            Console.WriteLine("Broly pierde el control, liberando un poder inigualable. 😡💀");
        }

        protected override void LograrTransformacion()
        {
            Console.WriteLine("¡Broly alcanza el Super Saiyajin Legendario! 🟢🔥");
        }
        
    }
}
