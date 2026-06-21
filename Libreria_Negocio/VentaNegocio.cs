using System;
using System.Collections.Generic;
using Libreria_Datos;

namespace Libreria_Negocio
{
    public class VentaNegocio
    {
        private VentaDatos _ventaDatos = new VentaDatos();

        /// <summary>
        /// Registra la venta completa: cabecera + todos los detalles.
        /// Devuelve el ID de la venta creada.
        /// </summary>
        public int RegistrarVentaCompleta(VentaModel venta, List<DetalleVentaModel> detalles)
        {
            if (detalles == null || detalles.Count == 0)
                throw new Exception("La venta debe tener al menos un producto.");

            if (venta.ID_Cliente <= 0)
                throw new Exception("Debe seleccionar un cliente.");

            if (venta.ID_Usuario <= 0)
                throw new Exception("El usuario no es válido.");

            // Calcular monto total desde los detalles
            decimal total = 0;
            foreach (var d in detalles)
            {
                if (d.Cantidad <= 0)
                    throw new Exception("La cantidad debe ser mayor a 0.");
                d.Subtotal = d.Cantidad * d.Precio_U_Historico;
                total += d.Subtotal;
            }
            venta.Monto_Total = total;

            // Registrar cabecera
            int idVenta = _ventaDatos.RegistrarVenta(venta);

            // Registrar cada detalle (el SP descuenta el stock)
            foreach (var d in detalles)
            {
                d.ID_Venta = idVenta;
                _ventaDatos.RegistrarDetalleVenta(d);
            }

            return idVenta;
        }

        public List<VentaModel> ListarVentasDelDia()
        {
            return _ventaDatos.ListarVentasDelDia();
        }

        public decimal ObtenerTotalVendidoDelDia()
        {
            return _ventaDatos.ObtenerTotalVendidoDelDia();
        }

        public void AnularVenta(int idVenta)
        {
            if (idVenta <= 0)
                throw new Exception("ID de venta no válido.");

            _ventaDatos.AnularVenta(idVenta);
        }
    }
}
