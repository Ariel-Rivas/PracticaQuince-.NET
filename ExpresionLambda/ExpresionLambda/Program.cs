using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; 

namespace ExpresionLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Libro> libros = Libro.GetLibros();
            // usando cunltas linq
            //var titulosLibros =
            //  from L in libros
            // select L.Titulo;  

            //Usando expresion lambda
            var titulos = libros.Select(x => x.Titulo);
            var ISBNs = libros.Select(x => x.ISBN);
            var FechaSalida = libros.Where(x => x.FechaSalida > DateTime.Now.AddYears(-2)).Select(x => x.Titulo);
            var tituloCorto = libros.Where(x => x.Titulo.Length < 10)
                .Select(x => x.Titulo);
            var claseAnonima = libros.Select(x => new
            { 
                titulo2 = x.Titulo,
                FechaAuxiliar = x.FechaSalida

            });
            foreach (var item in claseAnonima)
            {
                WriteLine($"valor titulo2 : {item.titulo2} valor fecha :{item.FechaAuxiliar}");
            }
            ReadLine();
        }
    }
}

