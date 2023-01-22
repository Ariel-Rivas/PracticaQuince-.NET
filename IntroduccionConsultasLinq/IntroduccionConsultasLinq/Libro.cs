using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionConsultasLinq
{
    public class Libro
    { 
        public string ISBN { get; set;}
        public string Titulo { get; set;}
        public decimal Precio { get; set;}
        public DateTime FechaSalida { get; set;}

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
            return libros; 
        }



    }
}
