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
    public partial class FrmCategoriaEdit : Form
    {
        private CopanStockDAL.Cotegoria categoria;
        private readonly CategoriaController controller;

        public FrmCategoriaEdit(CopanStockDAL.Cotegoria categoria)
        {
            InitializeComponent();

            this.controller = new CategoriaController();
            this.categoria = categoria;

            txtId.Text = categoria.CategoriaId.ToString();
            txtCategoria.Text = categoria.CategoriaNombre;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {            

            CopanStockDAL.Cotegoria categoria = new CopanStockDAL.Cotegoria 
            {            
                CategoriaId = this.categoria.CategoriaId,
                CategoriaNombre = txtCategoria.Text
            };


            if (controller.Edit(categoria))
            {
                MessageBox.Show("Categoría editada correctamente.");
                controller.Dispose();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al editar la categoría.");
            }

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
