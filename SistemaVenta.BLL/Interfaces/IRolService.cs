using SistemaVenta.DTO;

namespace SistemaVenta.BLL.Interfaces
{
    public interface IRolService
    {
        Task<List<RolDTO>> GetLista();
    }
}
