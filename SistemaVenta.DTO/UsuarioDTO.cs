using SistemaVenta.Model;

namespace SistemaVenta.DTO
{
    public class UsuarioDTO
    {
        public int IdUsuario { get; set; }
        public string NombreCompleto { get; set; }
        public string Correo { get; set; }
        public int IdRol { get; set; }
        public string RolDescripcion { get; set; }
        public int EsActivo { get; set; }

        public static explicit operator UsuarioDTO(Usuario v)
        {
            if (v == null)
                return null;

            var usuarioDTO = new UsuarioDTO()
            {
                IdUsuario = v.IdUsuario,
                NombreCompleto = v.NombreCompleto,
                Correo = v.Correo,
                IdRol = v.IdRol,
                RolDescripcion = v.IdRolNavigation.Nombre,
                EsActivo = v.EsActivo == true ? 1 : 0
            };

            return usuarioDTO;
        }

    }
}
