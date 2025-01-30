using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.Domain
{
    public class Clientes
    {
        public int IDCliente { get; set; }
        public Personas IDPersona { get; set; }
        public Users IDUser { get; set; }
        public TipoDocumento IDTipoDocumento { get; set; }
        public int NumeroDocumento { get; set; }
        public string NombreCompleto { get; set; }
        
    }
}
