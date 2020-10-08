using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_abstract
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = "";

            Vehicle vc;

            vc = new Bus();

            double busPrice = vc.GetFullAmount();

            texto = "Bus monto total: " + busPrice.ToString() + Environment.NewLine;
            textBox1.Text = texto;

            vc = new Truck();

            double truckPrice = vc.GetFullAmount();

            texto = "Camion monto total: " + truckPrice.ToString() + Environment.NewLine;
            textBox1.Text += texto;

        }
    }
}
