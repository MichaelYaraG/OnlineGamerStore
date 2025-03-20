using OGS.Domain;
using OGS.Infraestructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.Application.Services
{
    public class MarcaService
    {

        private readonly MarcaRepository _repository;

        public MarcaService(MarcaRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Marcas>> GetMarcasAsync()
        {
            return await _repository.GetMarcasAsync();
        }

        public async Task<bool> CrearMarcaAsync(Marcas marca)
        {
            return await _repository.AgregarMarcaAsync(marca);
        }

        public async Task<bool> ActualizarMarcaAsync(Marcas marca)
        {
            return await _repository.ActualizarMarcaAsync(marca);
        }

        public async Task<bool> EliminarMarcaAsync(int IDMarca)
        {
            return await _repository.EliminarMarcaAsync(IDMarca);
        }

    }
}
