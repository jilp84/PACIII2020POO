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

namespace _17_agenda
{
    public partial class Form1 : Form
    {
        AgendaContext db;
        public Form1()
        {
            InitializeComponent();
            db = new AgendaContext();
            var personas = db.Personas.ToList();
            MessageBox.Show("Total de Registros: " + personas.Count);
        }
    }
}
