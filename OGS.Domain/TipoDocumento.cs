using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.Domain
{
    public class TipoDocumento
    {
        [Key]
        public int IDTipoDocumento {  get; set; }
        public string DescripcionTipoDocumento { get; set; }
        public string Abreviatura {  get; set; }
    }
}
