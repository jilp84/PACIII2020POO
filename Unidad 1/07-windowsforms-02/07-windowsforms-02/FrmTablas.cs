using _07_windowsforms_02.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_windowsforms_02
{
    public partial class FrmTablas : Form
    {
        public FrmTablas()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Calcular();

        }

        private void Calcular() 
        {
            int numero = int.Parse(txtNumero.Text);
            int limite = int.Parse(txtLimite.Text);

            txtSalida.Text = GetTabla(numero, limite);
        }

        private string GetTabla(int numero, int limite) 
        {
            string tabla = "";
            for (int i = 1; i <= limite; i++)
            {
                tabla += String.Format("{0} x {1} = {2}\n", numero, i, (numero*i));
            }

            return tabla;
        
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextbox.SoloNumeros(e);
        }

        private void txtLimite_KeyPress(object sender, KeyPressEventArgs e)
        {

            ValidarTextbox.SoloNumeros(e);
            if ((int)e.KeyChar == (int)Keys.Enter && txtLimite.Text != "")
            {
                e.Handled = true;
                Calcular();
            }
        }

        private void txtNumero_Validating(object sender, CancelEventArgs e)
        {
            if (txtNumero.Text == "")
            {
                e.Cancel = true;
                txtNumero.Select(0, txtNumero.Text.Length);
                errorProvider1.SetError(txtNumero, "Debe ingresar un numero");
            }
        }

        private void txtNumero_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtNumero, "");
        }

        private void txtLimite_Validating(object sender, CancelEventArgs e)
        {
            if (txtLimite.Text == "")
            {
                e.Cancel = true;
                txtLimite.Select(0, txtLimite.Text.Length);
                errorProvider1.SetError(txtLimite, "Debe ingresar un numero");
            }
        }

        private void txtLimite_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtLimite, "");
        }
    }
}
