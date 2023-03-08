using SistemaVenta.Model;
using System.Globalization;

namespace SistemaVenta.DTO
{
    public class VentaDTO
    {
        public int IdVenta { get; set; }
        public string NumeroDocumento { get; set; }
        public string TipoPago { get; set; }
        public string TotalTexto { get; set; }
        public string FechaRegistro { get; set; }
        public virtual ICollection<DetalleVentaDTO> DetalleVenta { get; set; }

        public static explicit operator VentaDTO(Venta v)
        {
            if (v == null)
                return null;

            var ventaDTO = new VentaDTO()
            {
                IdVenta = v.IdVenta,
                NumeroDocumento = v.NumeroDocumento,
                TipoPago = v.TipoPago,
                TotalTexto = Convert.ToString(v.Total, new CultureInfo("es-AR")),
                FechaRegistro = v.FechaRegistro.ToString("dd/MM/yyyy"),
                DetalleVenta = (ICollection<DetalleVentaDTO>)v.DetalleVenta
            };

            return ventaDTO;
        }
    }
}
