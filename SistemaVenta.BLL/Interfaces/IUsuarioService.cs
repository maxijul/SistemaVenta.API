using SistemaVenta.DTO;

namespace SistemaVenta.BLL.Interfaces
{
    public interface IUsuarioService
    {
        Task<List<UsuarioDTO>> GetLista();
        Task<SesionDTO> ValidarCredenciales(string correo, string clave);
        Task<UsuarioDTO> Crear(UsuarioDTO usuario);
        Task<bool> Editar(UsuarioDTO usuario);
        Task<bool> Eliminar(int id);
    }
}
