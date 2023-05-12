using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class Salle
    {
        [Key]
        public int SalleId { get; set; }
        [Display(Name = "Numéro de la salle oblgatoire")]
        public int Numero { get; set; }
        [Range(1, 50)]
        public int NbPlaces { get; set; }
        public virtual ICollection<Projection> Projections { get; set; }

        public virtual Cinema Cinema { get; set; }
        [ForeignKey("Cinema")]
        public int SalleFK { get; set; }

    }
}
