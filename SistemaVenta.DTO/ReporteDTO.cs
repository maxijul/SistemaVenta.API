using SistemaVenta.Model;
using System.Globalization;

namespace SistemaVenta.DTO
{
    public class ReporteDTO
    {
        public string NumeroDocumento { get; set; }
        public string TipoPago { get; set; }
        public string FechaRegistro { get; set; }
        public string TotalVenta { get; set; }
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public string Precio { get; set; }
        public string Total { get; set; }

        public static explicit operator ReporteDTO(DetalleVenta v)
        {
            if (v == null)
                return null;

            var reporteDTO = new ReporteDTO()
            {
                NumeroDocumento = v.IdVentaNavigation.NumeroDocumento,
                TipoPago = v.IdVentaNavigation.TipoPago,
                FechaRegistro = v.IdVentaNavigation.FechaRegistro.ToString("dd/MM/yyyy"),
                TotalVenta = Convert.ToString(v.IdVentaNavigation.Total, new CultureInfo("es-AR")),
                Producto = v.IdProductoNavigation.Nombre,
                Cantidad = v.Cantidad,
                Precio = Convert.ToString(v.Precio, new CultureInfo("es-AR")),
                Total = Convert.ToString(v.Total, new CultureInfo("es-AR"))
            };

            return reporteDTO;
        }

    }
}
