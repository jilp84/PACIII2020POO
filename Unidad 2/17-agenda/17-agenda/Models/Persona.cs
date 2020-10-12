using System;
using System.Collections.Generic;
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
        public string PersonaNombres { get; set; }
        public string PersonaApellidos { get; set; }
        public string PersonaDireccion { get; set; }

        
    }
}
