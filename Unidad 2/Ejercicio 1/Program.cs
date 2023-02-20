using System;
using Ejercicio_1.Controlador;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Telefono";
            Console.WriteLine("\n");

            var controlador = new ControladorMenu();
            controlador.CrearObjeto();
        }
    }
}
