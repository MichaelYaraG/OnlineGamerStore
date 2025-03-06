using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.Domain
{
    public  class Roles
    {
        [Key]
        public int IDRol {  get; set; }
        public string DescripcionRol { get; set; }

    }
}
