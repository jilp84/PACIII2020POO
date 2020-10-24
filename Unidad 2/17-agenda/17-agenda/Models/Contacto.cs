using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_agenda.Models
{
    public class Contacto
    {
        [Key]
        public int ContactoId { get; set; }

        [MaxLength(40)]
        public string ContactoDescripcion { get; set; }

        [MaxLength(15)]
        public string Tipo { get; set; }

        [Browsable(false)]
        public int PersonaId { get; set; }

        [ForeignKey("PersonaId")]
        [Browsable(false)]
        public virtual Persona Persona { get; set; }


    }
}
