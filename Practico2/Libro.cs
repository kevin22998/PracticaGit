using System;
using System.Collections.Generic;
using System.Text;

namespace Practico2
{
    class Libro
    {
        public string Titulo;
        public int IdAutor;
        public int AnioPublicacion;
        public int CantidadDeVentas;
       
       

        public Libro(string titulo, int idAutor, int anioPublicacion, int cantidadDeVentas)
        {
            Titulo = titulo;
            IdAutor = idAutor;
            AnioPublicacion = anioPublicacion;
            CantidadDeVentas = cantidadDeVentas;
        }
    }
}
