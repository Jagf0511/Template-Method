# 🏛️ Exposición: Template Method en Arquitectura de Software

## 📌 Información General
**Materia:** Arquitectura de Software  
**Profesor:** César López  
**Equipo:** Carolina Valdés & Julián Guisao  

---

## 🎭 ¿De qué trata nuestra exposición?
En esta exposición abordamos **Template Method**, un patrón de diseño de comportamiento que define el esqueleto de un algoritmo en una superclase y permite que las subclases redefinan ciertos pasos sin cambiar la estructura general del algoritmo. 

Explicamos su utilidad, implementación y beneficios dentro de la arquitectura de software. Además, acompañamos la explicación con código y diapositivas que ilustran su uso en el mundo real. 📜💡

---

## 📂 Estructura del Repositorio

📁 **code/** ➝ Contiene el código fuente de la implementación  
&nbsp;&nbsp;&nbsp;&nbsp;📁 **clases/** ➝ Ejemplo práctico del patrón Template Method en **C#**, basado en una analogía con **Dragon Ball** y los **Saiyajin** 🐉🔥  

📁 **slides/** ➝ Presentación utilizada en la exposición 🎤🎞️  

📄 **README.md** ➝ Este archivo con toda la información clave 👀

---

## 🚀 ¿Por qué Template Method?
- 🔹 **Reutilización de código**: Evita la duplicación y mejora la organización.
- 🔹 **Fuerza una estructura común**: Define un flujo base en la superclase.
- 🔹 **Flexibilidad**: Permite personalización en subclases sin alterar la lógica principal.

---

## ⚠️ Desventajas del Template Method
- ⚡ **Falta de flexibilidad en la estructura**: La superclase define un flujo rígido que puede ser difícil de modificar en proyectos grandes.
- ⚡ **Aumento de complejidad**: Si el algoritmo base es muy grande, las subclases pueden volverse difíciles de mantener.
- ⚡ **Posible sobrecarga en subclases**: Si se requieren muchas personalizaciones, puede resultar en la creación de múltiples subclases, lo que complica la estructura del código.

---

## 🎯 ¿Qué encontrarás en nuestra exposición?
✅ Explicación teórica del patrón Template Method.  
✅ Diagrama UML para entender mejor su estructura.  
✅ Implementación en código con ejemplos prácticos en **C#**.  
✅ Comparaciones con otros patrones de diseño.  
✅ Aplicaciones en la arquitectura de software moderna.  

---

## 🐉 Ejemplo de Código: Saiyajin y Template Method
Para ilustrar el patrón, usamos la analogía de los **Saiyajin** en **Dragon Ball**. 
La superclase define el proceso general de transformación, mientras que las subclases representan distintas evoluciones de personajes icónicos.

📂 **clases/** contiene:
- `Saiyajin.cs` (Clase base con Template Method)
- `Goku.cs` (Implementación de Goku como Super Saiyajin)
- `Vegeta.cs` (Implementación de Vegeta y su transformación)
- `Broly.cs` (Implementación de Broly con su propio estilo de transformación)
- `Nappa.cs` (Ejemplo de Saiyajin sin transformación avanzada)
- `Cliente.cs` (Clase que utiliza las transformaciones)
- `SinPatron.cs` (Ejemplo de código sin aplicar el patrón Template Method)
- `Program.cs` (Ejecución del ejemplo)

---

## 📌 Instrucciones para Ejecutar el Código
1. Clonar este repositorio:
   ```bash
   git clone https://github.com/Jagf0511/Template-Method
   ```
2. Ingresar a la carpeta del código:
   ```bash
   cd code/clases
   ```
3. Compilar y ejecutar el código en C#:
   ```bash
   dotnet run
   ```

---

## 🎤 ¡Gracias por tu atención!
Si tienes preguntas o quieres discutir más sobre Template Method, no dudes en comentarlo. 📢😃

