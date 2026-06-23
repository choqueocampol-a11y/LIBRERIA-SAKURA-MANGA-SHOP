using Libreria_Datos;
using System;
using System.Collections.Generic;

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

        public List<UsuarioModel> ListarUsuarios()
        {
            return _usuarioDatos.ListarUsuarios();
        }

        public void RegistrarUsuario(UsuarioModel usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario.Nombre) || string.IsNullOrWhiteSpace(usuario.Username))
            {
                throw new Exception("Nombre y usuario son requeridos.");
            }

            _usuarioDatos.RegistrarUsuario(usuario);
        }

        public void ModificarUsuario(UsuarioModel usuario)
        {
            if (usuario.ID_Usuario <= 0 || string.IsNullOrWhiteSpace(usuario.Nombre) || string.IsNullOrWhiteSpace(usuario.Username))
            {
                throw new Exception("Datos incompletos para modificar.");
            }

            _usuarioDatos.ModificarUsuario(usuario);
        }

        public void EliminarUsuario(int idUsuario)
        {
            if (idUsuario <= 0)
            {
                throw new Exception("ID de usuario inválido.");
            }

            _usuarioDatos.EliminarUsuario(idUsuario);
        }
    }
}

