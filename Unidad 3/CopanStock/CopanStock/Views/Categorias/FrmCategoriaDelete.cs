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
    public partial class FrmCategoriaDelete : Form
    {
        private CopanStockDAL.Cotegoria categoria;
        private readonly CategoriaController controller;

        public FrmCategoriaDelete(CopanStockDAL.Cotegoria categoria)
        {
            InitializeComponent();

            this.controller = new CategoriaController();
            this.categoria = categoria;

            txtId.Text = categoria.CategoriaId.ToString();
            txtCategoria.Text = categoria.CategoriaNombre;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            var confirmResult = MessageBox.Show(
                "Quiere borrar esta categoría?",
                "Confirme acción",
                MessageBoxButtons.YesNo
                );

            if (confirmResult == DialogResult.Yes)
            {
                if (controller.Delete(categoria.CategoriaId))
                {
                    MessageBox.Show("Categoría borrada correctamente.");
                    controller.Dispose();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al borrar la categoría.");
                }
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
