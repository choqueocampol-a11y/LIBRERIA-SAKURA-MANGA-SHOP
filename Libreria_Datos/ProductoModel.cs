using System;

namespace Libreria_Datos
{
    public class ProductoModel
    {
        public int ID_Producto { get; set; }
        public string Nombre_Producto { get; set; }
        public string Autor { get; set; }
        public string Tomo { get; set; }
        public decimal Precio_V_Actual { get; set; }
        public int Stock { get; set; }
        public string Ubicacion { get; set; }
    }
}
