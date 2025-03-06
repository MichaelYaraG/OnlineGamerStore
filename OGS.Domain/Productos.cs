using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.Domain
{
    public class Productos
    {
        [Key]
        public int IDProducto { get; set; }
        public string NombreProdcuto { get; set; }
        public string DescricionProducto { get; set; }
        public decimal Precio { get; set; }
        public decimal IVAPorcentaje {  get; set; }
        public decimal IVAValor { get; set; }
        public Marcas IDMarca { get; set; }
        public int Stock { get; set; }
        public string RutaImagen {  get; set; }
        public string NombreImagen { get; set; }
        public bool Estado { get; set; }


    }
}
