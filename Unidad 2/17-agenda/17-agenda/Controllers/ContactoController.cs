using _17_agenda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_agenda.Controllers
{
    public class ContactoController
    {
        private readonly AgendaContext db;

        public ContactoController() 
        {

            db = new AgendaContext();
        
        }

        public List<Contacto> GetContactos(Persona persona) 
        {
            List<Contacto> contactos = new List<Contacto>();

            contactos = db.Contactos.Where(c => c.PersonaId == persona.PersonaId).ToList();

            return contactos;
        }

        public bool Add(Contacto contacto)
        {

            try
            {
                db.Contactos.Add(contacto);
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
