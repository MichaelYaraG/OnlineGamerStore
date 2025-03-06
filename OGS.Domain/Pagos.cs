using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.Domain
{
    public class Pagos
    {
        [Key]
        public int IDPago { get; set; }
        public Clientes IDCliente { get; set; }
        public string IDTransaccion { get; set; }
        public decimal ValorPago { get; set; }
        public EstadosDePago IDEstadoPago { get; set; }

    }
}
