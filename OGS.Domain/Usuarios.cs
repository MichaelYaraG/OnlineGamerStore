using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.Domain
{
    public class Usuarios
    {
        [Key]
        public int IDUsuario { get; set; }
        public TipoDocumento IDTipoDocumento { get; set; }
        public string Nombre1 { get; set; }
        public string Nombre2 { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get;set; }
        public string NombreCompleto { get; set; }
        public string CorreoElectronico { get; set; }
        public string Contraseña { get; set; }
        public DateTime FechaNacimiento { get; set; }  
        public Sexo IDSexo { get; set; }
        public int Telefono { get; set; }
        public bool Estado {  get; set; }

    }
}
