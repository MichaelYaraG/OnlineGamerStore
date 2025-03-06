using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.Domain
{
    public class EstadosDePago
    {
        [Key]
        public int IDEstadoPago { get; set; }
        public string DescripcionEstadoPago { get; set; }
        public bool Estado {  get; set; }

    }
}
