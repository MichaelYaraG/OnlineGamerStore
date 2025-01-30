using Microsoft.AspNetCore.Mvc;
using OnlineGamerStoreAdmin.Models;
using System.Diagnostics;
using AspNetCoreGeneratedDocument;
using OGS.Infraestructure;
using OGS.Domain;
using OGS.Application;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace OnlineGamerStoreAdmin.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
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



        public IActionResult Clientes()
        {
            List<Clientes> clientes = new List<Clientes>();
            string connectionString = _configuration.GetConnectionString("DefaultConnection");

           
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new Exception("Error: La cadena de conexión no está inicializada.");
            }

            Console.WriteLine("Cadena de conexión obtenida: " + connectionString);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT IDCliente,NumeroDocumento,NombreCompleto FROM OnlineGamerStore.OGS.tbClientes";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    clientes.Add(new Clientes
                    {
                        IDCliente = reader.GetInt32(0),
                        NumeroDocumento = reader.GetInt32(1),
                        NombreCompleto = reader.GetString(2),


                    });
                }

                connection.Close();
            }

            return View(clientes);
        }

  
    }



}