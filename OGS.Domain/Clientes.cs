using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.Domain
{
    public class Clientes
    {
        [Key]
        public int IDCliente { get; set; }
        public int IDPersona { get; set; }
        public int IDUsuario { get; set; }
        public int IDTipoDocumento { get; set; }
        public int NumeroDocumento { get; set; }
        public string NombreCompleto { get; set; }
        
    }

    //Creación de Entidad con Campos Extras 

    public class ClientesDTO
    {
        public int IDCliente { get; set; }
        public int IDTipoDocumento { get; set; }
        public string Abreviatura {  get; set; }
        public int NumeroDocumento { get; set; }
        public string NombreCompleto { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string CorreoElectronico { get; set; }


    }
}
