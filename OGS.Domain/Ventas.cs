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
        public Clientes IDCliente { get; set; }
        public Productos IDProducto { get; set; }
        public Facturas IDFactura { get; set; }
        public Users IDUser { get; set; }
        public MedioDePago IDMedioPago { get; set; }
        public Pagos IDPago { get; set; }
        public decimal ValorTotalPago { get; set; }
        public decimal ValorTotalSinIva { get; set; }
        public decimal ValorIva {  get; set; }

    }
}
