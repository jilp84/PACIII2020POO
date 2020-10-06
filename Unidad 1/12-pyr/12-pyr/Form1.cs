using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_pyr
{
    public partial class Form1 : Form
    {
        private int[] arr;
        private int flag;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTamanio_Click(object sender, EventArgs e)
        {
            arr = new int[Convert.ToInt32(txtTamanio.Text)];
            flag = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            

            if (flag < arr.Length)
            {
                arr[flag] = Convert.ToInt32(txtValor.Text);
                flag++;
            }
            else
            {
                MessageBox.Show("Datos completados");
            }

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            for (int i = 0; i < arr.Length; i++)
            {
                richTextBox1.Text += arr[i].ToString() + "\n";
            }
        }
    }
}
