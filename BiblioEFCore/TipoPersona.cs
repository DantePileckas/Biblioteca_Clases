using System;
using System.Collections.Generic;
using System.Text;

namespace BiblioEFCore
{
    class TipoPersona
    {
        public TipoPersona(int idTipoPersona, string nombre)
        {
            IdTipoPersona = idTipoPersona;
            Nombre = nombre;
        }

        public int IdTipoPersona { get; set; }
        public string Nombre { get; set; }

    }
}
