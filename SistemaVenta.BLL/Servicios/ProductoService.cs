using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SistemaVenta.BLL.Interfaces;
using SistemaVenta.DAL.Interfaces;
using SistemaVenta.DTO;
using SistemaVenta.Model;

namespace SistemaVenta.BLL.Servicios
{
    public class ProductoService : IProductoService
    {
        private readonly IGenericRepository<Producto> _productoRepository;
        private readonly IMapper _mapper;

        public ProductoService(IGenericRepository<Producto> productoRepository, IMapper mapper)
        {
            _productoRepository = productoRepository;
            _mapper = mapper;
        }

        public async Task<List<ProductoDTO>> GetLista()
        {
            try
            {
                var queryProducto = await _productoRepository.Consultar();
                var listaProductos = queryProducto.Include(cat => cat.IdCategoriaNavigation).ToList();

                return _mapper.Map<List<ProductoDTO>>(listaProductos.ToList());
            }
            catch
            {
                throw;
            }
        }

        public async Task<ProductoDTO> Crear(UsuarioDTO producto)
        {
            try
            {
                var productoCreado = await _productoRepository.Crear(_mapper.Map<Producto>(producto));

                if (productoCreado.IdProducto == 0)
                    throw new TaskCanceledException("No se pudo crear el producto");

                return _mapper.Map<ProductoDTO>(productoCreado);

            catch
            {
                throw;
            }
        }

        public async Task<bool> Editar(ProductoDTO producto)
        {
            try
            {
                var productoMapeado = _mapper.Map<Producto>(producto);
                var productoEncontrado = await _productoRepository
                    .Obtener(u => u.IdProducto == productoMapeado.IdProducto);

                if (productoEncontrado == null)
                    throw new TaskCanceledException("El producto no existe");

                productoEncontrado.Nombre = productoMapeado.Nombre;
                productoEncontrado.IdCategoria = productoMapeado.IdCategoria;
                productoEncontrado.Stock = productoMapeado.Stock;
                productoEncontrado.Precio = productoMapeado.Precio;
                productoEncontrado.EsActivo = productoMapeado.EsActivo;

                bool respuesta = await _productoRepository.Editar(productoEncontrado);

                if (!respuesta)
                    throw new TaskCanceledException("No se pudo editar el producto");

                return respuesta;
            }
            catch
            {
                throw;
            }
        }

        public async Task<bool> Eliminar(int id)
        {
            try
            {
                var productoEncontrado = await _productoRepository.Obtener(p => p.IdProducto == id);

                if (productoEncontrado == null)
                    throw new TaskCanceledException("El producto no existe");

                bool respuesta = await _productoRepository.Eliminar(productoEncontrado);

                if (!respuesta)
                    throw new TaskCanceledException("El producto no se pudo eliminar");

                return respuesta;

            }
            catch
            {
                throw;
            }
        }
    }
}
