using CopanStockDAL;
using CopanStockDAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CopanStockBLL
{
    public class ProductoController
    {
        private readonly CopanStockEntities db;

        public ProductoController()
        {
            db = new CopanStockEntities();
        }

        public List<ProductoViewModel> GetProductos(string Search)
        {
            List<Producto> productos = new List<Producto>();

            productos = db.Producto.Where(c => c.ProductoId.ToString().Contains(Search) ||
                                                 c.ProductoNombre.Contains(Search)).ToList();


            return ToViewModelList(productos);
        }

        private List<ProductoViewModel> ToViewModelList(List<Producto> Productos)
        {
            List<ProductoViewModel> ProductosViewModel = new List<ProductoViewModel>();

            foreach (var Producto in Productos)
            {
                ProductosViewModel.Add(new ProductoViewModel
                {
                    Id = Producto.ProductoId,
                    Producto = Producto.ProductoNombre,
                    Stock = Producto.ProductoStock.Value,
                    Precio = Producto.ProductoPrecio.Value,
                    CategoriaId = Producto.Cotegoria.CategoriaId,
                    Categoria = Producto.Cotegoria.CategoriaNombre
                });
            }

            return ProductosViewModel.ToList();
        }


        public Producto GetProducto(int Id)
        {
            return db.Producto.Find(Id);
        }

        public bool Add(Producto Producto)
        {

            try
            {
                db.Producto.Add(Producto);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool Edit(Producto Producto)
        {
            try
            {
                db.Entry(Producto).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(int Id)
        {

            try
            {
                var Producto = db.Producto.Find(Id);
                db.Producto.Remove(Producto);
                db.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }

        }

        public void Dispose()
        {
            db.Dispose();
        }


    }
}
