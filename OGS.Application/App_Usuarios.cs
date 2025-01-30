using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OGS.Domain;
using OGS.Infraestructure;


namespace OGS.Application
{
    public class App_Usuarios
    {
        private INF_Usuarios objUsuarios = new INF_Usuarios();

        public List<Users> Listar()
        {
            return objUsuarios.Listar();
        }
    }
}
