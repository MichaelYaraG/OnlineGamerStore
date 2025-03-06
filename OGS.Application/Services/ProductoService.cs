using OGS.Domain;
using OGS.Infraestructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.Application.Services
{
    public class ProductoService
    {
        private readonly ProductoRepository _repository;

        public ProductoService(ProductoRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<ProductosDTO>> GetProductosAsync()
        {
            return await _repository.GetProductosAsync();
        }
        public async Task<bool> CrearProductoAsync(ProductosDTO productos)
        {
            return await _repository.AgregarProductoAsync(productos);
        }

        public async Task<bool> ActualizarProductoAsync(ProductosDTO productos)
        {
            return await _repository.AgregarProductoAsync(productos);
        }
    }
}
