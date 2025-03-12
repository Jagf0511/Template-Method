using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Clases
{
    public abstract class Saiyajin
    {
        // Método plantilla que define el proceso de transformación.
        public void Transformarse()
        {
            AumentarKi(); //paso 1
            SuperarLimites(); // paso 2
            LograrTransformacion(); // paso 3
            MostrarPoder(); // paso 4
        }

        // Métodos concretos (todos los Saiyajin hacen esto).//
        protected void AumentarKi()
        {
            Console.WriteLine($"{this.GetType().Name} está aumentando su Ki... ⚡🔥");
        }

        protected void MostrarPoder()
        {
            Console.WriteLine($"{this.GetType().Name} muestra su poder a todos. 💥");
        }
        ///---------------------------------------------------------------------------/ 
        

        /// ---------------------------------------------------------------------------/
        // Métodos abstractos (cada Saiyajin los implementa a su manera).
        protected abstract void SuperarLimites();

        /// ---------------------------------------------------------------------------/ 

        /// ---------------------------------------------------------------------------/
        // Métodos virtuales (opcional sobrescribirlos) ESTO ES UN HOOK
        protected virtual void LograrTransformacion()
        {
            Console.WriteLine($"{this.GetType().Name} no tiene transformación especial. ❌");
        }
        /// ---------------------------------------------------------------------------/
    }

}
