using System;
using System.Collections.Generic;
using System.Text;

namespace BiblioEFCore
{
    class Prestamo
    {

        public Prestamo(Persona persona, Libro libro, DateTime fechaDevol, EstadoPrestamo estado)
        {
            oPersona = persona;
            oLibro = libro;
            FechaToma = DateTime.Now;
            FechaDevolucion = fechaDevol;
            oEstadoPrestamo = estado;
        }

        public int IdPrestamo { get; set; }
        public Persona oPersona { get; set; }
        public Libro oLibro { get; set; }
        public DateTime FechaToma { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public EstadoPrestamo oEstadoPrestamo { get; set; }

    }
}
