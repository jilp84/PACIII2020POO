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
    public class VentaController
    {
        private readonly CopanStockEntities db;

        public VentaController() 
        {
            db = new CopanStockEntities();
        }

        public List<VentaViewModel> GetVentas(string Search) 
        {
            List<Venta> Ventas = new List<Venta>();

            Ventas = db.Venta.Where(c => c.VentaId.ToString().Contains(Search) ||
                                                 c.Cliente.ClienteNombre.Contains(Search) ||
                                                 c.Usuario.UsuarioNombre.Contains(Search)).
                                                 Include(v => v.VentaDetalle).ToList();
            return ToViewModelList(Ventas);
        }

        private List<VentaViewModel> ToViewModelList(List<Venta> Ventas)
        {
            List<VentaViewModel> VentasViewModel = new List<VentaViewModel>();

            foreach (var Venta in Ventas)
            {
                VentasViewModel.Add(new VentaViewModel 
                {
                    Id = Venta.VentaId,
                    Fecha = Venta.VentaFecha.Value,
                    VentaCliente = Venta.Cliente,
                    VentaUsuario = Venta.Usuario,
                    VentaDetalle = ToVentaDetalleViewModel(Venta.VentaDetalle)
                });
            }

            return VentasViewModel.ToList();
        }

        private List<VentaDetalleViewModel> ToVentaDetalleViewModel(ICollection<VentaDetalle> ventaDetalle)
        {
            List<VentaDetalleViewModel> ventaDetalleViewModel = new List<VentaDetalleViewModel>();

            foreach (var item in ventaDetalle)
            {
                ventaDetalleViewModel.Add(new VentaDetalleViewModel
                {
                    VentaDetalleId = item.VentaDetalleId,
                    VentaId = item.VentaId,
                    ProductoId = item.ProductoId,
                    Cantidad = item.VentaDetalleCantidad.Value,
                    Precio = item.VentaDetallePrecio.Value,
                    VentaProducto = item.Producto
                });
            }

            return ventaDetalleViewModel;
        }

        public Cotegoria GetVenta(int Id) 
        {
            return db.Cotegoria.Find(Id);
        }

        public bool Add(VentaViewModel modelo) 
        {
            bool ok = false;

            using (DbContextTransaction transaction = db.Database.BeginTransaction())
            {
                try
                {
                    //Agregar encabezado de venta
                    db.Venta.Add(new Venta 
                    {
                        ClienteId = modelo.VentaCliente.ClienteId,
                        UsuarioId = modelo.VentaUsuario.UsuarioId,
                        VentaFecha = modelo.Fecha
                    });
                    db.SaveChanges();

                    //Obtener el codigo de la venta ingresada
                    var ventaId = db.Venta.ToList().Select(v => v.VentaId).Max();

                    //Insertar el detalle de la venta
                    foreach (var item in modelo.VentaDetalle)
                    {
                        var ventaDetalle = new VentaDetalle 
                        { 
                            VentaId = ventaId,
                            ProductoId = item.ProductoId,
                            VentaDetalleCantidad = item.Cantidad,
                            VentaDetallePrecio = item.Precio
                        };
                        db.VentaDetalle.Add(ventaDetalle);
                        db.SaveChanges();

                        //Reducir la existencia del producto
                        var producto = db.Producto.Find(ventaDetalle.ProductoId);
                        producto.ProductoStock = producto.ProductoStock - ventaDetalle.VentaDetalleCantidad;

                        db.Entry(producto).State = EntityState.Modified;
                        db.SaveChanges();

                    }

                    transaction.Commit();
                    ok = true;
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    return ok;
                }

                
            }

            return ok;
        }

        public bool Edit(Cotegoria Venta) 
        {
            try
            {
                db.Entry(Venta).State = EntityState.Modified;
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
                var Venta = db.Cotegoria.Find(Id);
                db.Cotegoria.Remove(Venta);
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
