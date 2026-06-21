using System;
using System.Collections.Generic;
using Libreria_Datos;

namespace Libreria_Negocio
{
    public class CompraNegocio
    {
        private CompraDatos _compraDatos = new CompraDatos();

        /// <summary>
        /// Registra la compra completa: cabecera + todos los detalles.
        /// Devuelve el ID de la compra creada.
        /// </summary>
        public int RegistrarCompraCompleta(CompraModel compra, List<DetalleCompraModel> detalles)
        {
            if (detalles == null || detalles.Count == 0)
                throw new Exception("La compra debe tener al menos un producto.");

            if (compra.ID_Proveedor <= 0)
                throw new Exception("Debe seleccionar un proveedor.");

            if (compra.ID_Usuario <= 0)
                throw new Exception("El usuario no es válido.");

            // Calcular total pagado desde los detalles
            decimal total = 0;
            foreach (var d in detalles)
            {
                if (d.Cantidad_Recibida <= 0)
                    throw new Exception("La cantidad recibida debe ser mayor a 0.");

                if (d.Costo_Unitario <= 0)
                    throw new Exception("El costo unitario debe ser mayor a 0.");

                total += d.Cantidad_Recibida * d.Costo_Unitario;
            }
            compra.Total_Pagado = total;

            // Registrar cabecera
            int idCompra = _compraDatos.RegistrarCompra(compra);

            // Registrar cada detalle (el SP suma el stock)
            foreach (var d in detalles)
            {
                d.ID_Compra = idCompra;
                _compraDatos.RegistrarDetalleCompra(d);
            }

            return idCompra;
        }

        public List<CompraModel> ListarComprasDelDia()
        {
            return _compraDatos.ListarComprasDelDia();
        }

        public decimal ObtenerTotalCompradoDelDia()
        {
            return _compraDatos.ObtenerTotalCompradoDelDia();
        }
    }
}
