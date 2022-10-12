using System;
using System.Collections.Generic;
using System.Text;

namespace BiblioEFCore
{
    class EstadoPrestamo
    {
        public EstadoPrestamo(int idEstado, string nombre)
        {
            idEstadoPrestamo = idEstado;
            Nombre = nombre;
        }

        public int idEstadoPrestamo { get; set; }
        public string Nombre { get; set; }

    }
}
}
