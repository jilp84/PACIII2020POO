using CopanStockBLL;
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

namespace CopanStock.Views.Venta
{
    public partial class FrmVentaList : Form
    {
        VentaController controller;
        public FrmVentaList()
        {
            InitializeComponent();

            ActualizarDatos();
        }

        private void ActualizarDatos()
        {
            controller = new VentaController();
            var cate = controller.GetVentas(txtBuscar.Text);
            dgDatos.DataSource = cate;

            dgDatos.Columns[4].DefaultCellStyle.Format = "c2";
            dgDatos.Columns[4].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("es-HN");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmVentaInsert insertar = new FrmVentaInsert();
            insertar.ShowDialog();
            insertar.Dispose();
            ActualizarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var c = controller.GetVenta(
                Convert.ToInt32(dgDatos.CurrentRow.Cells[0].Value.ToString()));

            if (c != null)
            {
                //FrmCategoriaEdit editar = new FrmCategoriaEdit(c);
                //editar.ShowDialog();
                //editar.Dispose();
                //ActualizarDatos();
            }

            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            var c = controller.GetVenta(
                Convert.ToInt32(dgDatos.CurrentRow.Cells[0].Value.ToString()));
            if (c != null)
            {
                //FrmCategoriaDelete borrar = new FrmCategoriaDelete(c);
                //borrar.ShowDialog();
                //borrar.Dispose();
                //ActualizarDatos();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ActualizarDatos();
        }
    }
}
