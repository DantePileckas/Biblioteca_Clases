using System;
using System.Collections.Generic;
using System.Text;

namespace BiblioEFCore
{
    class Persona
    {

        public Persona(string nombre, string apellido, string correo, string clave, TipoPersona tipoPersona)
        {
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;
            Clave = clave;
            oTipoPersona = tipoPersona;
        }

        public int IdPersona { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public TipoPersona oTipoPersona { get; set; }
        public bool Estado { get; set; }
    }
}
