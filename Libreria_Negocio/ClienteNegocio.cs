using System;
using System.Collections.Generic;
using Libreria_Datos;

namespace Libreria_Negocio
{
    public class ClienteNegocio
    {
        private ClienteDatos _clienteDatos = new ClienteDatos();

        public List<ClienteModel> ListarClientes()
        {
            return _clienteDatos.ListarClientes();
        }

        public void RegistrarCliente(ClienteModel cliente)
        {
            if (string.IsNullOrWhiteSpace(cliente.Nombre))
                throw new Exception("El nombre del cliente es obligatorio.");

            _clienteDatos.RegistrarCliente(cliente);
        }

        public void ModificarCliente(ClienteModel cliente)
        {
            if (string.IsNullOrWhiteSpace(cliente.Nombre))
                throw new Exception("El nombre del cliente es obligatorio.");

            _clienteDatos.ModificarCliente(cliente);
        }

        public void EliminarCliente(int idCliente)
        {
            if (idCliente <= 0)
                throw new Exception("ID de cliente no válido.");

            _clienteDatos.EliminarCliente(idCliente);
        }
    }
}
