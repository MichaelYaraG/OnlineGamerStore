using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.Domain
{
    public class TipoPersona
    {
        [Key]
        public int IDTipoPersona { get; set; }
        public string DescripcionTipoPersona { get; set; }

    }
}
