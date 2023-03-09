using SistemaVenta.DTO;

namespace SistemaVenta.BLL.Interfaces
{
    public interface IProductoService
    {
        Task<List<ProductoDTO>> GetLista();
        Task<ProductoDTO> Crear(UsuarioDTO producto);
        Task<bool> Editar(ProductoDTO producto);
        Task<bool> Eliminar(int id);
    }
}
