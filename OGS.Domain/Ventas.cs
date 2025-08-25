using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.Domain
{
    public class Ventas
    {
        [Key]
        public int IDVenta { get; set; }
        public int IDCliente { get; set; }
        public int IDProducto { get; set; }
        public int CantidadDeProductosVendidos { get; set; }
        public int CodigoFactura { get; set; }
        public int IDUsuario { get; set; }
        public int IDMedioPago { get; set; }
        public int IDPago { get; set; }
        public decimal ValorTotalPago { get; set; }
        public decimal ValorTotalSinIva { get; set; }
        public decimal ValorIva {  get; set; }

    }

    public class VentasDTO
    {
        [Key]
        public int IDVenta { get; set; }
        public int IDCliente { get; set; }
        public string NombreCompletoCliente { get; set; }
        public int IDTipoDocumento { get; set; }
        public string DescripcionTipoDocumento { get; set; }
        public int IDProducto { get; set; }
        public string NombreProducto { get; set; }
        public int CantidadDeProductosVendidos { get; set; }
        public int IDCategoria { get; set; }
        public string DescripcionCategoria { get; set; }
        public int IDMarca { get; set; }
        public string DescripcionMarca { get; set; }
        public decimal Precio { get; set; }
        public decimal PrecioConIva { get; set; }
        public decimal IVAValor { get; set; }
        public int CodigoFactura { get; set; }
        public int IDUsuario { get; set; }
        public int  IDMedioPago { get; set; }
        public string DescripcionMedioDePago { get; set; }
        public int IDPago { get; set; }
        public decimal ValorTotalPago { get; set; }
        public decimal ValorTotalSinIva { get; set; }
        public decimal ValorIva { get; set; }

    }

}
