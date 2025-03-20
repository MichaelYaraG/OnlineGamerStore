using Microsoft.EntityFrameworkCore;
using OGS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.Infraestructure.Repository
{
    public class MarcaRepository
    {
        private readonly ApplicationDbContext _context;

        public MarcaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Marcas>> GetMarcasAsync()
        {
            return await _context.Marcas
                .FromSqlRaw("OGS.spListaDeMarcas")
                .ToListAsync();
        }

        public async Task<bool> AgregarMarcaAsync(Marcas marca)
        {
            var result = await _context.Database.ExecuteSqlRawAsync("EXEC OGS.spCrearMarca @p0, @p1", marca.DescripcionMarca, marca.Estado);
            return result > 0;
        }

        public async Task<bool> ActualizarMarcaAsync(Marcas marca)
        {
            var result = await _context.Database.ExecuteSqlRawAsync("EXEC OGS.spActualizarMarca @p0, @p1, @p2", marca.IDMarca, marca.DescripcionMarca, marca.Estado);
            return result > 0;
        }

        public async Task<bool> EliminarMarcaAsync(int IDMarca)
        {
            var result = await _context.Database.ExecuteSqlRawAsync("EXEC OGS.spEliminarMarca @p0", IDMarca);
            return result > 0;
        }

    }
}
