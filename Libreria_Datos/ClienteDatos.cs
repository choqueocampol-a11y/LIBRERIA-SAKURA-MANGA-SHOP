using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Libreria_Datos
{
    public class ClienteDatos
    {
        private ConexionBD conexion = new ConexionBD();

        public List<ClienteModel> ListarClientes()
        {
            List<ClienteModel> lista = new List<ClienteModel>();

            using (SqlConnection con = conexion.Obtenerconexion())
            using (SqlCommand cmd = new SqlCommand("sp_ListarClientes", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                using (SqlDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        lista.Add(new ClienteModel
                        {
                            ID_Cliente = Convert.ToInt32(lector["ID_Cliente"]),
                            Nombre     = lector["Nombre"].ToString(),
                            Celular    = lector["Celular"].ToString(),
                            Gmail      = lector["Gmail"].ToString()
                        });
                    }
                }
            }
            return lista;
        }

        public void RegistrarCliente(ClienteModel cliente)
        {
            using (SqlConnection con = conexion.Obtenerconexion())
            using (SqlCommand cmd = new SqlCommand("sp_RegistrarCliente", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre",  cliente.Nombre);
                cmd.Parameters.AddWithValue("@Celular", cliente.Celular);
                cmd.Parameters.AddWithValue("@Gmail",   cliente.Gmail);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ModificarCliente(ClienteModel cliente)
        {
            using (SqlConnection con = conexion.Obtenerconexion())
            using (SqlCommand cmd = new SqlCommand("sp_ModificarCliente", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_Cliente", cliente.ID_Cliente);
                cmd.Parameters.AddWithValue("@Nombre",     cliente.Nombre);
                cmd.Parameters.AddWithValue("@Celular",    cliente.Celular);
                cmd.Parameters.AddWithValue("@Gmail",      cliente.Gmail);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarCliente(int idCliente)
        {
            using (SqlConnection con = conexion.Obtenerconexion())
            using (SqlCommand cmd = new SqlCommand("sp_EliminarCliente", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_Cliente", idCliente);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
