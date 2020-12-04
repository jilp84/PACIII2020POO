using CopanStock.Views.Categorias;
using CopanStock.Views.Producto;
using CopanStock.Views.Venta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopanStock.Views.Home
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void mnuCategorias_Click(object sender, EventArgs e)
        {
            FrmCategoriaList categorias = new FrmCategoriaList();
            tabControl1.TabPages.Add(categorias);
        }

        private void mnuProductos_Click(object sender, EventArgs e)
        {
            FrmProductoList productos = new FrmProductoList();
            tabControl1.TabPages.Add(productos);
        }

        private void mnuVender_Click(object sender, EventArgs e)
        {
            FrmVentaList ventas = new FrmVentaList();
            tabControl1.TabPages.Add(ventas);
        }
    }
}
