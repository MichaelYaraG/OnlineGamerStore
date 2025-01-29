using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.Domain
{
    public class Carrito
    {

        public int IDCarrito { get; set; }
        public Users IDUsuario { get; set; }
        public Productos IDProducto { get; set; }
        public int Cantidad { get; set; }

    }
}
