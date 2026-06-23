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
        public static string Cadena = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Libreria;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";

        public SqlConnection Obtenerconexion()
        {
            return new SqlConnection(Cadena);

    }
}

}
