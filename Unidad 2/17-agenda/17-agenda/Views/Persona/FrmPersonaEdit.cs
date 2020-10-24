using _17_agenda.Controllers;
using _17_agenda.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17_agenda.Views.Persona
{
    public partial class FrmPersonaEdit : MetroFramework.Forms.MetroForm
    {
        private Models.Persona p_persona;
        private readonly PersonaController persona;

        private ContactoController contacto;

        public FrmPersonaEdit(Models.Persona persona)
        {
            InitializeComponent();

            this.persona = new PersonaController();
            this.p_persona = persona;

            ActualizarDatos();

            if (p_persona.PersonaGenero == "F")
            {
                rbtnMujer.Checked = true;
            }

            if (p_persona.PersonaGenero == "M")
            {
                rbtnHombre.Checked = true;
            }

            txtId.Text = p_persona.PersonaId.ToString();
            txtNombres.Text = p_persona.PersonaNombres;
            txtApellidos.Text = p_persona.PersonaApellidos;
            txtDireccion.Text = p_persona.PersonaDireccion;

            tabPrincipal.SelectTab(0);

        }

        private void ActualizarDatos() 
        {
            contacto = new ContactoController();
            var cont = contacto.GetContactos(p_persona);
            dgDatos.DataSource = cont;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            persona.Dispose();
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String genero = "";

            if (rbtnMujer.Checked == true)
            {
                genero = "F";
            }
            if (rbtnHombre.Checked == true)
            {
                genero = "M";
            }

            _17_agenda.Models.Persona p = new _17_agenda.Models.Persona
            {
                PersonaId = p_persona.PersonaId,
                PersonaApellidos = txtApellidos.Text,
                PersonaDireccion = txtDireccion.Text,
                PersonaGenero = genero,
                PersonaNombres = txtNombres.Text
            };

            if (persona.Edit(p))
            {
                MessageBox.Show("Persona editada correctamente.");
                persona.Dispose();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error para guardar a la persona.");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var contacto = new Contacto 
            {
                ContactoDescripcion = txtContacto.Text,
                Tipo = cmbTipoContacto.Text,
                PersonaId = p_persona.PersonaId
            };

            if (this.contacto.Add(contacto))
            {                
                ActualizarDatos();
            }
            else
            {
                MessageBox.Show("Error al agregar el contacto");
            }

        }
    }
}
