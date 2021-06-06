namespace AlkemyAPI.Dtos
{
    using AlkemyAPI.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public class PeliculaReadDtos
    {
        public PeliculaReadDtos()
        {
            Generoes = new HashSet<Genero>();
            Personajes = new HashSet<Personaje>();
        }
        public int ID_PELICULA { get; set; }
        public string TITULO { get; set; }
        public DateTime? FECHA_CREACION { get; set; }
        public byte? CALIFICACION { get; set; }
        public virtual ICollection<Genero> Generoes { get; set; }
        public virtual ICollection<Personaje> Personajes { get; set; }
    }
}

