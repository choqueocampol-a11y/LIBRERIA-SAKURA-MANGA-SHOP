using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Libreria_Datos
{
    public class ProductoDatos
    {
        private ConexionBD conexion = new ConexionBD();

        public List<ProductoModel> ListarProductos()
        {
            List<ProductoModel> lista = new List<ProductoModel>();

            using (SqlConnection con = conexion.Obtenerconexion())
            using (SqlCommand cmd = new SqlCommand("sp_ListarProductos", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                using (SqlDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        lista.Add(new ProductoModel
                        {
                            ID_Producto     = Convert.ToInt32(lector["ID_Producto"]),
                            Nombre_Producto = lector["Nombre_Producto"].ToString(),
                            Autor           = lector["Autor"].ToString(),
                            Tomo            = lector["Tomo"].ToString(),
                            Precio_V_Actual = Convert.ToDecimal(lector["Precio_V_Actual"]),
                            Stock           = Convert.ToInt32(lector["Stock"]),
                            Ubicacion       = lector["Ubicacion"].ToString()
                        });
                    }
                }
            }
            return lista;
        }

        public List<ProductoModel> ObtenerStockMinimo()
        {
            List<ProductoModel> lista = new List<ProductoModel>();

            using (SqlConnection con = conexion.Obtenerconexion())
            using (SqlCommand cmd = new SqlCommand("sp_AlertaStockMinimo", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                using (SqlDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        lista.Add(new ProductoModel
                        {
                            ID_Producto     = Convert.ToInt32(lector["ID_Producto"]),
                            Nombre_Producto = lector["Nombre_Producto"].ToString(),
                            Tomo            = lector["Tomo"].ToString(),
                            Stock           = Convert.ToInt32(lector["Stock"]),
                            Precio_V_Actual = Convert.ToDecimal(lector["Precio_V_Actual"])
                        });
                    }
                }
            }
            return lista;
        }

        public void RegistrarProducto(ProductoModel producto)
        {
            using (SqlConnection con = conexion.Obtenerconexion())
            using (SqlCommand cmd = new SqlCommand("sp_RegistrarProducto", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre_Producto", producto.Nombre_Producto);
                cmd.Parameters.AddWithValue("@Autor",           producto.Autor);
                cmd.Parameters.AddWithValue("@Tomo",            producto.Tomo);
                cmd.Parameters.AddWithValue("@Precio_V_Actual", producto.Precio_V_Actual);
                cmd.Parameters.AddWithValue("@Stock",           producto.Stock);
                cmd.Parameters.AddWithValue("@Ubicacion",       producto.Ubicacion);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ModificarProducto(ProductoModel producto)
        {
            using (SqlConnection con = conexion.Obtenerconexion())
            using (SqlCommand cmd = new SqlCommand("sp_ModificarProducto", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_Producto",     producto.ID_Producto);
                cmd.Parameters.AddWithValue("@Nombre_Producto", producto.Nombre_Producto);
                cmd.Parameters.AddWithValue("@Autor",           producto.Autor);
                cmd.Parameters.AddWithValue("@Tomo",            producto.Tomo);
                cmd.Parameters.AddWithValue("@Precio_V_Actual", producto.Precio_V_Actual);
                cmd.Parameters.AddWithValue("@Stock",           producto.Stock);
                cmd.Parameters.AddWithValue("@Ubicacion",       producto.Ubicacion);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarProducto(int idProducto)
        {
            using (SqlConnection con = conexion.Obtenerconexion())
            using (SqlCommand cmd = new SqlCommand("sp_EliminarProducto", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_Producto", idProducto);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
