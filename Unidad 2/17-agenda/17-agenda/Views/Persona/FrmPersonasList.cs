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
        AgendaContext db;
        public FrmPersonasList()
        {
            InitializeComponent();
            db = new AgendaContext();
            var personas = db.Personas.ToList();
            //MessageBox.Show("Total de Registros: " + personas.Count);

            txtBuscar.Text = "A";
            txtBuscar.Text = "";

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmPersonaAdd add = new FrmPersonaAdd();

            add.ShowDialog();
            add.Dispose();


        }
    }
}
