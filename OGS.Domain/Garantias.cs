using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.Domain
{
    public class Garantias
    {

        public int IDGarantia { get; set; }
        public Facturas IDFactura { get; set; }
        public Productos IDProducto { get; set; }
        public Clientes IDCliente { get; set; }
        public DateTime FechaInicialGarantia { get; set; }
        public DateTime FechaFinalGarantia { get; set; }
        public int DiasRestantesDeGarantia { get; set; }
        public Ventas IDVenta { get; set; }
        public string NombreCliente { get; set; }
        public TipoDocumento IDTipoDocumento { get; set; }
        public decimal TotalPagado { get; set; }

    }
}
