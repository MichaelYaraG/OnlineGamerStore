using Microsoft.AspNetCore.Mvc;
using OGS.Application.Services;
using OGS.Application;
using OGS.Infraestructure;
using OGS.Domain;

namespace OnlineGamerStoreAdmin.Controllers
{
    public class AdministrationController : Controller
    {

        private readonly MarcaService _marcaService;
        private readonly ProductoService _productoService;
        private readonly CategoriaService _categoriaService;
        private readonly ClienteService _clienteService;


        public AdministrationController(MarcaService marcaService, ProductoService productoService, CategoriaService categoriaService, ClienteService clienteService)
        {
            _marcaService = marcaService;
            _productoService = productoService;
            _categoriaService = categoriaService;
            _clienteService = clienteService;
        }

        // --------------- CODIGO CORRESPONDIENTE A LA ADMINISTRACION DE MARCAS ---------------------------- //
        [HttpGet]
        public async Task<IActionResult> Categorias()
        {
            var categorias = await _categoriaService.GetCategoriasAsync();

            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                return Json(categorias);
            }

            return View(categorias);
        }

        [HttpPost]
        public async Task<IActionResult> CrearCategoria([FromBody] Categorias categoria)
        {
            if (categoria == null || string.IsNullOrEmpty(categoria.DescripcionCategoria))
            {
                return BadRequest("Datos inválidos");
            }

            var resultado = await _categoriaService.CrearCategoriaAsync(categoria);
            return resultado ? Ok("Categoría creada exitosamente") : StatusCode(500, "Error al crear la categoría");
        }

        [HttpPut]
        public async Task<IActionResult> ActualizarCategoriaAsync([FromBody] Categorias categoria)
        {
            if (categoria == null || categoria.IDCategoria <= 0 || string.IsNullOrEmpty(categoria.DescripcionCategoria))
            {
                return BadRequest("Datos inválidos");
            }

            var resultado = await _categoriaService.ActualizarCategoriaAsync(categoria);
            return resultado ? Ok("Categoría actualizada exitosamente") : StatusCode(500, "Error al actualizar la categoría");
        }
        /// FIN CODIGO CATEGORIAS -----------------------------------------------------------------------------------------------

        // --------------- CODIGO CORRESPONDIENTE A LA ADMINISTRACION DE PRODUCTOS ---------------------------- //
        [HttpGet]
        public async Task<IActionResult> Productos()
        {
            var productos = await _productoService.GetProductosAsync();

            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                return Json(productos);
            }

            return View(productos);
        }

        [HttpPost]
        public async Task<IActionResult> CrearCategoria([FromBody] ProductosDTO producto)
        {
            if (producto == null || producto.IDProducto <= 0
                || string.IsNullOrEmpty(producto.DescripcionProducto)
                || string.IsNullOrEmpty(producto.NombreProducto)
                || string.IsNullOrEmpty(producto.NombreImagen)
                || producto.IDMarca == 0
                || string.IsNullOrEmpty(producto.NombreImagen)
                || producto.IDCategoria == 0
                || producto.Precio < 0
                || producto.Precio < 0)
            {
                return BadRequest("Datos inválidos");
            }

            var resultado = await _productoService.CrearProductoAsync(producto);
            return resultado ? Ok("Producto creado exitosamente") : StatusCode(500, "Error al crear el producto");
        }

        [HttpPut]
        public async Task<IActionResult> ActualizarProductoAsync([FromBody] ProductosDTO producto)
        {
            if (producto == null || producto.IDProducto <= 0 
                || string.IsNullOrEmpty(producto.DescripcionProducto) 
                || string.IsNullOrEmpty(producto.NombreProducto)
                || string.IsNullOrEmpty(producto.NombreImagen)
                || producto.IDMarca == 0
                || string.IsNullOrEmpty(producto.NombreImagen)
                || producto.IDCategoria == 0
                || producto.Precio < 0
                || producto.Precio < 0)
            {
                return BadRequest("Datos inválidos");
            }

            var resultado = await _productoService.ActualizarProductoAsync(producto); 
            return resultado ? Ok("Producto actualizado exitosamente") : StatusCode(500, "Error al actualizar el producto");
        }
        /// FIN CODIGO CATEGORIAS -----------------------------------------------------------------------------------------------


        public IActionResult Marcas()
        {
            return View();
        }
        public IActionResult GenerarVenta()
        {
            return View();
        }



    }
}
