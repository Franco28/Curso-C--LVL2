namespace Ejercicio_1.Objetos
{
    class Telefono
    {
        /// <summary>
        /// Constructor de Telefono
        /// </summary>
        /// <param name="modelo"></param>
        /// <param name="marca"></param>
        public Telefono(string modelo, string marca) { 
            this.Marca = marca;
            this.Modelo = modelo;
        }   

        /// <summary>
        /// Modelo del telefono
        /// </summary>
        public string Modelo { get; }

        /// <summary>
        /// Marca del telefono
        /// </summary>
        public string Marca { get; }

        /// <summary>
        /// Numero de telefono
        /// </summary>
        public string NumeroTelefonico { get; set; }

        /// <summary>
        /// Codigo de operador
        /// </summary>
        private int codOperador;

        /// <summary>
        /// Metodo de codigo de operador
        /// </summary>
        public int CodigoOperador
        {
            get { return codOperador; }
            set { 
                    if (value > 0 && value < 4)
                        codOperador = value;
                    else 
                        codOperador = 0;
            }
        }

        /// <summary>
        /// Metodo mensaje realizar llamada
        /// </summary>
        public string Llamar()
        {
            return "Realizando llamada...";
        }

        /// <summary>
        /// Metodo mensaje llamando a contacto
        /// </summary>
        /// <param name="persona"></param>
        /// <param name="contacto"></param>
        public string Llamar(string persona, string contacto)
        {
            return "Llamando a " + persona + " número " + contacto;
        }
    }
}
