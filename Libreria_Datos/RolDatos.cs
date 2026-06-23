using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Datos
{
    public class RolDatos
    {
        public List<RolModel> ObtenerRoles()
        {
            var lista = new List<RolModel>();
            using (var conexion = new SqlConnection(ConexionBD.Cadena))
            {
                string query = "SELECT ID_Rol, Nombre_Rol FROM Roles";
                SqlCommand cmd = new SqlCommand(query, conexion);
                conexion.Open();
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new RolModel
                        {
                            ID_Rol = Convert.ToInt32(dr["ID_Rol"]),
                            Nombre_Rol = dr["Nombre_Rol"].ToString()
                        });
                    }
                }
            }
            return lista;
        }
    }
}
