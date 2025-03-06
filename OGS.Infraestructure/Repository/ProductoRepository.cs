using Microsoft.EntityFrameworkCore;
using OGS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.Infraestructure.Repository
{
    public class ProductoRepository
    {
        private readonly ApplicationDbContext _context;

        string Ruta = "~\\OnlineGamerStoreAdmin\\wwwroot\\Imagenes\\";


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
        public async Task<bool> AgregarProductoAsync(ProductosDTO productos)
        {
            string RutaImagen = Ruta + productos.NombreImagen;
            var result = await _context.Database.ExecuteSqlRawAsync("EXEC OGS.spCrearProducto @p0, @p1, p2, @p3, @p4, @p5, @p6, @p7, @p8", 
                productos.DescripcionProducto, productos.Estado, productos.NombreProducto, productos.Precio, productos.IDMarca, productos.IDCategoria, productos.Stock, RutaImagen, productos.NombreImagen);
            return result > 0;
        }

        public async Task<bool> ActualizarProductoAsync(ProductosDTO productos)
        {
            string RutaImagen = Ruta + productos.NombreImagen;
            var result = await _context.Database.ExecuteSqlRawAsync("EXEC  OGS.spActualizarProducto @p0, @p1, p2, @p3, @p4, @p5, @p6, @p7, @p8, @p10", 
                productos.IDProducto, productos.DescripcionProducto, productos.Estado, productos.NombreProducto, productos.Precio, productos.IDMarca, productos.IDCategoria, productos.Stock, productos.NombreImagen, RutaImagen);
            return result > 0;
        }
    }
}
