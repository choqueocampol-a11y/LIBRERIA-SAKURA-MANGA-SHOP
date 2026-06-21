using System;

namespace Libreria_Datos
{
    public class CompraModel
    {
        public int ID_Compra { get; set; }
        public int ID_Proveedor { get; set; }
        public int ID_Usuario { get; set; }
        public string Nombre_Proveedor { get; set; }
        public string Nombre_Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total_Pagado { get; set; }
        public string Estado { get; set; }
    }

    public class DetalleCompraModel
    {
        public int ID_Compra { get; set; }
        public int ID_Producto { get; set; }
        public int Cantidad_Recibida { get; set; }
        public decimal Costo_Unitario { get; set; }
    }
}
