using Microsoft.AspNetCore.Mvc;
using OGS.Infraestructure;

namespace OnlineGamerStoreAdmin.Controllers
{
    public class AdministrationController : Controller
    {
        public IActionResult Productos()
        {
            return View();
        }
        public IActionResult Categorias()
        {
            return View();
        }
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
