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
    public partial class FrmProductoInsert : Form
    {
        private readonly ProductoController controller;

        public FrmProductoInsert()
        {
            InitializeComponent();

            controller = new ProductoController();

            LoadCmbCategoria();

        }

        private void LoadCmbCategoria()
        {
            CategoriaController categoriaController = new CategoriaController();
            var categorias = categoriaController.GetCategorias("");

            categorias.Add(new CopanStockDAL.ViewModels.CategoriaViewModel
            {
                Id = 0,
                Categoria = "[Seleciones una categoría]"
            });

            categorias = categorias.OrderBy(c => c.Categoria).ToList();

            cmbCategoria.DisplayMember = "Categoria";
            cmbCategoria.ValueMember = "Id";
            cmbCategoria.DataSource = categorias;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var cat = (CopanStockDAL.ViewModels.CategoriaViewModel)cmbCategoria.SelectedItem;

            CopanStockDAL.Producto Producto = new CopanStockDAL.Producto
            {                
                ProductoNombre = txtProducto.Text,
                ProductoPrecio = Convert.ToDecimal(txtPrecio.Text),
                ProductoStock = Convert.ToInt32(txtStock.Text),
                CategoriaId = cat.Id
            };

            if (controller.Add(Producto))
            {
                MessageBox.Show("Producto creado correctamente.");
                controller.Dispose();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Error para guardar el producto.");
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
