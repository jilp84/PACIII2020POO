using CopanStockBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopanStock.Views.Categorias
{
    public partial class FrmCategoriaInsert : Form
    {
        private readonly CategoriaController controller;

        public FrmCategoriaInsert()
        {
            InitializeComponent();

            controller = new CategoriaController();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CopanStockDAL.Cotegoria categoria = new CopanStockDAL.Cotegoria
            {
                CategoriaNombre = txtCategoria.Text
            };

            if (controller.Add(categoria))
            {
                MessageBox.Show("Categoría creada correctamente.");
                controller.Dispose();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Error para guardar la categoría.");
            }

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
