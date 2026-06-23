using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria_Datos;

namespace Libreria_Negocio
{
    public class RolNegocio
    {
        private readonly RolDatos _rolDatos = new RolDatos();

        public List<RolModel> ListarRoles()
        {
            return _rolDatos.ObtenerRoles();
        }
    }
}
