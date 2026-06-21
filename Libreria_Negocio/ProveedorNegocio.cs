using System;
using System.Collections.Generic;
using Libreria_Datos;

namespace Libreria_Negocio
{
    public class ProveedorNegocio
    {
        private ProveedorDatos _proveedorDatos = new ProveedorDatos();

        public List<ProveedorModel> ListarProveedores()
        {
            return _proveedorDatos.ListarProveedores();
        }

        public void RegistrarProveedor(ProveedorModel proveedor)
        {
            if (string.IsNullOrWhiteSpace(proveedor.Nombre_Empresa))
                throw new Exception("El nombre de la empresa es obligatorio.");

            _proveedorDatos.RegistrarProveedor(proveedor);
        }

        public void ModificarProveedor(ProveedorModel proveedor)
        {
            if (string.IsNullOrWhiteSpace(proveedor.Nombre_Empresa))
                throw new Exception("El nombre de la empresa es obligatorio.");

            _proveedorDatos.ModificarProveedor(proveedor);
        }

        public void EliminarProveedor(int idProveedor)
        {
            if (idProveedor <= 0)
                throw new Exception("ID de proveedor no válido.");

            _proveedorDatos.EliminarProveedor(idProveedor);
        }
    }
}
