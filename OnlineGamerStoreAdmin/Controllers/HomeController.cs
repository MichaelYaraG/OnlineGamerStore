using Microsoft.AspNetCore.Mvc;
using OnlineGamerStoreAdmin.Models;
using System.Diagnostics;
using AspNetCoreGeneratedDocument;
using OGS.Infraestructure;
using OGS.Domain;
using OGS.Application;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace OnlineGamerStoreAdmin.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult DetalleVentas()
        {
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }





    }



}