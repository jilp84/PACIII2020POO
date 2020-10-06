using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DellComputers dell = new DellComputers();

            dell.GetDesktop();
            dell.GetMark();

            string texto = "";

            texto += "Nombre: " + dell.Name + Environment.NewLine;
            texto += "Precio: " + dell.Price + Environment.NewLine;
            texto += "Marca: " + dell.Mark + Environment.NewLine;
            texto += "--------------------------" + Environment.NewLine;
            textBox1.Text = texto;

            dell.GetLaptop();
            dell.GetMark();

            texto += "Nombre: " + dell.Name + Environment.NewLine;
            texto += "Precio: " + dell.Price + Environment.NewLine;
            texto += "Marca: " + dell.Mark + Environment.NewLine;

            textBox1.Text = texto;

        }
    }
}
