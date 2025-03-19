using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
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
        public string NombreProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public decimal Precio { get; set; }
        public decimal PrecioConIva { get; set; }
        public decimal IVAPorcentaje { get; set; }
        public decimal IVAValor { get; set; }
        public int IDCategoria { get; set; }
        public int IDMarca { get; set; }
        public int Stock { get; set; }
        public string RutaImagen { get; set; }
        public string NombreImagen { get; set; }
        public bool Estado { get; set; }


    }

    public class ProductosDTO
    {
        [Key]
        public int IDProducto { get; set; }
        public string NombreProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public decimal Precio { get; set; }
        public decimal PrecioConIva { get; set; }
        public decimal IVAPorcentaje { get; set; }
        public decimal IVAValor { get; set; }
        public int IDCategoria { get; set; }
        public string DescripcionCategoria { get; set; }
        public int IDMarca { get; set; }
        public string DescripcionMarca { get; set; }
        public int Stock { get; set; }
        public string RutaImagen { get; set; }
        public string NombreImagen { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaRegistro { get; set; }


    }

    public class EliminarProductoRequest
    {
        public int IDProducto { get; set; }
    }
}