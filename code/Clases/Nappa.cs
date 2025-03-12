using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Clases
{
    internal class Nappa: Saiyajin
    {
        protected override void SuperarLimites(){
            Console.WriteLine("Nappa se enoja porque matan a vegeta");
        }
       
    }
}
