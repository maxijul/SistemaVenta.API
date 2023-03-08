using SistemaVenta.Model;

namespace SistemaVenta.DTO
{
    public class CategoriaDTO
    {
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }

        public static explicit operator CategoriaDTO(Categoria v)
        {
            if (v == null)
                return null;

            var categoriaDTO = new CategoriaDTO()
            {
                IdCategoria = v.IdCategoria,
                Nombre = v.Nombre
            };

            return categoriaDTO;
        }
    }
}
