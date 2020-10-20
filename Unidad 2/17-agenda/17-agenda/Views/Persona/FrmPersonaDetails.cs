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
    public partial class FrmPersonaDetails : MetroFramework.Forms.MetroForm
    {
        public FrmPersonaDetails(Models.Persona persona)
        {
            InitializeComponent();

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
    }
}
