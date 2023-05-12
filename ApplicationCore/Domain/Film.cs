using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ApplicationCore.Domain
{

    public enum TypeFilm
    {
        Fiction,
        Action,
        Comedie,
        Autre
    }
    public class Film
    {
        [Key]
        public int FilmId { get; set; }
        public string Titre { get; set; }
        public double Duree { get; set; }
        public double prix { get; set; }
        public DateTime DateRealisation { get; set; }
        public TypeFilm TypeFilm { get; set; }
        public virtual ICollection<Projection> Projections { get; set; }





    }
}
