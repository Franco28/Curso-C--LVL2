namespace Ejercicio_1.Objetos
{
    class Persona
    {
        /// <summary>
        /// Nombre de la persona
        /// </summary>
        private string NombrePersona { get; set; }

        /// <summary>
        /// Metodo nombre de la persona
        /// </summary>
        public string Nombre
        {
            get { return NombrePersona; }
            set
            {
                if (value != string.Empty)
                    NombrePersona = value;
                else
                    NombrePersona = null;
            }
        }
    }
}
