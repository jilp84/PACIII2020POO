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
    public partial class FrmCategoriaList : Form
    {
        CategoriaController Categorias;
        public FrmCategoriaList()
        {
            InitializeComponent();

            ActualizarDatos();
        }

        private void ActualizarDatos()
        {
            Categorias = new CategoriaController();
            var cate = Categorias.GetCategorias(txtBuscar.Text);
            dgDatos.DataSource = cate;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmCategoriaInsert insertar = new FrmCategoriaInsert();
            insertar.ShowDialog();
            insertar.Dispose();
            ActualizarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var c = Categorias.GetCategoria(
                Convert.ToInt32(dgDatos.CurrentRow.Cells[0].Value.ToString()));

            if (c != null)
            {
                FrmCategoriaEdit editar = new FrmCategoriaEdit(c);
                editar.ShowDialog();
                editar.Dispose();
                ActualizarDatos();
            }

            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            var c = Categorias.GetCategoria(
                Convert.ToInt32(dgDatos.CurrentRow.Cells[0].Value.ToString()));
            if (c != null)
            {
                FrmCategoriaDelete borrar = new FrmCategoriaDelete(c);
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
