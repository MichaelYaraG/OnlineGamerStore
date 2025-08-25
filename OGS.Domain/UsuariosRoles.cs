using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.Domain
{
    public class UsuariosRoles
    {
        [Key]
        public int IDUsuarioRol { get; set; }
        public Usuarios IDUsuario { get; set; }
        public Roles IDRol { get; set; }
        public bool Estado {  get; set; }

    }
}
