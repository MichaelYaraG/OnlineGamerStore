using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.Domain
{
    public class Ciudades
    {
        [Key] 
        public int IDCiudad { get; set; }
        public string CodigoCiudad { get; set; }
        public string DescripcionCiudad { get; set; }

    }
}
