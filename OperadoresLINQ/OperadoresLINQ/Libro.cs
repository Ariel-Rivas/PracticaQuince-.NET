using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresLINQ
{
    public class Libro
    {
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaSalida { get; set; }

        public static List<Libro> GetLibros()
        {
            List<Libro> libros = new List<Libro>();
            libros.Add(new Libro
            {
                FechaSalida = DateTime.Now.AddYears(-3),
                ISBN = "2454",
                Precio = 13.20m,
                Titulo = "Hombres y engranajes",


            });
            libros.Add(new Libro
            {
                FechaSalida = DateTime.Now.AddYears(-8),
                ISBN = "2455",
                Precio = 20.20m,
                Titulo = "Las mil y una noches",


            });
            libros.Add(new Libro
            {
                FechaSalida = DateTime.Now.AddYears(-2),
                ISBN = "2456",
                Precio = 45.20m,
                Titulo = "Efecto mariposa",


            });
            libros.Add(new Libro
            {
                FechaSalida = DateTime.Now.AddYears(-1),
                ISBN = "2457",
                Precio = 77.20m,
                Titulo = "Historia del siglo 20",


            });
            libros.Add(new Libro
            {
                FechaSalida = DateTime.Now.AddYears(-6),
                ISBN = "2458",
                Precio = 42.00m,
                Titulo = "Romeo y Julieta",


            });
            libros.Add(new Libro
            {
                FechaSalida = DateTime.Now.AddYears(-14),
                ISBN = "2459",
                Precio = 33.00m,
                Titulo = "Diego Maradona",


            });

            libros.Add(new Libro
            {
                FechaSalida = DateTime.Now.AddYears(-1),
                ISBN = "2460",
                Precio = 67.00m,
                Titulo = " Los locos",


            });
            return libros;
        }



    }
}

