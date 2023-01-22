using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; 

namespace IntroduccionConsultasLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Libro> libros = Libro.GetLibros();
            var titulosLibros =
                from L in libros
                select L.Titulo;

            foreach ( var titulo in titulosLibros)
            {
                WriteLine(titulo);
            }
            ReadLine(); 
        }
    }
}
