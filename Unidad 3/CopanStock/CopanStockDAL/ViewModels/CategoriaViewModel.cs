using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopanStockDAL.ViewModels
{
    public class CategoriaViewModel
    {
        public int Id { get; set; }
        
        [DisplayName("Categoría")]
        public string Categoria { get; set; }
        
    }
}
