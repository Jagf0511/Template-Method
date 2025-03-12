using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Clases
{
    internal class SinPatron
    {
        class Goku
        {
            public void Transformarse()
            {
                Console.WriteLine("Goku está aumentando su Ki... ⚡🔥");
                Console.WriteLine("Goku supera sus límites con entrenamiento. 🏋️‍♂️");
                Console.WriteLine("¡Goku se transforma en Super Saiyajin! 🔥⚡");
                Console.WriteLine("Goku muestra su poder a todos. 💥");
            }
        }

        class Vegeta
        {
            public void Transformarse()
            {
                Console.WriteLine("Vegeta está aumentando su Ki... ⚡🔥");
                Console.WriteLine("Vegeta supera sus límites con orgullo. 💪");
                Console.WriteLine("¡Vegeta se transforma en Super Saiyajin Blue! 🔵⚡");
                Console.WriteLine("Vegeta muestra su poder a todos. 💥");
            }
        }
    }
}
