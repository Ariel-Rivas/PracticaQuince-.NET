using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace OperadoresLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Libro> libros = Libro.GetLibros();


            //Operadores matematicos

            var count = libros.Count();  //cantidad de libros

            var suma = libros.Sum(x => x.Precio); //suma los precios

            var maximo = libros.Max(x => x.Precio);// precio maximo

            var minimo = libros.Min(x => x.Precio);// precio minimo

            var media = libros.Average(x => x.Precio); //sacari el promedio

            //operadores miembro

            var toma = libros.Take(2);  //toma tanto elemetos como le digamos

            var salta = libros.Skip(5); //salta la cantidad de elementos que le digamos

            var tomaYSalta = libros.Skip(2).Take(3);

            var vuelta = libros.Reverse<Libro>(); //da vuelta de como esta ordenado

            var primero = libros.Where(x => x.Titulo.Length > 0).OrderBy(x => x.Precio).First();

            var primeroONulo = libros.FirstOrDefault(); //devuelve el primero

            var elementoEn = libros.ElementAt(4); //devuelve el elemento que le pasamos en los parametros

            var ultimo = libros.Last();// devuelve el ultimo

          //  var single = libros.Single(x => x.ISBN.Contains("22")); //devuelve el primero que cumpla esa condicion

            var alguno = libros.Any(); // si tiene algun elemento devuelve true sino false

            var condicionTodos = libros.All(x => x.Titulo.Length > 0); //si todos cumplen esa condicion devuelve true sino false

            var contiene = libros.Contains(new Libro    //si exite no pasa nada sino existe lo inserta.
            {
                FechaSalida = DateTime.Now.AddYears(-3),
                ISBN = "111111",
                Precio = 12.22M,
                Titulo = "El señor de los anillos"
            });


            foreach( var item in libros)
            {
                WriteLine("" + item.ISBN);
                ReadLine();
            }
        } 
        
    }
}