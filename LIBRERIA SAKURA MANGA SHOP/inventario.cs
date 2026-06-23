using System;
using System.Linq;
using System.Windows.Forms;
using Libreria_Datos;
using Libreria_Negocio;

namespace LIBRERIA_SAKURA_MANGA_SHOP
{
    public partial class inventario : Form
    {
        private readonly ProductoNegocio _productoNegocio = new ProductoNegocio();

        public inventario()
        {
            InitializeComponent();
            this.Load += inventario_Load;
        }

        private void inventario_Load(object sender, EventArgs e)
        {
            dgvInventario.AllowUserToAddRows = false;
            dgvAlertaStock.AllowUserToAddRows = false;

            CargarProductos();
            CargarAlertaStock();
        }

      
        private void CargarProductos()
        {
            try
            {
                var productos = _productoNegocio.ListarProductos();
                MostrarProductosEnGrid(productos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los productos: " + ex.Message,
                                 "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool _columnaIdAgregada = false;

        private void MostrarProductosEnGrid(System.Collections.Generic.List<ProductoModel> productos)
        {
           
            if (!_columnaIdAgregada)
            {
                var colId = new DataGridViewTextBoxColumn
                {
                    Name = "ID_Producto_Oculto",
                    Visible = false
                };
                dgvInventario.Columns.Add(colId);
                _columnaIdAgregada = true;
            }

            dgvInventario.Rows.Clear();

            foreach (var p in productos)
            {
                int fila = dgvInventario.Rows.Add(
                    p.Nombre_Producto,
                    p.Tomo,
                    p.Precio_V_Actual.ToString("C2"),
                    p.Stock,
                    p.Ubicacion,
                    p.ID_Producto
                );
            }
        }

        private void CargarAlertaStock()
        {
            try
            {
                var stockMinimo = _productoNegocio.ObtenerStockMinimo();

                dgvAlertaStock.Rows.Clear();
                foreach (var p in stockMinimo)
                {
                    dgvAlertaStock.Rows.Add(p.Nombre_Producto, p.Tomo, p.Stock);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la alerta de stock mínimo: " + ex.Message,
                                 "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            FiltrarProductos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FiltrarProductos();
        }

        private void FiltrarProductos()
        {
            try
            {
                string filtro = txtBuacarProducto.Text.Trim().ToLower();
                var todos = _productoNegocio.ListarProductos();

                var filtrados = string.IsNullOrEmpty(filtro)
                    ? todos
                    : todos.Where(p =>
                        (p.Nombre_Producto ?? "").ToLower().Contains(filtro) ||
                        (p.Autor ?? "").ToLower().Contains(filtro) ||
                        (p.Tomo ?? "").ToLower().Contains(filtro)).ToList();

                MostrarProductosEnGrid(filtrados);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo filtrar: " + ex.Message,
                                 "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butProducto_Click(object sender, EventArgs e)
        {
            using (var dialogo = new FormProducto())
            {
                if (dialogo.ShowDialog(this) == DialogResult.OK && dialogo.ProductoResultado != null)
                {
                    try
                    {
                        _productoNegocio.RegistrarProducto(dialogo.ProductoResultado);
                        MessageBox.Show("Producto registrado correctamente. 🌸",
                                         "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarProductos();
                        CargarAlertaStock();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo registrar el producto: " + ex.Message,
                                         "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private ProductoModel ObtenerProductoSeleccionado()
        {
            if (dgvInventario.CurrentRow == null)
                return null;

            int idProducto = (int)dgvInventario.CurrentRow.Cells["ID_Producto_Oculto"].Value;

            return _productoNegocio.ListarProductos().FirstOrDefault(p => p.ID_Producto == idProducto);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var productoSeleccionado = ObtenerProductoSeleccionado();
            if (productoSeleccionado == null)
            {
                MessageBox.Show("Selecciona un producto de la lista para modificarlo.",
                                 "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var dialogo = new FormProducto(productoSeleccionado))
            {
                if (dialogo.ShowDialog(this) == DialogResult.OK && dialogo.ProductoResultado != null)
                {
                    try
                    {
                        _productoNegocio.ModificarProducto(dialogo.ProductoResultado);
                        MessageBox.Show("Producto actualizado correctamente. 🌸",
                                         "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarProductos();
                        CargarAlertaStock();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo actualizar el producto: " + ex.Message,
                                         "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var productoSeleccionado = ObtenerProductoSeleccionado();
            if (productoSeleccionado == null)
            {
                MessageBox.Show("Selecciona un producto de la lista para eliminarlo.",
                                 "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacion = MessageBox.Show($"¿Seguro que deseas eliminar '{productoSeleccionado.Nombre_Producto}'?",
                                                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion != DialogResult.Yes)
                return;

            try
            {
                _productoNegocio.EliminarProducto(productoSeleccionado.ID_Producto);
                MessageBox.Show("Producto eliminado correctamente.",
                                 "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarProductos();
                CargarAlertaStock();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar el producto: " + ex.Message,
                                 "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dgvAlertaStock_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void pictureBox3_Click(object sender, EventArgs e) { }
    }
}
