using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Libreria_Datos;
using Libreria_Negocio;

namespace LIBRERIA_SAKURA_MANGA_SHOP
{
    public partial class compraProveedor : Form
    {
        private readonly ProveedorNegocio _proveedorNegocio = new ProveedorNegocio();
        private readonly CompraNegocio _compraNegocio = new CompraNegocio();

        private ProductoModel _productoElegido;
        private readonly Dictionary<int, DetalleCompraModel> _detalleCompra = new Dictionary<int, DetalleCompraModel>();
        private readonly Dictionary<int, string> _nombresProductoDetalle = new Dictionary<int, string>();

        private int _idProveedorSeleccionado = 0;
        private List<ProveedorModel> _proveedoresCache = new List<ProveedorModel>();

        public compraProveedor()
        {
            InitializeComponent();
            dataGridViewProveedores.SelectionChanged -= dataGridViewProveedores_SelectionChanged; 

            dataGridViewDetalleCompra.AllowUserToAddRows = false;
            dataGridViewProveedores.AllowUserToAddRows = false;

            comboBoxUsuario.Items.Clear();
            if (SesionActual.UsuarioLogueado != null)
                comboBoxUsuario.Items.Add(SesionActual.UsuarioLogueado.Nombre);
            else
                comboBoxUsuario.Items.Add("Sin sesión");

            comboBoxUsuario.SelectedIndex = 0;
            comboBoxUsuario.Enabled = false;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.Enabled = false;

            CargarProveedoresCombo();
            CargarProveedoresGrid();
            ActualizarTotalCompra();

            dataGridViewProveedores.SelectionChanged += dataGridViewProveedores_SelectionChanged;
        }

        private void compraProveedor_Load(object sender, EventArgs e)
        {

        }

        
        private void CargarProveedoresCombo()
        {
            try
            {
                var proveedores = _proveedorNegocio.ListarProveedores();
                comboBoxProveedorCompra.DataSource = proveedores;
                comboBoxProveedorCompra.DisplayMember = "Nombre_Empresa";
                comboBoxProveedorCompra.ValueMember = "ID_Proveedor";
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los proveedores: " + ex.Message,
                                 "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSeleccionarProducto_Click(object sender, EventArgs e)
        {
            using (var dialogo = new FormSeleccionarProducto())
            {
                if (dialogo.ShowDialog(this) == DialogResult.OK && dialogo.ProductoSeleccionado != null)
                {
                    _productoElegido = dialogo.ProductoSeleccionado;
                    textBoxBuscarProducto.Text = $"{_productoElegido.Nombre_Producto} (Stock actual: {_productoElegido.Stock})";
                    textBoxCostoUnitario.Text = "0";
                    numericUpDownCantidadRecibida.Value = 1;
                }
            }
        }

        private void buttonAgregarDetalle_Click(object sender, EventArgs e)
        {
            if (_productoElegido == null)
            {
                MessageBox.Show("Selecciona un producto antes de agregarlo al detalle.",
                                 "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int cantidad = (int)numericUpDownCantidadRecibida.Value;

            if (!decimal.TryParse(textBoxCostoUnitario.Text, out decimal costo) || costo <= 0)
            {
                MessageBox.Show("Ingresa un costo unitario válido, mayor a 0.",
                                 "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_detalleCompra.TryGetValue(_productoElegido.ID_Producto, out var existente))
            {
                existente.Cantidad_Recibida += cantidad;
                existente.Costo_Unitario = costo;
            }
            else
            {
                _detalleCompra[_productoElegido.ID_Producto] = new DetalleCompraModel
                {
                    ID_Producto = _productoElegido.ID_Producto,
                    Cantidad_Recibida = cantidad,
                    Costo_Unitario = costo
                };
                _nombresProductoDetalle[_productoElegido.ID_Producto] = _productoElegido.Nombre_Producto;
            }

            ActualizarGridDetalle();
            ActualizarTotalCompra();

            _productoElegido = null;
            textBoxBuscarProducto.Clear();
            textBoxCostoUnitario.Clear();
            numericUpDownCantidadRecibida.Value = 1;
        }

        private void ActualizarGridDetalle()
        {
            dataGridViewDetalleCompra.Rows.Clear();

            foreach (var item in _detalleCompra.Values)
            {
                decimal subtotal = item.Cantidad_Recibida * item.Costo_Unitario;
                dataGridViewDetalleCompra.Rows.Add(
                    item.ID_Producto,
                    _nombresProductoDetalle[item.ID_Producto],
                    item.Cantidad_Recibida,
                    item.Costo_Unitario.ToString("C2"),
                    subtotal.ToString("C2")
                );
            }
        }

        private void ActualizarTotalCompra()
        {
            decimal total = _detalleCompra.Values.Sum(d => d.Cantidad_Recibida * d.Costo_Unitario);
            textBoxTotalCompra.Text = total.ToString("C2");
        }

        private void buttonRegistrarCompra_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelarCompra_Click(object sender, EventArgs e)
        {

        }

        private void LimpiarCompra()
        {
            _detalleCompra.Clear();
            _nombresProductoDetalle.Clear();
            _productoElegido = null;
            textBoxBuscarProducto.Clear();
            textBoxCostoUnitario.Clear();
            numericUpDownCantidadRecibida.Value = 1;
            ActualizarGridDetalle();
            ActualizarTotalCompra();
        }

        private void CargarProveedoresGrid()
        {
            try
            {
                _proveedoresCache = _proveedorNegocio.ListarProveedores();
                MostrarProveedoresEnGrid(_proveedoresCache);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los proveedores: " + ex.Message,
                                 "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarProveedoresEnGrid(List<ProveedorModel> proveedores)
        {
            dataGridViewProveedores.Rows.Clear();
            foreach (var p in proveedores)
            {
                dataGridViewProveedores.Rows.Add(p.ID_Proveedor, p.Nombre_Empresa, p.Telefono);
            }
        }

        private void buttonBuscarProveedor_Click(object sender, EventArgs e)
        {
            string filtro = textBoxBuscarProveedor.Text.Trim().ToLower();

            var filtrados = string.IsNullOrEmpty(filtro)
                ? _proveedoresCache
                : _proveedoresCache.Where(p => (p.Nombre_Empresa ?? "").ToLower().Contains(filtro)).ToList();

            MostrarProveedoresEnGrid(filtrados);
        }

        private void buttonRegistrarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                var proveedor = new ProveedorModel
                {
                    Nombre_Empresa = textBoxNombreEmpresa.Text.Trim(),
                    Telefono = textBoxTelefono.Text.Trim()
                };

                _proveedorNegocio.RegistrarProveedor(proveedor);
                MessageBox.Show("Proveedor registrado correctamente. 🌸",
                                 "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormularioProveedor();
                CargarProveedoresGrid();
                CargarProveedoresCombo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo registrar el proveedor: " + ex.Message,
                                 "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonModificarProveedor_Click(object sender, EventArgs e)
        {
            if (_idProveedorSeleccionado == 0)
            {
                MessageBox.Show("Selecciona un proveedor de la lista para modificarlo.",
                                 "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var proveedor = new ProveedorModel
                {
                    ID_Proveedor = _idProveedorSeleccionado,
                    Nombre_Empresa = textBoxNombreEmpresa.Text.Trim(),
                    Telefono = textBoxTelefono.Text.Trim()
                };

                _proveedorNegocio.ModificarProveedor(proveedor);
                MessageBox.Show("Proveedor actualizado correctamente. 🌸",
                                 "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormularioProveedor();
                CargarProveedoresGrid();
                CargarProveedoresCombo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar el proveedor: " + ex.Message,
                                 "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEliminarProveedor_Click(object sender, EventArgs e)
        {
            if (_idProveedorSeleccionado == 0)
            {
                MessageBox.Show("Selecciona un proveedor de la lista para eliminarlo.",
                                 "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacion = MessageBox.Show("¿Seguro que deseas eliminar este proveedor?",
                                                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion != DialogResult.Yes)
                return;

            try
            {
                _proveedorNegocio.EliminarProveedor(_idProveedorSeleccionado);
                MessageBox.Show("Proveedor eliminado correctamente.",
                                 "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormularioProveedor();
                CargarProveedoresGrid();
                CargarProveedoresCombo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar el proveedor: " + ex.Message,
                                 "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLimpiarProveedor_Click(object sender, EventArgs e)
        {
            LimpiarFormularioProveedor();
        }

        private void LimpiarFormularioProveedor()
        {
            _idProveedorSeleccionado = 0;
            textBoxNombreEmpresa.Clear();
            textBoxTelefono.Clear();
        }

        private void dataGridViewProveedores_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewProveedores.CurrentRow == null) return;
            if (dataGridViewProveedores.CurrentRow.Index < 0) return;

            var celdaId = dataGridViewProveedores.CurrentRow.Cells["ID_Proveedor"].Value;
            if (celdaId == null || celdaId == DBNull.Value) return; // ← evita fila vacía

            _idProveedorSeleccionado = Convert.ToInt32(celdaId);
            textBoxNombreEmpresa.Text = dataGridViewProveedores.CurrentRow.Cells["Nombre_Empresa"].Value?.ToString();
            textBoxTelefono.Text = dataGridViewProveedores.CurrentRow.Cells["Telefono"].Value?.ToString();
        }

        
        private void labelCosto_Click(object sender, EventArgs e) { }
        private void comboBoxUsuario_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void panelCabeceraCompra_Paint(object sender, PaintEventArgs e) { }
        private void comboBoxProveedorCompra_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void textBoxBuscarProducto_TextChanged(object sender, EventArgs e) { }
        private void numericUpDownCantidadRecibida_ValueChanged(object sender, EventArgs e) { }
        private void textBoxCostoUnitario_TextChanged(object sender, EventArgs e) { }
        private void dataGridViewDetalleCompra_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void textBoxNombreEmpresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRegistrarCompra_Click_1(object sender, EventArgs e)
        {
            if (_detalleCompra.Count == 0)
            {
                MessageBox.Show("Agrega al menos un producto al detalle antes de registrar la compra.",
                                 "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBoxProveedorCompra.SelectedItem is not ProveedorModel proveedorSeleccionado)
            {
                MessageBox.Show("Selecciona un proveedor antes de registrar la compra.",
                                 "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (SesionActual.UsuarioLogueado == null)
            {
                MessageBox.Show("No se detectó un usuario en sesión. Vuelve a iniciar sesión.",
                                 "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var compra = new CompraModel
                {
                    ID_Proveedor = proveedorSeleccionado.ID_Proveedor,
                    ID_Usuario = SesionActual.UsuarioLogueado.ID_Usuario
                };

                var detalles = _detalleCompra.Values.ToList();

                int idCompra = _compraNegocio.RegistrarCompraCompleta(compra, detalles);

                MessageBox.Show($"Compra registrada correctamente. N° de compra: {idCompra} 🌸",
                                 "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCompra();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo registrar la compra: " + ex.Message,
                                 "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewDetalleCompra_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonCancelarCompra_Click_1(object sender, EventArgs e)
        {
            if (_detalleCompra.Count > 0)
            {
                var confirmacion = MessageBox.Show("¿Seguro que deseas cancelar esta compra? Se perderá el detalle actual.",
                                                    "Confirmar cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion != DialogResult.Yes)
                    return;
            }

            LimpiarCompra();
        }

        private void dataGridViewProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        
    }
}
