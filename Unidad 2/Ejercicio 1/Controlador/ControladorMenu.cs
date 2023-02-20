using System;
using System.Windows.Forms;
using Ejercicio_1.Objetos;

namespace Ejercicio_1.Controlador
{
    public class ControladorMenu
    {
        /// <summary>
        /// Funcion para iniciar el objeto y llenar sus propiedades
        /// </summary>
        public void CrearObjeto()
        {
            Telefono telefono = new Telefono("Galaxy S23 Ultra", "Samsung");
            Console.Write($"\n Ingrese los datos del teléfono... \n\n");

            Console.Write($" Código Operador: ");
            telefono.CodigoOperador = int.Parse(Console.ReadLine());

            while (telefono.CodigoOperador == 0)
            {
                MessageBox.Show("Error, el código de operador debe ser menor a 4...");

                Console.Write($" Código Operador: ");
                telefono.CodigoOperador = int.Parse(Console.ReadLine());
            }

            Console.Write($" Número de teléfono: ");
            telefono.NumeroTelefonico = Console.ReadLine();

            Persona persona = new Persona();
            Console.Write($"\n Ingrese los datos de la persona... \n\n");

            Console.Write($" Nombre de la persona: ");
            persona.Nombre = Console.ReadLine();
            VerificarVaciosPersona(persona);

            Console.WriteLine("\n * Marca: " + telefono.Marca);
            Console.WriteLine(" * Modelo: " + telefono.Modelo);
            Console.WriteLine(" * Nombre de la persona: " + persona.Nombre);

            Console.WriteLine("\n " + telefono.Llamar());
            Console.WriteLine("\n " + telefono.Llamar(persona.Nombre, telefono.CodigoOperador + " " + telefono.NumeroTelefonico));

            Salir();
        }

        /// <summary>
        /// Metodo para validar si la persona esta vacia
        /// </summary>
        private Persona VerificarVaciosPersona(Persona persona)
        {
            while (persona.Nombre == null)
            {
                MessageBox.Show($"El nombre de la persona no puede estar vacío!", "Nombre de persona vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                Console.Write($" Nombre de la persona: ");
                persona.Nombre = Console.ReadLine();
            }

            return persona;
        }

        /// <summary>
        /// Funcion para salir o continuar en el programa
        /// </summary>
        private void Salir()
        {
            int salir;

            Console.Write("\n ############################################################ \n");

            Console.Write("\n ¿Desea seguir en el programa? ");
            Console.Write("\n 1: SI ");
            Console.Write("\n 0: NO \n");
            Console.Write("\n Opcion: ");

            try 
            {
                salir = int.Parse(Console.ReadLine());

                while (salir < 0 || salir > 1)
                {
                    MessageBox.Show($"Error, opción {salir} no existe! 1 / 0", "Opción incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    Console.Clear();
                    Salir();
                }

                if (salir == 1)
                {
                    Console.Clear();
                    CrearObjeto();
                }
                else if (salir == 0)
                {
                    Environment.Exit(0);
                }
            }
            catch
            {
                MessageBox.Show($"La opción no puede estar vacía!", "Opción incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                Salir();
            }
        }
    }
}
