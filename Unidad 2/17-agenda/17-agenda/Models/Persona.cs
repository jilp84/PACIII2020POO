using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_agenda.Models
{
    public class Persona
    {
        [Key]
        public int PersonaId { get; set; }

        [MaxLength(40)]
        public string PersonaNombres { get; set; }
        
        [MaxLength(40)]
        public string PersonaApellidos { get; set; }
        
        [MaxLength(150)]
        public string PersonaDireccion { get; set; }
        
        [MaxLength(1)]
        public string PersonaGenero { get; set; }

        [Browsable(false)]
        public virtual ICollection<Contacto> Contactos { get; set; }
        
    }
}
