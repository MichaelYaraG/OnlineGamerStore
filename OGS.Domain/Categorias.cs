using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.Domain
{
    public class Categorias
    {
        [Key]
        public int IDCategoria { get; set; }
        public string DescripcionCategoria { get; set; }
        public bool Estado {  get; set; }

    }
}
