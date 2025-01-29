using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.Domain
{
    public class Comentarios
    {
        public int IDComentario { get; set; }
        public Users IDUser { get; set; }
        public string Comentario { get; set; }
        public bool Estado { get; set; }

    }
}
