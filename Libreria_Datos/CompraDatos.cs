using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Libreria_Datos
{
    public class CompraDatos
    {
        private ConexionBD conexion = new ConexionBD();

        /// <summary>
        /// Registra la cabecera de la compra y devuelve el ID generado.
        /// </summary>
        public int RegistrarCompra(CompraModel compra)
        {
            using (SqlConnection con = conexion.Obtenerconexion())
            using (SqlCommand cmd = new SqlCommand("sp_RegistrarCompra", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_Proveedor",  compra.ID_Proveedor);
                cmd.Parameters.AddWithValue("@ID_Usuario",    compra.ID_Usuario);
                cmd.Parameters.AddWithValue("@Total_Pagado",  compra.Total_Pagado);

                SqlParameter paramId = new SqlParameter("@ID_Compra_Generado", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(paramId);

                con.Open();
                cmd.ExecuteNonQuery();
                return Convert.ToInt32(paramId.Value);
            }
        }

        /// <summary>
        /// Registra un renglón del detalle y suma el stock automáticamente (el SP lo hace).
        /// </summary>
        public void RegistrarDetalleCompra(DetalleCompraModel detalle)
        {
            using (SqlConnection con = conexion.Obtenerconexion())
            using (SqlCommand cmd = new SqlCommand("sp_RegistrarDetalleCompra", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_Compra",         detalle.ID_Compra);
                cmd.Parameters.AddWithValue("@ID_Producto",       detalle.ID_Producto);
                cmd.Parameters.AddWithValue("@Cantidad_Recibida", detalle.Cantidad_Recibida);
                cmd.Parameters.AddWithValue("@Costo_Unitario",    detalle.Costo_Unitario);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<CompraModel> ListarComprasDelDia()
        {
            List<CompraModel> lista = new List<CompraModel>();

            using (SqlConnection con = conexion.Obtenerconexion())
            using (SqlCommand cmd = new SqlCommand("sp_ListarComprasDelDia", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                using (SqlDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        lista.Add(new CompraModel
                        {
                            ID_Compra       = Convert.ToInt32(lector["ID_Compra"]),
                            Nombre_Proveedor = lector["Nombre_Proveedor"].ToString(),
                            Nombre_Usuario  = lector["Nombre_Usuario"].ToString(),
                            Fecha           = Convert.ToDateTime(lector["Fecha"]),
                            Total_Pagado    = Convert.ToDecimal(lector["Total_Pagado"])
                        });
                    }
                }
            }
            return lista;
        }

        public decimal ObtenerTotalCompradoDelDia()
        {
            using (SqlConnection con = conexion.Obtenerconexion())
            using (SqlCommand cmd = new SqlCommand("sp_ObtenerTotalCompradoDelDia", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                object resultado = cmd.ExecuteScalar();
                return resultado != null ? Convert.ToDecimal(resultado) : 0;
            }
        }
    }
}
