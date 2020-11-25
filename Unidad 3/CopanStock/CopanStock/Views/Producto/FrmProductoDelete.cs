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

namespace CopanStock.Views.Producto
{
    public partial class FrmProductoDelete : Form
    {
        CopanStockDAL.Producto producto;

        private readonly ProductoController controller;

        public FrmProductoDelete(CopanStockDAL.Producto producto)
        {
            InitializeComponent();

            controller = new ProductoController();

            this.producto = producto;

            txtId.Text = producto.ProductoId.ToString();
            txtProducto.Text = producto.ProductoNombre;
            txtPrecio.Text = producto.ProductoPrecio.ToString();
            txtStock.Text = producto.ProductoStock.ToString();

            LoadCmbCategoria();

        }

        private void LoadCmbCategoria()
        {
            CategoriaController categoriaController = new CategoriaController();
            var categorias = categoriaController.GetCategorias("");            

            categorias = categorias.OrderBy(c => c.Categoria).ToList();

            cmbCategoria.DisplayMember = "Categoria";
            cmbCategoria.ValueMember = "Id";
            cmbCategoria.DataSource = categorias;

            cmbCategoria.SelectedValue = producto.Cotegoria.CategoriaId;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                "Quiere borrar este producto?",
                "Confirme acción",
                MessageBoxButtons.YesNo
                );

            if (confirmResult == DialogResult.Yes)
            {
                if (controller.Delete(producto.ProductoId))
                {
                    MessageBox.Show("Producto borrado correctamente.");
                    controller.Dispose();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al borrar el producto.");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmProductoInsert_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
