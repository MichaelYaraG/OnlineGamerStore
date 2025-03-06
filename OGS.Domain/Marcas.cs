using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.Domain
{
    public class Marcas
    {
        [Key]
        public int IDMarca { get; set; }
        public string DescripcionMarca { get; set; }
        public bool Estado { get; set; }
    }
}
