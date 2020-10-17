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
    public partial class FrmPersonasList : MetroFramework.Forms.MetroForm
    {
        PersonaController Personas;
        public FrmPersonasList()
        {
            InitializeComponent();

            ActualizarDatos();

            //MessageBox.Show("Total de Registros: " + personas.Count);

            txtBuscar.Text = "A";
            txtBuscar.Text = "";

        }

        private void ActualizarDatos() 
        {
            Personas = new PersonaController();
            var personas = Personas.GetPersonas(txtBuscar.Text);
            dgDatos.DataSource = personas;
        
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmPersonaAdd add = new FrmPersonaAdd();

            add.ShowDialog();
            add.Dispose();
            ActualizarDatos();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ActualizarDatos();
        }
    }
}
