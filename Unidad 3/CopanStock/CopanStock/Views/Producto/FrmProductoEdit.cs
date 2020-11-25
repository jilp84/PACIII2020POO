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
    public partial class FrmProductoEdit : Form
    {
        CopanStockDAL.Producto producto;

        private readonly ProductoController controller;

        public FrmProductoEdit(CopanStockDAL.Producto producto)
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
            var cat = (CopanStockDAL.ViewModels.CategoriaViewModel)cmbCategoria.SelectedItem;

            CopanStockDAL.Producto Producto = new CopanStockDAL.Producto
            {
                ProductoId = Convert.ToInt32(txtId.Text),
                ProductoNombre = txtProducto.Text,
                ProductoPrecio = Convert.ToDecimal(txtPrecio.Text),
                ProductoStock = Convert.ToInt32(txtStock.Text),
                CategoriaId = cat.Id,
                Cotegoria = new CopanStockDAL.Cotegoria 
                { 
                    CategoriaId = cat.Id,
                    CategoriaNombre = cat.Categoria
                }

            };

            if (controller.Edit(Producto))
            {
                MessageBox.Show("Producto editado correctamente.");
                controller.Dispose();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Error para editar el producto.");
            }

            this.Close();
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
