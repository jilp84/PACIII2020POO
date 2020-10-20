using _17_agenda.Controllers;
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
    public partial class FrmPersonaDelete : MetroFramework.Forms.MetroForm
    {
        private Models.Persona p_persona;
        private readonly PersonaController persona;

        public FrmPersonaDelete(Models.Persona persona)
        {
            InitializeComponent();

            this.persona = new PersonaController();
            this.p_persona = persona;

            if (persona.PersonaGenero == "F")
            {
                rbtnMujer.Checked = true;
            }

            if (persona.PersonaGenero == "M")
            {
                rbtnHombre.Checked = true;
            }

            txtId.Text = persona.PersonaId.ToString();
            txtNombres.Text = persona.PersonaNombres;
            txtApellidos.Text = persona.PersonaApellidos;
            txtDireccion.Text = persona.PersonaDireccion;

            tabPrincipal.SelectTab(0);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                "¿Quiere borrar esta personas?",
                "Confirme la acción",
                MessageBoxButtons.YesNo
                );

            if (confirmResult == DialogResult.Yes)
            {
                if (persona.Delete(p_persona.PersonaId))
                {
                    MessageBox.Show("Persona borrada correctamente.");
                    persona.Dispose();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al borrar a la persona.");
                }
            }

        }
    }
}
