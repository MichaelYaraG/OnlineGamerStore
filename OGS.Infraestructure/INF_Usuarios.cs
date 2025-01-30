using System;
using System.Collections.Generic;
using OGS.Domain;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.IO;
using Microsoft.Extensions.Configuration;
using System.Configuration;


namespace OGS.Infraestructure
{
    public class INF_Usuarios
    {
        string conn = "Server=Maicol\\SQLEXPRESS;Database=OnlineGamerStore;User=OGStoreUser;Password=OGStoreUser@;";
      
        public List<Users> Listar()
        {
            List<Users> lista = new List<Users>();

            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    string query = "SELECT IDUsuario,Nombre1,Nombre2,Apellido1,Apellido2,NombreCompleto,CorreoElectronico,Contraseña,FechaNacimiento,Telefono,Estado FROM OnlineGamerStore.Users.tbUsers";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.CommandType = CommandType.Text;
                    connection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Users()
                            {
                                IDUsuario = Convert.ToInt32(reader["IDUsuario"]),
                                //IDTipoDocumento = Convert.ToInt32(reader["IDTipoDocumento"]),
                                Nombre1 = reader["Nombre1"].ToString(),
                                Nombre2 = reader["Nombre2"].ToString(),
                                Apellido1 = reader["Apellido1"].ToString(),
                                Apellido2 = reader["Apellido2"].ToString(),
                                NombreCompleto = reader["NombreCompleto"].ToString(),
                                CorreoElectronico = reader["CorreoElectronico"].ToString(),
                                Contraseña = reader["Contraseña"].ToString(),
                                FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]),
                                //IDSexo = Convert.ToInt32(reader["IDsexo"]),
                                Telefono = Convert.ToInt32(reader["Telefono"]),
                                Estado = Convert.ToBoolean(reader["Estado"]),

                            });

                        }
                    }

                }
            }
            catch (Exception ex)
            {
                // Retornar lista con un solo objeto indicando el error
                lista = new List<Users>
                {
                    new Users
                    {
                        IDUsuario = -1, // Indicando un valor no válido
                        Nombre1 = "Error",
                        Nombre2 = ex.Message, // Mensaje de error
                        Apellido1 = "",
                        Apellido2 = "",
                        NombreCompleto = "Error en la consulta",
                        CorreoElectronico = "",
                        Contraseña = "",
                        FechaNacimiento = DateTime.MinValue,
                        Telefono = 0,
                        Estado = false
                    }
                };
            }

            return lista;
        }
    }
}
