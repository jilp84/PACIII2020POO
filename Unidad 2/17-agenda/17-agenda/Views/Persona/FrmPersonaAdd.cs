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
using _17_agenda.Models;

namespace _17_agenda.Views.Persona
{
    public partial class FrmPersonaAdd : MetroFramework.Forms.MetroForm
    {
        private readonly PersonaController persona;

        public FrmPersonaAdd()
        {
            InitializeComponent();

            persona = new PersonaController();

            txtApellidos.Text = "A";
            txtDireccion.Text = "A";
            txtNombres.Text = "A";

            txtApellidos.Text = "";
            txtDireccion.Text = "";
            txtNombres.Text = "";

        }

        private void txtNombres_Validating(object sender, CancelEventArgs e)
        {
            if (txtNombres.Text == "")
            {
                e.Cancel = true;
                txtNombres.Select(0, txtNombres.Text.Length);
                errorProvider1.SetError(txtNombres, "Debe ingresar los nombres.");
            }
        }

        private void txtNombres_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtNombres, "");
        }

        private void txtApellidos_Validating(object sender, CancelEventArgs e)
        {
            if (txtApellidos.Text == "")
            {
                e.Cancel = true;
                txtApellidos.Select(0, txtApellidos.Text.Length);
                errorProvider1.SetError(txtApellidos, "Debe ingresar los apellidos.");
            }
        }

        private void txtApellidos_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtApellidos, "");
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
                PersonaApellidos = txtApellidos.Text,
                PersonaDireccion = txtDireccion.Text,
                PersonaGenero = genero,
                PersonaNombres = txtNombres.Text
            };

            if (persona.Add(p))
            {
                MessageBox.Show("Persona agregada correctamente.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error para guardar a la persona.");
            }


        }
    }
}
