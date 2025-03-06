using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.Domain
{
    public class EstadoPedido
    {
        [Key]
        public int IDEstadoPedido { get; set; }
        public string DescripcionEstadoPedido { get; set; }
        public bool Estado {  get; set; }

    }
}
