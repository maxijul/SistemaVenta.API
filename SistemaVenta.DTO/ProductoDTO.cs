using SistemaVenta.Model;
using System.Globalization;

namespace SistemaVenta.DTO
{
    public class ProductoDTO
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public int IdCategoria { get; set; }
        public string DescripcionCategoria { get; set; }
        public int Stock { get; set; }
        public string Precio { get; set; }
        public int EsActivo { get; set; }

        public static explicit operator ProductoDTO(Producto v)
        {
            if (v == null)
                return null;

            var productoDTO = new ProductoDTO()
            {
                IdProducto = v.IdProducto,
                Nombre = v.Nombre,
                IdCategoria = v.IdCategoria,
                DescripcionCategoria = v.IdCategoriaNavigation.Nombre,
                Stock = v.Stock,
                Precio = Convert.ToString(v.Precio, new CultureInfo("es-AR")),
                EsActivo = v.EsActivo == true ? 1 : 0
            };

            return productoDTO;
        }

    }
}
