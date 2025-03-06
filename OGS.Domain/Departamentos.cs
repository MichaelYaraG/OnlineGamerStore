using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.Domain
{
    public class Departamentos
    {
        [Key]
        public int IDDepartamento { get; set; }
        public string CodigoDepartamento { get; set; }
        public string DescripcionDepartanento { get; set; }

    }
}
