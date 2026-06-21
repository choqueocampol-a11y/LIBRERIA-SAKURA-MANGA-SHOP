using System;
using System.Collections.Generic;
using Libreria_Datos;

namespace Libreria_Negocio
{
    public class ProductoNegocio
    {
        private ProductoDatos _productoDatos = new ProductoDatos();

        public List<ProductoModel> ListarProductos()
        {
            return _productoDatos.ListarProductos();
        }

        public List<ProductoModel> ObtenerStockMinimo()
        {
            return _productoDatos.ObtenerStockMinimo();
        }

        public void RegistrarProducto(ProductoModel producto)
        {
            if (string.IsNullOrWhiteSpace(producto.Nombre_Producto))
                throw new Exception("El nombre del producto es obligatorio.");

            if (producto.Precio_V_Actual <= 0)
                throw new Exception("El precio debe ser mayor a 0.");

            if (producto.Stock < 0)
                throw new Exception("El stock no puede ser negativo.");

            _productoDatos.RegistrarProducto(producto);
        }

        public void ModificarProducto(ProductoModel producto)
        {
            if (string.IsNullOrWhiteSpace(producto.Nombre_Producto))
                throw new Exception("El nombre del producto es obligatorio.");

            if (producto.Precio_V_Actual <= 0)
                throw new Exception("El precio debe ser mayor a 0.");

            _productoDatos.ModificarProducto(producto);
        }

        public void EliminarProducto(int idProducto)
        {
            if (idProducto <= 0)
                throw new Exception("ID de producto no válido.");

            _productoDatos.EliminarProducto(idProducto);
        }
    }
}
