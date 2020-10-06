using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Profesor profesor = new Profesor();

            profesor.SetValues();
            profesor.SetValues2();
            profesor.BuscarSalario();

            string texto = "";

            texto += profesor.Nombre + Environment.NewLine;
            texto += profesor.Apellido + Environment.NewLine;
            texto += profesor.Genero + Environment.NewLine;
            texto += profesor.Edad + Environment.NewLine;
            texto += profesor.Area + Environment.NewLine;
            texto += profesor.Puesto + Environment.NewLine;
            texto += profesor.Salario.ToString() + Environment.NewLine;

            textBox1.Text = texto;

        }
    }
}
