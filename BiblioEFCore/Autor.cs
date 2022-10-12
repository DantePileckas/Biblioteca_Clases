using System;
using System.Collections.Generic;
using System.Text;

namespace BiblioEFCore
{
    class Autor
    {

        public Autor(string nombre)
        {
            Nombre = nombre;
        }
        public int IdAutor { get; set; }
        public string Nombre { get; set; }

    }
}
