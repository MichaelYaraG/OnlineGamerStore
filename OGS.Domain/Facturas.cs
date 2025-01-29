using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.Domain
{
    public class Facturas
    {

        public int IDFactura { get; set; }
        public decimal Total {  get; set; }
        public decimal SubTotal { get; set; }
        public MedioDePago IDMedioDePago { get; set; }
        public decimal ValorTotalPago {  get; set; }
        public decimal ValorTotalSinIva {  get; set; }
        public decimal ValorIva { get; set; }
        public string NombreCliente { get; set; }
        public TipoDocumento IDTipoDocumento { get; set; }
        public int ClienteNoDocumento { get; set; }
        public int IDTipoDocumentoFacturador { get; set; }
        public int FacturadorNoDocumento { get; set; }

    }
}
