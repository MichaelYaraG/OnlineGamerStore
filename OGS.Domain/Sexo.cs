using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace OGS.Domain
{
    public class Sexo
    {
        [Key]
        public int IDSexo { get; set; }
        public string Abreviatura { get; set; }
        public string DescripcionSexo { get; set; }

    }
}
