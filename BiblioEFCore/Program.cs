using System;
using System.Collections.Generic;

namespace BiblioEFCore
{
    class Program
    {
        static void Main(string[] args)
        {

            TipoPersona lector = new TipoPersona(1, "lector");
            TipoPersona admin = new TipoPersona(2, "Admin");

            Persona persona1 = new Persona("María", "Lee", "marialee@gmail.com", "123", lector);
            Persona persona2 = new Persona("Jaun", "Admin", "juanAdmin@gmail.com", "321", admin);

            Autor autor1 = new Autor("Norma Huidobro");
            Autor autor2 = new Autor("Claudia Piñeyro");

            Editorial editorial1 = new Editorial("MundoLectura");
            Editorial editorial2 = new Editorial("Lectura");

            EstadoPrestamo estado1 = new EstadoPrestamo(1, "PENDIENTE");
            EstadoPrestamo estado2 = new EstadoPrestamo(2, "DEVUELTO");

            Libro libro1 = new Libro("Sospechoso viste de negro", autor1, editorial1, 30, true);
            Libro libro2 = new Libro("Tuya", autor2, editorial2, 30, true);

            Prestamo prestamo = new Prestamo(persona1, libro1, new DateTime(2022,11, 01), estado1);

            List<Libro> ListaLibros = new List<Libro>();
            ListaLibros.Add(libro1);
            ListaLibros.Add(libro2);

        }
    }
}
