using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopanStockDAL.ViewModels
{
    public class VentaViewModel
    {
        public int Id { get; set; }

        public System.DateTime Fecha { get; set; }
        
        public string Cliente 
        {
            get 
            {
                return VentaCliente.ClienteNombre;
            }
        }
        public string Usuario 
        {
            get 
            {
                return VentaUsuario.UsuarioNombre;
            }
        }

        public decimal Total 
        {
            get 
            {
                Decimal total = 0;

                foreach (var item in VentaDetalle)
                {
                    total += item.SubTotal;
                }

                return total;
            } 
        }

        [Browsable(false)]
        public Cliente VentaCliente { get; set; }

        [Browsable(false)]
        public Usuario VentaUsuario { get; set; }

        [Browsable(false)]
        public List<VentaDetalleViewModel> VentaDetalle { get; set; }
    }
}
