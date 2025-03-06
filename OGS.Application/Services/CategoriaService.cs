using OGS.Domain;
using OGS.Infraestructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.Application.Services
{
    public class CategoriaService
    {
        private readonly CategoriaRepository _repository;

        public CategoriaService(CategoriaRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Categorias>> GetCategoriasAsync()
        {
            return await _repository.GetCategoriasAsync();
        }
        public async Task<bool> CrearCategoriaAsync(Categorias categoria)
        {
            return await _repository.AgregarCategoriaAsync(categoria);
        }

        public async Task<bool> ActualizarCategoriaAsync(Categorias categoria)
        {
            return await _repository.ActualizarCategoriaAsync(categoria);
        }
    }
}
