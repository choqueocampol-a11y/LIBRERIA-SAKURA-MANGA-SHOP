using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria_Datos;

namespace Libreria_Negocio
{
    public class UsuarioNegocio
    {
        private UsuarioDatos _usuarioDatos = new UsuarioDatos();
        public UsuarioModel Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                throw new Exception("El usuario y la contraseña no pueden estar vacíos.");
            }

            return _usuarioDatos.ValidarUsuario(username, password);
        }
    }
}

