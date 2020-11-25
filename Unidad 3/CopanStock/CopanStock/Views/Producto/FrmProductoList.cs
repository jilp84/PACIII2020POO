using CopanStockBLL;
using CopanStockDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopanStock.Views.Producto
{
    public partial class FrmProductoList : Form
    {
        ProductoController controller;
        public FrmProductoList()
        {
            InitializeComponent();

            ActualizarDatos();
        }

        private void ActualizarDatos()
        {
            controller = new ProductoController();
            var productos = controller.GetProductos(txtBuscar.Text);
            dgDatos.DataSource = productos;

            dgDatos.Columns[2].DefaultCellStyle.Format = "c2";
            dgDatos.Columns[2].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("es-HN");

            dgDatos.Columns[4].DefaultCellStyle.Format = "c2";
            dgDatos.Columns[4].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("es-HN");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmProductoInsert insertar = new FrmProductoInsert();
            insertar.ShowDialog();
            insertar.Dispose();
            ActualizarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var c = controller.GetProducto(
                Convert.ToInt32(dgDatos.CurrentRow.Cells[0].Value.ToString()));

            if (c != null)
            {
                FrmProductoEdit editar = new FrmProductoEdit(c);
                editar.ShowDialog();
                editar.Dispose();
                ActualizarDatos();
            }

            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            var c = controller.GetProducto(
                Convert.ToInt32(dgDatos.CurrentRow.Cells[0].Value.ToString()));
            if (c != null)
            {
                FrmProductoDelete borrar = new FrmProductoDelete(c);
                borrar.ShowDialog();
                borrar.Dispose();
                ActualizarDatos();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ActualizarDatos();
        }
    }
}
