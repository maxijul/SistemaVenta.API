using SistemaVenta.Model;
using System.Globalization;

namespace SistemaVenta.DTO
{
    public class DetalleVentaDTO
    {
        public int IdProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public int Cantidad { get; set; }
        public string PrecioTexto { get; set; }
        public string TotalTexto { get; set; }

        public static explicit operator DetalleVentaDTO(DetalleVenta v)
        {
            if (v == null)
                return null;

            var detalleVentaDTO = new DetalleVentaDTO()
            {
                IdProducto = v.IdProducto,
                DescripcionProducto = v.IdProductoNavigation.Nombre,
                Cantidad = v.Cantidad,
                PrecioTexto = Convert.ToString(v.Precio, new CultureInfo("es-AR")),
                TotalTexto = Convert.ToString(v.Total, new CultureInfo("es-AR"))
            };

            return detalleVentaDTO;
        }

    }
}
