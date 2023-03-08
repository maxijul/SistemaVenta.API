using SistemaVenta.Model;

namespace SistemaVenta.DTO
{
    public class MenuDTO
    {
        public int IdMenu { get; set; }
        public string Nombre { get; set; }
        public string Icono { get; set; }
        public string Url { get; set; }

        public static explicit operator MenuDTO(Menu v)
        {
            if (v == null)
                return null;

            var menuDTO = new MenuDTO()
            {
                IdMenu = v.IdMenu,
                Nombre = v.Nombre,
                Icono = v.Icono,
                Url = v.Url
            };

            return menuDTO;
        }

    }
}
