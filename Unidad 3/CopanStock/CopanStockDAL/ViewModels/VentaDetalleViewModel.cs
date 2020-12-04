using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopanStockDAL.ViewModels
{
    public class VentaDetalleViewModel
    {
        [Browsable(false)]
        public int VentaDetalleId { get; set; }
        
        [Browsable(false)]
        public Nullable<int> VentaId { get; set; }

        [DisplayName("Id")]
        public Nullable<int> ProductoId { get; set; }

        public string Producto 
        {
            get 
            {
                return VentaProducto.ProductoNombre;
            }
        }

        public int Cantidad { get; set; }
        
        public decimal Precio { get; set; }

        [DisplayName("Sub Total")]
        public decimal SubTotal 
        {
            get 
            {
                return Cantidad * Precio;
            }
        }

        [Browsable(false)]
        public virtual Venta Venta { get; set; }
        [Browsable(false)]
        public virtual Producto VentaProducto { get; set; }
    }
}
