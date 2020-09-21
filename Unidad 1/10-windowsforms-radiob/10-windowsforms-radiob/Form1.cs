using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_windowsforms_radiob
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string estadoCivil = "";
            string genero = "";

            if (rbSoltero.Checked)
            {
                estadoCivil = "Soltero";
            }

            if (rbCasado.Checked)
            {
                estadoCivil = "Casado";
            }

            if (rbDivorciado.Checked)
            {
                estadoCivil = "Divorciado";
            }

            if (rbViudo.Checked)
            {
                estadoCivil = "Viudo";
            }

            if (rbFemenino.Checked)
            {
                genero = "Femenino";
            }

            if (rbMasculino.Checked)
            {
                genero = "Masculino";
            }

            MessageBox.Show(string.Format("Hola su nombre es {0}, su genero es {1} y su su estado civil es {2}",
                txtNombre.Text, genero, estadoCivil));

        }
    }
}
