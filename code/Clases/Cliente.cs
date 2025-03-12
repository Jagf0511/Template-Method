using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Clases
{

    class Cliente
    {
        public static void SimularTransformacion(Saiyajin saiyajin)
        {
            saiyajin.Transformarse();
            Console.WriteLine();
        }
    }
}
