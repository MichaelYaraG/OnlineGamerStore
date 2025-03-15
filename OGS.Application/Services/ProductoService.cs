using Microsoft.AspNetCore.Http;
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
            return await _repository.CrearProductoAsync(productos);
        }

        public async Task<bool> ActualizarProductoAsync(ProductosDTO productos)
        {
            return await _repository.ActualizarProductoAsync(productos);
        }
        public async Task<bool> EliminarProductoAsync(int IDProducto)
        {
            return await _repository.EliminarProductoAsync(IDProducto);
        }
        public string GuardarImagen(IFormFile imagen)
        {
            return _repository.GuardarImagenAsync(imagen);
        }
        public async Task<IEnumerable<Marcas>> ObtenerMarcasAsync()
        {
            return await _repository.ObtenerMarcasAsync();
        }

        public async Task<IEnumerable<Categorias>> ObtenerCategoriasAsync()
        {
            return await _repository.ObtenerCategoriasAsync();
        }
    }
}