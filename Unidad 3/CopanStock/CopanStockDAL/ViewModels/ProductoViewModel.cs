using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopanStockDAL.ViewModels
{
    public class ProductoViewModel
    {

        public int Id { get; set; }
        public string Producto { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }

        public decimal Total 
        {
            get 
            {
                return this.Precio * this.Stock;
            }
        }

        [Browsable(false)]
        public int CategoriaId { get; set; }
        
        [DisplayName("Categoría")]
        public string Categoria { get; set; }
        
    }
}
