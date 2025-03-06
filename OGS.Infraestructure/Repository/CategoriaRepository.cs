using Microsoft.EntityFrameworkCore;
using OGS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.Infraestructure.Repository
{
    public class CategoriaRepository
    {
        private readonly ApplicationDbContext _context;


        public CategoriaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Categorias>> GetCategoriasAsync()
        {
            return await _context.Categorias
                .FromSqlRaw("OGS.spListaDeCategorias")
                .ToListAsync();
        }
        public async Task<bool> AgregarCategoriaAsync(Categorias categoria)
        {
            var result = await _context.Database.ExecuteSqlRawAsync("EXEC OGS.spCrearCategoria @p0, @p1", categoria.DescripcionCategoria, categoria.Estado);
            return result > 0;
        }

        public async Task<bool> ActualizarCategoriaAsync(Categorias categoria)
        {
            var result = await _context.Database.ExecuteSqlRawAsync("EXEC  OGS.spActualizarCategoria @p0, @p1, @p2", categoria.IDCategoria, categoria.DescripcionCategoria, categoria.Estado);
            return result > 0;
        }
    }
}
