using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Libreria_Datos
{
    public class VentaDatos
    {
        private ConexionBD conexion = new ConexionBD();

       
        public int RegistrarVenta(VentaModel venta)
        {
            using (SqlConnection con = conexion.Obtenerconexion())
            using (SqlCommand cmd = new SqlCommand("sp_RegistrarVenta", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_Cliente",   venta.ID_Cliente);
                cmd.Parameters.AddWithValue("@ID_Usuario",   venta.ID_Usuario);
                cmd.Parameters.AddWithValue("@Monto_Total",  venta.Monto_Total);

                SqlParameter paramId = new SqlParameter("@ID_Venta_Generado", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(paramId);

                con.Open();
                cmd.ExecuteNonQuery();
                return Convert.ToInt32(paramId.Value);
            }
        }

       
        public void RegistrarDetalleVenta(DetalleVentaModel detalle)
        {
            using (SqlConnection con = conexion.Obtenerconexion())
            using (SqlCommand cmd = new SqlCommand("sp_RegistrarDetalleVenta", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_Venta",           detalle.ID_Venta);
                cmd.Parameters.AddWithValue("@ID_Producto",        detalle.ID_Producto);
                cmd.Parameters.AddWithValue("@Cantidad",           detalle.Cantidad);
                cmd.Parameters.AddWithValue("@Precio_U_Historico", detalle.Precio_U_Historico);
                cmd.Parameters.AddWithValue("@Subtotal",           detalle.Subtotal);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<VentaModel> ListarVentasDelDia()
        {
            List<VentaModel> lista = new List<VentaModel>();

            using (SqlConnection con = conexion.Obtenerconexion())
            using (SqlCommand cmd = new SqlCommand("sp_ListarVentasDelDia", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                using (SqlDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        lista.Add(new VentaModel
                        {
                            ID_Venta       = Convert.ToInt32(lector["ID_Venta"]),
                            Nombre_Cliente = lector["Nombre_Cliente"].ToString(),
                            Nombre_Usuario = lector["Nombre_Usuario"].ToString(),
                            Fecha          = Convert.ToDateTime(lector["Fecha"]),
                            Monto_Total    = Convert.ToDecimal(lector["Monto_Total"])
                        });
                    }
                }
            }
            return lista;
        }

        public decimal ObtenerTotalVendidoDelDia()
        {
            using (SqlConnection con = conexion.Obtenerconexion())
            using (SqlCommand cmd = new SqlCommand("sp_ObtenerTotalVendidoDelDia", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                object resultado = cmd.ExecuteScalar();
                return resultado != null ? Convert.ToDecimal(resultado) : 0;
            }
        }

        public void AnularVenta(int idVenta)
        {
            using (SqlConnection con = conexion.Obtenerconexion())
            using (SqlCommand cmd = new SqlCommand("sp_AnularVenta", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_Venta", idVenta);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
