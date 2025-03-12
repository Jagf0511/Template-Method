using System;
namespace TemplateMethod.Clases
{

    class Program
    {
        static void Main(string[] args)
        {
            // Configurar la consola para soportar emojis
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("🔥 Goku se transforma:");
            Cliente.SimularTransformacion(new Goku());

            Console.WriteLine("🔥 Vegeta se transforma:");
            Cliente.SimularTransformacion(new Vegeta());

            Console.WriteLine("🔥 Broly se transforma:");
            Cliente.SimularTransformacion(new Broly());

            Console.WriteLine("🔥 Nappa se enoja:");
            Cliente.SimularTransformacion(new Nappa());
        }
    }
}
