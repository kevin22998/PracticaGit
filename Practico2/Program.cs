using System;
using System.Collections.Generic;
using System.Linq;

namespace Practico2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numerosRandom = new List<int>();
            var aleatorio = new Random();

            for (int i = 0; i < 100; i++)
            {
                numerosRandom.Add(aleatorio.Next(1, 100));
            }

            foreach (int i in numerosRandom)
            {
                Console.WriteLine(i);
            }


            List<Alumno> Alumnos = new List<Alumno>()
        {
            new Alumno("Eva", 20, 6),
            new Alumno("Ana", 18, 7),
            new Alumno("Rosa", 22, 5),
            new Alumno("Ricardo", 30, 9),
            new Alumno("Felipe", 45, 2),
            new Alumno("Pepe", 19, 3),
            new Alumno("Laia", 26, 10),
            new Alumno("Stephanie", 33, 6),
            new Alumno("Agustin", 50, 7),
            new Alumno("Mauricio", 31, 12)
        };


            List<Autor> Autores = new List<Autor>()
            {
                new Autor(1, "Miguel de Cervantes"),
                new Autor(2, "Charles Dickens"),
                new Autor(3, "J. R. R. Tolkien"),
                new Autor(4, "Antoine de Saint-Exupéry"),
                new Autor(5, "Cao Xueqin"),
                new Autor(6, "Lewis Car"),
                new Autor(7, "Agatha Christie"),
                new Autor(8, "C. S. Lewis"),
                new Autor(9, "Dan Brown"),
                new Autor(10, "J. D. Salinger"),
            };


            List<Libro> Libros = new List<Libro>()
            {
                new Libro("Don Quijote de la Mancha", 1, 1605, 500),
                new Libro("Historia de Dos Ciudades", 2, 1859, 200),
                new Libro("El Señor de los Anillos", 3, 1978, 150),
                new Libro("El Principito", 4, 1951, 140),
                new Libro("El Hobbit", 3, 1982, 100),
                new Libro("Sueño en el Pabellón Rojo", 5, 1792, 100),
                new Libro("Las Aventuras de Alicia en el País de las Maravillas", 6, 1865, 100),
                new Libro("Diez Negritos", 7, 1939, 100),
                new Libro("El León la Bruja y el Armario", 8, 1950, 85),
                new Libro("El Código Da Vinci", 9, 2003, 80),
                new Libro("El Guardián Entre el Centeno", 10, 1951, 65),
                new Libro("El Alquimista", 11, 1988, 65),
            };

            Console.WriteLine("Resultados:");
            Console.WriteLine("");
            //LLamar funciones:
            EjercicioA(numerosRandom);
          
        }

        //1A
        public static void EjercicioA(List<int> random)
        {
            int primero = random.First();
            Console.WriteLine("El primer numero es " + primero);
        }


        //1B
        public static void EjercicioB(List<int> random)
        {
            int ultimo = random.Last();
            Console.WriteLine("El ultimo numero es " + ultimo);
        }


        //1C
        public static void EjercicioC(List<int> random)
        {
            var divisibles = random.Where(i => i % 3 == 0).ToList();
            foreach (var item in divisibles)
            {
                Console.WriteLine("Los numeros divisibles entre 3 son: " + item); 
            }
        }


        //1D
        public static void EjercicioD(List<int> random)
        {
            int suma = random.Sum();
            Console.WriteLine("La suma de todos los elementos es: " + suma);
        }


        //1E
        public static void EjercicioE(List<int> random)
        {
            int mayor = random.Max();
            Console.WriteLine("El mayor numero es: " + mayor);
        }


        //1F
        public static void EjercicioF(List<int> random)
        {
            int menor = random.Min();
            Console.WriteLine("El menor numero es: " + menor);
        }


        //1G
        public static void EjercicioG(List<int> random)
        {
            List<int> numerosAlCuadrado = random.Select(x => x * x).ToList();
            foreach (int numero in numerosAlCuadrado)
            {
                Console.WriteLine(numero);
            }
        }


        //1H
        public static void EjercicioH(List<int> random)
        {
            List<int> numerosMayoresCincuenta = random.Where(x => x > 50).ToList();
            foreach (int numero in numerosMayoresCincuenta)
            {
                Console.WriteLine(numero);
            }
        }


        //1I
        public static void EjercicioI(List<int> random)
        {
            var promedioMayoresCincuenta = random.Where(x => x > 50).Average();
            Console.WriteLine(promedioMayoresCincuenta);
        }


        //1J
        public static void EjercicioJ(List<int> random)
        {
            List<int> descendente = random.OrderByDescending(x => x).ToList();
            foreach (int numero in descendente)
            {
                Console.WriteLine(numero);
            }
        }


        //1K
        public static void EjercicioK(List<int> random)
        {
            List<int> ascendente = random.OrderBy(x => x).ToList();
            foreach (int numero in ascendente)
            {
                Console.WriteLine(numero);
            }
        }


        //1L
        public static void EjercicioL(List<int> random)
        {
            var numerosSinRepetir = random.Distinct();
            foreach (int numero in numerosSinRepetir)
            {
                Console.WriteLine(numero);
            }
        }


        //1M
        public static void EjercicioM(List<int> random)
        {
            var sumaNumerosSinRepetir = random.Distinct().Sum();
            Console.WriteLine(sumaNumerosSinRepetir);
        }


        //1N
        public static void EjercicioN(List<int> random)
        {
            int numeroCincuenta = random.First(x => x == 50);
            if (numeroCincuenta == 50)
            {
                Console.WriteLine("SI");
            } else
            {
                Console.WriteLine("NO");
            }
        }


        //1O
        public static void EjercicioO(List<int> random)
        {
            var primeros = random.Take(33);
            foreach (int numero in primeros)
            {
                Console.WriteLine(numero);
            }
        }


        //1P
        public static void EjercicioP(List<int> random)
        {
            var ultimos = random.TakeLast(20);
            foreach (int numero in ultimos)
            {
                Console.WriteLine(numero);
            }
        }


        //1Q
        public static void EjercicioQ(List<int> random)
        {
            if (random.All(x => x > 1))
            {
                Console.WriteLine("SI");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }


        //1R
        public static void EjercicioR(List<int> random)
        {
            var cantidadRepeticiones = random.GroupBy(x => x).Where(s => s.Count() > 1).ToDictionary(x => x.Key, y => y.Count());
            foreach (var Key in cantidadRepeticiones)
            {
                Console.WriteLine(Key.Key.ToString() + ": " + Key.Value);
            }
        }


        //Ejercicios Alumnos

        public static void EjercicioAlumnosA(List<Alumno> alumnos)
        {
            var maximo = alumnos.Max(x => x.Nota);
            var notaMasAlta = alumnos.Where(n => n.Nota == maximo).Select(x => x.Nombre);
            foreach (string alumno in notaMasAlta)
            {
                Console.WriteLine(alumno);
            }
        }


        public static void EjercicioAlumnosB(List<Alumno> alumnos)
        {
            var minimo = alumnos.Min(x => x.Edad);
            var alumnoMasJoven = alumnos.Where(n => n.Edad == minimo).Select(x => x.Nombre);
            foreach (string alumno in alumnoMasJoven)
            {
                Console.WriteLine(alumno);
            }
        }


        public static void EjercicioAlumnosC(List<Alumno> alumnos)
        {
            var promedioEdad = alumnos.Average(edad => edad.Edad);
            Console.WriteLine(promedioEdad);
        }


        public static void EjercicioAlumnosD(List<Alumno> alumnos)
        {
            bool algunReprobado = alumnos.Any(n => n.Nota < 6);
            if (algunReprobado == true)
            {
                Console.WriteLine("SI");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }


        public static void EjercicioAlumnosE(List<Alumno> alumnos)
        {
            var aprobadosMayorTreinta = alumnos.Where(n => n.Nota > 6).Where(e => e.Edad > 30).Select(alumno => alumno.Nombre);
            foreach (string alumno in aprobadosMayorTreinta)
            {
                Console.WriteLine(alumno);
            }
        }


        public static void EjercicioAlumnosF(List<Alumno> alumnos)
        {
            var aprobadoSuspendido = alumnos.GroupBy(x => x.Nota > 6);
            foreach (var grupo in aprobadoSuspendido)
            {
                Console.WriteLine(grupo.Key);
                foreach (var alumno in grupo)
                {
                    Console.WriteLine(alumno.Nombre);
                }
                Console.WriteLine("");
            }
        }


        public static void EjercicioAlumnosG(List<Alumno> alumnos)
        {
            var alumnoSegunLargoNombre = alumnos.OrderByDescending(x => x.Nombre.Length);
            foreach (var nombre in alumnoSegunLargoNombre)
            {
                Console.WriteLine(nombre.Nombre);
            }
        }


        public static void EjercicioAlumnosH(List<Alumno> alumnos)
        {
            var agrupados = alumnos.GroupBy(x => x.Nombre.Length).Where(valor => valor.Sum(e => e.Edad) > 60);
            foreach (var grupo in agrupados)
            {
                Console.WriteLine(grupo.Key);
                foreach (var alumno in grupo)
                {
                    Console.WriteLine(alumno.Nombre);
                }
                Console.WriteLine("");
            }
        }


        public static void EjercicioAlumnosI(List<Alumno> alumnos)
        {
            var ordenado = alumnos.OrderBy(n => n.Nombre.Length).ThenByDescending(e => e.Edad);
            foreach (var alumno in ordenado)
            {
                Console.WriteLine(alumno.Nombre);
            }
        }


        //Ejercicios Autores y Libros



        public static void EjerciciosAutoresLibrosA(List<Libro> libros)
        {
            var tresLibrosMasVentas = libros.OrderBy(x => x.CantidadDeVentas).TakeLast(3);
            foreach (var libro in tresLibrosMasVentas)
            {
                Console.WriteLine(libro.Titulo);
            }
        }


        public static void EjerciciosAutoresLibrosB(List<Libro> libros)
        {
            var tresLibrosMenosVentas = libros.OrderBy(x => x.CantidadDeVentas).Take(3);
            foreach (var libro in tresLibrosMenosVentas)
            {
                Console.WriteLine(libro.Titulo);
            }
        }

        //Este no logre que funcionara
        public static void EjerciciosAutoresLibrosC(List<Libro> libros)
        {
            int year = DateTime.Now.Year;
            var librosMenosCincuentaAnios = libros.Where(x => (x.AnioPublicacion - year) < 50).Select(n => n.Titulo);
            foreach (var libro in librosMenosCincuentaAnios)
            {
                Console.WriteLine(libro);
            }
        }



        public static void EjerciciosAutoresLibrosD(List<Libro> libros)
        {
            var libroMasViejo = libros.OrderBy(x => x.AnioPublicacion).Take(1);
            foreach (var libro in libroMasViejo)
            {
                Console.WriteLine(libro.Titulo);
            }
        }

        public static void EjerciciosAutoresLibrosE(List<Libro> libros, List<Autor> autores)
        {
            var autoresConLibros = libros.Join(autores,
                                               libro => libro.IdAutor,
                                               autor => autor.IdAutor,
                                               (libro, autor) => new { IdAutor = autor.IdAutor, NombreAutor = autor.Nombre, TituloLibro = libro.Titulo }).ToList();


            var autoresConLibrosEl = autoresConLibros.Where(autorConLibro => autorConLibro.TituloLibro.StartsWith("El"))
                                                     .Select(autor => autor.NombreAutor)
                                                     .Distinct()
                                                     .ToList();

            foreach (var nombreAutor in autoresConLibrosEl)
            {
                Console.WriteLine(nombreAutor);
            }
        }

        //Ni idea como se resuelve
        public static void EjerciciosAutoresLibrosF(List<Libro> libros, List<Autor> autores)
        {
            var autoresConLibros = libros.Join(autores,
                                               libro => libro.IdAutor,
                                               autor => autor.IdAutor,
                                               (libro, autor) => new { IdAutor = autor.IdAutor, NombreAutor = autor.Nombre, TituloLibro = libro.Titulo, IdAutorLibro = libro.IdAutor }).ToList();


            var autorConMasLibrosPublicados = autoresConLibros.GroupBy(autorConLibro => autorConLibro.NombreAutor)
                                                     .OrderByDescending(autorConLibro => autorConLibro.Count())
                                                     .FirstOrDefault();
                                                     





            Console.WriteLine(autorConMasLibrosPublicados.Key);
        }


        public static void EjerciciosAutoresLibrosG(List<Libro> libros, List<Autor> autores)
        {
            var autoresConLibros = libros.Join(autores,
                                               libro => libro.IdAutor,
                                               autor => autor.IdAutor,
                                               (libro, autor) => new { IdAutor = autor.IdAutor, NombreAutor = autor.Nombre, TituloLibro = libro.Titulo })
                                         .GroupBy(autor => autor.NombreAutor)
                                         .ToList();


            var autorEscribioMas = autoresConLibros.OrderByDescending(grupo => grupo.Count()).FirstOrDefault();






            Console.WriteLine();
        }


    }
}
