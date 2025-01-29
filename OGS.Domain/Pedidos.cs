using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.Domain
{
    public class Pedidos
    {

        public int IDPedido { get; set; }
        public Ventas IDVenta { get; set; }
        public Clientes IDCliente { get; set; }
        public Productos IDProducto { get; set; }
        public Facturas IDFactura { get; set; }
        public string Direccion {  get; set; }
        public string Contacto { get; set; }
        public EstadoPedido IDEstadoPedido { get; set; }

    }
}
