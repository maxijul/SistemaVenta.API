using SistemaVenta.DAL.DBContext;
using SistemaVenta.DAL.Interfaces;
using SistemaVenta.Model;

namespace SistemaVenta.DAL.Repository
{
    public class VentaRepository : GenericRepository<Venta>, IVentaRepository
    {

        private readonly DBVentaContext _dbContext;

        public VentaRepository(DBVentaContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Venta> Registrar(Venta modelo)
        {
            Venta ventaGenerada = new Venta();

            using (var transaccion = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    // Se guardan todos los productos de la venta
                    foreach (DetalleVenta detalleVenta in modelo.DetalleVenta)
                    {
                        Producto productoEncontrado = _dbContext.Productos
                            .Where(p => p.IdProducto == detalleVenta.IdProducto).First();

                        productoEncontrado.Stock -= detalleVenta.Cantidad;
                        _dbContext.Productos.Update(productoEncontrado);
                    }
                    await _dbContext.SaveChangesAsync();

                    NumeroDocumento correlativo = _dbContext.NumeroDocumentos.First();
                    correlativo.UltimoNumero++;
                    correlativo.FechaRegistro = DateTime.UtcNow;
                    _dbContext.NumeroDocumentos.Update(correlativo);
                    await _dbContext.SaveChangesAsync();

                    //Generar formato de nro documetno
                    int CantidadDigitos = 4;
                    string ceros = string.Concat(Enumerable.Repeat("0", CantidadDigitos));
                    string numeroVenta = ceros + correlativo.UltimoNumero.ToString();

                    numeroVenta = numeroVenta.Substring(numeroVenta.Length - CantidadDigitos, CantidadDigitos);
                    modelo.NumeroDocumento = numeroVenta;
                    await _dbContext.Venta.AddAsync(modelo);
                    await _dbContext.SaveChangesAsync();

                    ventaGenerada = modelo;
                    transaccion.Commit();
                }
                catch
                {
                    transaccion.Rollback();
                    throw;
                }

                return ventaGenerada;
            }
        }
    }
}
