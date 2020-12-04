using CopanStockBLL;
using CopanStockDAL.ViewModels;
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
    public partial class FrmVentaInsert : Form
    {
        private readonly VentaController controller;

        private TabPage tbProductos;
        private TabPage tbVentas;

        private VentaViewModel venta = new VentaViewModel();

        public FrmVentaInsert()
        {
            InitializeComponent();

            controller = new VentaController();

            tbProductos = tabProductos;

            tabOpciones.TabPages.Remove(tabProductos);

            txtUsuarioId.Text = "4";
            txtUsuarioNombre.Text = "Juan Perez";

            txtClienteId.Text = "1";
            txtClienteNombre.Text = "Maria Meji";

            venta.VentaDetalle = new List<VentaDetalleViewModel>();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            venta.VentaCliente = new CopanStockDAL.Cliente
            {
                ClienteId = Convert.ToInt32(txtClienteId.Text)
            };

            venta.VentaUsuario = new CopanStockDAL.Usuario 
            {
                UsuarioId = Convert.ToInt32(txtUsuarioId.Text)
            };

            venta.Fecha = DateTime.Now;

            if (controller.Add(venta))
            {
                MessageBox.Show("Venta creada correctamente.");
                controller.Dispose();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error para guardar la venta.");
            }

            //this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGetProducto_Click(object sender, EventArgs e)
        {
            tabOpciones.TabPages.Add(tbProductos);
            tbVentas = tabVenta;
            tabOpciones.TabPages.Remove(tabVenta);
        }

        private void btnCerrarProductos_Click(object sender, EventArgs e)
        {
            tabOpciones.TabPages.Add(tbVentas);            
            tabOpciones.TabPages.Remove(tabProductos);
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            ProductoController productoController = new ProductoController();

            var productos = productoController.GetProductos(txtBuscarProducto.Text);

            dgProductos.DataSource = productos;

            dgProductos.Columns[2].DefaultCellStyle.Format = "c2";
            dgProductos.Columns[2].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("es-HN");

            dgProductos.Columns[4].DefaultCellStyle.Format = "c2";
            dgProductos.Columns[4].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("es-HN");


        }

        private void dgProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProductoId.Text = dgProductos.CurrentRow.Cells[0].Value.ToString();
            txtProductoNombre.Text = dgProductos.CurrentRow.Cells[1].Value.ToString();

            decimal precioFlag = (decimal)dgProductos.CurrentRow.Cells[2].Value;

            txtProductoPrecio.Text = precioFlag.ToString("C2", CultureInfo.CreateSpecificCulture("es-HN"));
            txtProductoPrecio.Tag = precioFlag;

            tabOpciones.TabPages.Add(tbVentas);
            tabOpciones.TabPages.Remove(tabProductos);


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            venta.VentaDetalle.Add(new VentaDetalleViewModel 
            { 
                ProductoId = Convert.ToInt32(txtProductoId.Text),
                Cantidad = Convert.ToInt32(txtProductoCantidad.Text),
                Precio = Convert.ToDecimal(txtProductoPrecio.Tag),
                VentaProducto = new CopanStockDAL.Producto
                {
                    ProductoId = Convert.ToInt32(txtProductoId.Text),
                    ProductoNombre = txtProductoNombre.Text
                },
            });

            lblTotal.Text = venta.Total.ToString("C2", CultureInfo.CreateSpecificCulture("es-HN"));

            dgVentaDetalle.DataSource = venta.VentaDetalle.ToList();

            dgVentaDetalle.Columns[3].DefaultCellStyle.Format = "c2";
            dgVentaDetalle.Columns[3].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("es-HN");

            dgVentaDetalle.Columns[4].DefaultCellStyle.Format = "c2";
            dgVentaDetalle.Columns[4].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("es-HN");

        }
    }
}
