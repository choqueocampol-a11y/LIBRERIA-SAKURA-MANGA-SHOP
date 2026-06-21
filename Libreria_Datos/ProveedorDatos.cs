using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Libreria_Datos
{
    public class ProveedorDatos
    {
        private ConexionBD conexion = new ConexionBD();

        public List<ProveedorModel> ListarProveedores()
        {
            List<ProveedorModel> lista = new List<ProveedorModel>();

            using (SqlConnection con = conexion.Obtenerconexion())
            using (SqlCommand cmd = new SqlCommand("sp_ListarProveedores", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                using (SqlDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        lista.Add(new ProveedorModel
                        {
                            ID_Proveedor   = Convert.ToInt32(lector["ID_Proveedor"]),
                            Nombre_Empresa = lector["Nombre_Empresa"].ToString(),
                            Telefono       = lector["Telefono"].ToString()
                        });
                    }
                }
            }
            return lista;
        }

        public void RegistrarProveedor(ProveedorModel proveedor)
        {
            using (SqlConnection con = conexion.Obtenerconexion())
            using (SqlCommand cmd = new SqlCommand("sp_RegistrarProveedor", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre_Empresa", proveedor.Nombre_Empresa);
                cmd.Parameters.AddWithValue("@Telefono",       proveedor.Telefono);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ModificarProveedor(ProveedorModel proveedor)
        {
            using (SqlConnection con = conexion.Obtenerconexion())
            using (SqlCommand cmd = new SqlCommand("sp_ModificarProveedor", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_Proveedor",   proveedor.ID_Proveedor);
                cmd.Parameters.AddWithValue("@Nombre_Empresa", proveedor.Nombre_Empresa);
                cmd.Parameters.AddWithValue("@Telefono",       proveedor.Telefono);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarProveedor(int idProveedor)
        {
            using (SqlConnection con = conexion.Obtenerconexion())
            using (SqlCommand cmd = new SqlCommand("sp_EliminarProveedor", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_Proveedor", idProveedor);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
