using System;
using System.Collections.Generic;
using System.Text;

namespace BiblioEFCore
{
    class Editorial
    {
        public Editorial(String nombre)
        {
            Nombre = nombre;
        }

        public int IdEditorial { get; set; }
        public string Nombre { get; set; }
    }
}
