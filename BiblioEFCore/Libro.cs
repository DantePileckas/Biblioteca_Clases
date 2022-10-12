using System;
using System.Collections.Generic;
using System.Text;

namespace BiblioEFCore
{
    class Libro
    {
        public Libro(string titulo, Autor autor, Editorial editorial, int ejemplares, bool estado)
        {
            Titulo = titulo;
            oAutor = autor;
            oEditorial = editorial;
            Ejemplares = ejemplares;
            Estado = estado;
        }

        public int IdLibro { get; set; }
        public string Titulo { get; set; }
        public Autor oAutor { get; set; }
        public Editorial oEditorial { get; set; }
        public int Ejemplares { get; set; }
        public bool Estado { get; set; }
    }

}
}
