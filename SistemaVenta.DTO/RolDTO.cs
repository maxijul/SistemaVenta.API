using SistemaVenta.Model;

namespace SistemaVenta.DTO
{
    public class RolDTO
    {
        public int IdRol { get; set; }
        public string Nombre { get; set; }

        public static explicit operator RolDTO(Rol v)
        {
            if (v == null)
                return null;

            var rolDTO = new RolDTO()
            {
                IdRol = v.IdRol,
                Nombre = v.Nombre
            };

            return rolDTO;
        }
    }
}
