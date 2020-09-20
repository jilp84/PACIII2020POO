using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_windowsforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Text += " - desde el metodo constructor";
            lblResultado.Text = "";

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            if (txtNumero1.Text.Length>0 && txtNumero2.Text.Length>0)
            {
                int n1 = int.Parse(txtNumero1.Text);
                int n2 = int.Parse(txtNumero2.Text);

                lblResultado.Text = (n1 + n2).ToString();
            }
            
        }
    }
}
