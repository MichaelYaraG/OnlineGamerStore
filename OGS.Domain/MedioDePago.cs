using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.Domain
{
    public class MedioDePago
    {
        [Key]
        public int IDMedioDePago { get; set; }
        public string DescripcionMedioDePago { get; set; }
        public bool Estado {  get; set; }

    }
}
