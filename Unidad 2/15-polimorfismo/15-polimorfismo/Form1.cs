using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_polimorfismo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.SetValues(1);

            string txt = teacher.GetValues();

            textBox1.Text = txt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.SetValues(1, "Juan Perez");

            string txt = teacher.GetValues();

            textBox1.Text = txt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.SetValues(1, "Juan Perez", 3500);

            string txt = teacher.GetValues();

            textBox1.Text = txt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.SetValues(1, "Juan Perez", 3500, "Profesor");

            string txt = teacher.GetValues();

            textBox1.Text = txt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Employee2 employee = new Employee2();
            string txt = employee.SetValues(1, "Juan Perez", 3500);
            textBox1.Text = txt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Teacher2 teacher = new Teacher2();
            string txt = teacher.SetValues(1, "Juan Perez", 3500);
            textBox1.Text = txt;
        }
    }
}
