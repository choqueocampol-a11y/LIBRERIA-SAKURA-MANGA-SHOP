using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Libreria_Datos
{
    public class ConexionBD
    {
        private string conexion_base_de_datos= "Data Source=CUCARACHA\\SQLEXPRESS;Initial Catalog=Libreria;Integrated Security=True;";

        public SqlConnection Obtenerconexion ()
        {
            return new SqlConnection(conexion_base_de_datos);
        }
          
    }
}
