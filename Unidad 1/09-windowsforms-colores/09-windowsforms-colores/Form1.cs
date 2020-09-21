using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_windowsforms_colores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSetColor_Click(object sender, EventArgs e)
        {
            if (cmbColores.Text == "Rojo")
            {
                panel1.BackColor = Color.Red;
            }
            if (cmbColores.Text == "Azul")
            {
                panel1.BackColor = Color.Blue;
            }
            if (cmbColores.Text == "Verde")
            {
                panel1.BackColor = Color.Green;
            }
        }
    }
}
