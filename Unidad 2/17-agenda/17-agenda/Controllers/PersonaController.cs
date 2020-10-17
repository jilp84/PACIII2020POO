using _17_agenda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_agenda.Controllers
{
    public class PersonaController
    {
        private readonly AgendaContext db;

        public PersonaController() 
        {
            db = new AgendaContext();

        }

        public List<Persona> GetPersonas(string Search) 
        {
            List<Persona> personas = new List<Persona>();

            personas = db.Personas.Where(p => p.PersonaId.ToString().Contains(Search) ||
                                              p.PersonaNombres.Contains(Search) ||
                                              p.PersonaApellidos.Contains(Search)).ToList();

            return personas;
        }

        public bool Add(Persona persona) 
        {
            try
            {
                db.Personas.Add(persona);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }

            
        }


    }
}
