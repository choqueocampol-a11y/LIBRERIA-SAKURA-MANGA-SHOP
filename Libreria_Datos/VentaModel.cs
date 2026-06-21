using System;

namespace Libreria_Datos
{
    public class VentaModel
    {
        public int ID_Venta { get; set; }
        public int ID_Cliente { get; set; }
        public int ID_Usuario { get; set; }
        public string Nombre_Cliente { get; set; }
        public string Nombre_Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto_Total { get; set; }
        public string Estado { get; set; }
    }

    public class DetalleVentaModel
    {
        public int ID_Venta { get; set; }
        public int ID_Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio_U_Historico { get; set; }
        public decimal Subtotal { get; set; }
    }
}
