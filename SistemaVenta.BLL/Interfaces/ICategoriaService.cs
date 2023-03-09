using SistemaVenta.DTO;

namespace SistemaVenta.BLL.Interfaces
{
    public interface ICategoriaService
    {
        Task<List<CategoriaDTO>> GetLista();
    }
}
