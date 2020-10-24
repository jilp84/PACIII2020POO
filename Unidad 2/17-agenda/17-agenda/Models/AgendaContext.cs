using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_agenda.Models
{
    public class AgendaContext : DbContext
    {
        public AgendaContext() : base(@"Data Source = DESKTOP-AJ80QGS;
                                        Initial Catalog = AgendaEF;
                                        User Id = sa;
                                        Password = 1234;")
        {
        
        }

        public virtual DbSet<Persona> Personas { get; set; }
        public virtual DbSet<Contacto> Contactos { get; set; }


    }
}
