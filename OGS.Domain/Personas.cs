using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.Domain
{
    public class Personas
    {
        public int IDPersona { get; set; }
        public TipoPersona IDTipoPersona { get; set; }
        public Users IDUsuario {  get; set; }
        public TipoDocumento IDTipoDocumento { get; set; }
        public int NumeroDocumento { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Nombre2 { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string NombreCompleto { get; set; }
        public string CorreoElectronico { get; set; }
        public Sexo IDSexo {  get; set; }
        public int Telefono { get; set; }
        public int Edad {  get; set; }
        public string Direccion1 { get; set; }
        public string Direccion2 { get;set; }
        public string Direccion3 { get; set; }
        public string Complemento { get; set; }
        

    }
}
