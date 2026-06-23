using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Libreria_Datos
{
    public class UsuarioDatos
    {
        private ConexionBD conexion = new ConexionBD();

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

        
        public List<UsuarioModel> ListarUsuarios()
        {
            List<UsuarioModel> lista = new List<UsuarioModel>();

            using (SqlConnection con = conexion.Obtenerconexion())
            using (SqlCommand cmd = new SqlCommand("sp_ListarUsuarios", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                using (SqlDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        lista.Add(new UsuarioModel
                        {
                            ID_Usuario = Convert.ToInt32(lector["ID_Usuario"]),
                            Nombre = lector["Nombre"].ToString(),
                            Username = lector["Username"].ToString(),
                            Nombre_Rol = lector["Nombre_Rol"].ToString()
                        });
                    }
                }
            }
            return lista;
        }

       
        public void RegistrarUsuario(UsuarioModel usuario)
        {
            using (SqlConnection con = conexion.Obtenerconexion())
            using (SqlCommand cmd = new SqlCommand("sp_RegistrarUsuario", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@Username", usuario.Username);
                cmd.Parameters.AddWithValue("@Password", usuario.Password ?? string.Empty);
                cmd.Parameters.AddWithValue("@ID_Rol", usuario.ID_Rol);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        
        public void ModificarUsuario(UsuarioModel usuario)
        {
            using (SqlConnection con = conexion.Obtenerconexion())
            using (SqlCommand cmd = new SqlCommand("sp_ModificarUsuario", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_Usuario", usuario.ID_Usuario);
                cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@Username", usuario.Username);
                cmd.Parameters.AddWithValue("@Password", usuario.Password ?? string.Empty);
                cmd.Parameters.AddWithValue("@ID_Rol", usuario.ID_Rol); 
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        
        public void EliminarUsuario(int idUsuario)
        {
            using (SqlConnection con = conexion.Obtenerconexion())
            using (SqlCommand cmd = new SqlCommand("sp_EliminarUsuario", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_Usuario", idUsuario);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}


