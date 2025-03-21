﻿using Microsoft.AspNetCore.Mvc;
using OGS.Application.Services;
using OGS.Application;
using OGS.Infraestructure;
using OGS.Domain;
using OGS.Infraestructure.Repository;

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

        public async Task<IActionResult> EliminarCategoriaAsync([FromBody] EliminarCategoriaRequest data)
        {
            if (data == null || data.IDCategoria == 0)
            {
                return BadRequest("Datos inválidos");
            }
            int IDCategoria = data.IDCategoria;
            var resultado = await _categoriaService.EliminarCategoriaAsync(IDCategoria);
            return resultado ? Ok("Categoría eliminada exitosamente") : StatusCode(500, "Error al eliminar la categoría");
        }

        /// FIN CODIGO CATEGORIAS -----------------------------------------------------------------------------------------------


        //--------------- CODIGO CORRESPONDIENTE A LA ADMINISTRACION DE MARCAS ---------------------------- //


        [HttpGet]

        public async Task<IActionResult> Marcas()
        {
            var marcas = await _marcaService.GetMarcasAsync();
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                return Json(marcas);
            }
            return View(marcas);
        }

        [HttpPost]
        public async Task<IActionResult> CrearMarca([FromBody] Marcas marca)
        {
            if (marca == null || string.IsNullOrEmpty(marca.DescripcionMarca))
            {
                return BadRequest("Datos inválidos");
            }
            var resultado = await _marcaService.CrearMarcaAsync(marca);
            return resultado ? Ok("Marca creada exitosamente") : StatusCode(500, "Error al crear la marca");
        }

        [HttpPut]
        public async Task<IActionResult> ActualizarMarcaAsync([FromBody] Marcas marca)
        {
            if (marca == null || marca.IDMarca <= 0 || string.IsNullOrEmpty(marca.DescripcionMarca))
            {
                return BadRequest("Datos inválidos");
            }
            var resultado = await _marcaService.ActualizarMarcaAsync(marca);
            return resultado ? Ok("Marca actualizada exitosamente") : StatusCode(500, "Error al actualizar la marca");
        }

        [HttpPost]
        public async Task<IActionResult> EliminarMarcaAsync([FromBody] EliminarMarcaRequest data)
        {
            if (data == null || data.IDMarca == 0)
            {
                return BadRequest("Datos inválidos");
            }
            int IDMarca = data.IDMarca;
            var resultado = await _marcaService.EliminarMarcaAsync(IDMarca);
            return resultado ? Ok("Marca eliminada exitosamente") : StatusCode(500, "Error al eliminar la marca");
        }




        // FIN CODIGO MARCAS -----------------------------------------------------------------------------------------------

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
        public async Task<IActionResult> CrearProducto([FromBody] ProductosDTO producto)
        {
            if (producto == null || string.IsNullOrEmpty(producto.DescripcionProducto)
                || string.IsNullOrEmpty(producto.NombreProducto)
                //|| string.IsNullOrEmpty(producto.NombreImagen)
                || producto.IDMarca == 0
                //|| string.IsNullOrEmpty(producto.NombreImagen)
                || producto.IDCategoria == 0
                || producto.Precio < 0)
                //|| producto.Precio < 0)
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
                || producto.Stock < 0
                || producto.Precio < 0)
            {
                return BadRequest("Datos inválidos");
            }

            var resultado = await _productoService.ActualizarProductoAsync(producto); 
            return resultado ? Ok("Producto actualizado exitosamente") : StatusCode(500, "Error al actualizar el producto");
        }

        [HttpPost]
        public async Task<IActionResult> EliminarProductoAsync([FromBody] EliminarProductoRequest data)
        {
            if (data == null || data.IDProducto == 0)
            {
                return BadRequest("Datos inválidos");
            }
            int IDProducto = data.IDProducto;
            var resultado = await _productoService.EliminarProductoAsync(IDProducto);
            return resultado ? Ok("Producto eliminado exitosamente") : StatusCode(500, "Error al eliminar el producto");
        }

        [HttpPost]
        public async Task<IActionResult> SubirImagenAsync(IFormFile imagen)
        {
            if (imagen == null || imagen.Length == 0)
            {
                return BadRequest(new { message = "No se ha proporcionado ninguna imagen." });
            }

            try
            {
                
                var nombreArchivo = imagen.FileName;
                var ruta = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/imagenes", nombreArchivo);

                using (var stream = new FileStream(ruta, FileMode.Create))
                {
                    await imagen.CopyToAsync(stream);
                }

                return Ok(new { nombreImagen = nombreArchivo, rutaImagen = $"/imagenes/{nombreArchivo}" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Error al guardar la imagen.", error = ex.Message });
            }
        }

        [HttpGet]
        public async Task<IActionResult> DDLMarcas() 
        {
            var marcas = await _productoService.ObtenerMarcasAsync();
            return Ok(marcas);
        }
        [HttpGet]
        public async Task<IActionResult> DDLCategorias()
        {
            var categorias = await _productoService.ObtenerCategoriasAsync();
            return Ok(categorias);
        }

        /// FIN CODIGO PRODUCTOS -----------------------------------------------------------------------------------------------


        public IActionResult GenerarVenta()
        {
            return View();
        }



    }
}
