using CopanStockDAL;
using CopanStockDAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopanStockBLL
{
    public class CategoriaController
    {
        private readonly CopanStockEntities db;

        public CategoriaController() 
        {
            db = new CopanStockEntities();
        }

        public List<CategoriaViewModel> GetCategorias(string Search) 
        {
            List<Cotegoria> categorias = new List<Cotegoria>();

            categorias = db.Cotegoria.Where(c => c.CategoriaId.ToString().Contains(Search) ||
                                                 c.CategoriaNombre.Contains(Search)).ToList();


            return ToViewModelList(categorias);
        }

        private List<CategoriaViewModel> ToViewModelList(List<Cotegoria> categorias)
        {
            List<CategoriaViewModel> categoriasViewModel = new List<CategoriaViewModel>();

            foreach (var categoria in categorias)
            {
                categoriasViewModel.Add(new CategoriaViewModel 
                {
                    Id = categoria.CategoriaId,
                    Categoria = categoria.CategoriaNombre
                });
            }

            return categoriasViewModel.ToList();
        }


        public Cotegoria GetCategoria(int Id) 
        {
            return db.Cotegoria.Find(Id);
        }

        public bool Add(Cotegoria categoria) 
        {

            try
            {
                db.Cotegoria.Add(categoria);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool Edit(Cotegoria categoria) 
        {
            try
            {
                db.Entry(categoria).State = EntityState.Modified;
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
                var categoria = db.Cotegoria.Find(Id);
                db.Cotegoria.Remove(categoria);
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
