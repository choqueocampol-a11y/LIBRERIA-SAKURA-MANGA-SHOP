using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Libreria_Datos
{
    public class UsuarioDatos
    {
        private ConexionBD conexion = new ConexionBD ();

        public UsuarioModel ValidarUsuario(string username, string password)
        {
            UsuarioModel usuarioEncontrado = null;

            using (SqlConnection con = conexion.Obtenerconexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_ValidarUsuario", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure; 
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        con.Open(); 

                        using (SqlDataReader lector = cmd.ExecuteReader())
                        {
                            if (lector.Read()) 
                            {
                                usuarioEncontrado = new UsuarioModel()
                                {
                                    ID_Usuario = Convert.ToInt32(lector["ID_Usuario"]),
                                    Nombre = lector["Nombre"].ToString(),
                                    Username = lector["Username"].ToString(),
                                    Nombre_Rol = lector["Nombre_Rol"].ToString()
                                };
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error al conectar con la base de datos: " + ex.Message);
                    }
                }
            }

            return usuarioEncontrado;
        }
    }
}
    

