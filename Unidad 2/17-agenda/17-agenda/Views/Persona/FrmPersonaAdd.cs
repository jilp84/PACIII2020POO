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
    public partial class FrmPersonaAdd : MetroFramework.Forms.MetroForm
    {
        public FrmPersonaAdd()
        {
            InitializeComponent();

            txtApellidos.Text = "A";
            txtDireccion.Text = "A";
            txtNombres.Text = "A";

            txtApellidos.Text = "";
            txtDireccion.Text = "";
            txtNombres.Text = "";

        }
    }
}
