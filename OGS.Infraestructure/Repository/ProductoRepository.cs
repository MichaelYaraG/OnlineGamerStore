using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using OGS.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.Infraestructure.Repository
{
    public class ProductoRepository
    {
        private readonly ApplicationDbContext _context;



        public ProductoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<ProductosDTO>> GetProductosAsync()
        {
            return await _context.ProductosDTO
                .FromSqlRaw("OGS.spListaDeProductos")
                .ToListAsync();
        }
        public async Task<bool> CrearProductoAsync(ProductosDTO productos)
        {
            var RutaImagen = "Imagenes/" + productos.NombreImagen;
            var result = await _context.Database.ExecuteSqlRawAsync("EXEC OGS.spCrearProducto @p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8",
            productos.DescripcionProducto, productos.Estado, productos.NombreProducto, productos.Precio, productos.IDMarca, productos.IDCategoria, productos.Stock, RutaImagen, productos.NombreImagen);
            //productos.DescripcionProducto, productos.Estado, productos.NombreProducto, productos.Precio, productos.IDMarca, productos.IDCategoria, productos.Stock);
            return result > 0;
        }

        public async Task<bool> ActualizarProductoAsync(ProductosDTO productos)
        {
            var RutaImagen = "Imagenes/" + productos.NombreImagen;
            var result = await _context.Database.ExecuteSqlRawAsync("EXEC OGS.spActualizarProducto @p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9",
            productos.IDProducto, productos.DescripcionProducto, productos.Estado, productos.NombreProducto, productos.Precio, productos.IDMarca, productos.IDCategoria, productos.Stock, productos.NombreImagen, RutaImagen);
            //productos.IDProducto, productos.DescripcionProducto, productos.Estado, productos.NombreProducto, productos.Precio, productos.IDMarca, productos.IDCategoria, productos.Stock);
            return result > 0;
        }

        public async Task<bool> EliminarProductoAsync(int IDProducto)
        {
            var result = await _context.Database.ExecuteSqlRawAsync("EXEC OGS.spEliminarProducto @p0", IDProducto);
            return result > 0;
        }

        public string GuardarImagenAsync(IFormFile imagen)
        {
            if (imagen == null || imagen.Length == 0)
                return null;

            string nombreArchivo = Guid.NewGuid().ToString() + Path.GetExtension(imagen.FileName);
            string ruta = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/imagenes", nombreArchivo);

            using (var stream = new FileStream(ruta, FileMode.Create))
            {
                imagen.CopyTo(stream);
            }

            return nombreArchivo; 
        }

        //---------- DDL Marcas y Categorias --------------//

        public async Task<IEnumerable<Marcas>> ObtenerMarcasAsync() 
        {
            return await _context.Marcas
                .FromSqlRaw("OGS.spMarcasDDL")
                .ToListAsync();
        }

        public async Task<IEnumerable<Categorias>> ObtenerCategoriasAsync()
        {
            return await _context.Categorias
                .FromSqlRaw("OGS.spCategoriasDDL")
                .ToListAsync();
        }

    }
}
