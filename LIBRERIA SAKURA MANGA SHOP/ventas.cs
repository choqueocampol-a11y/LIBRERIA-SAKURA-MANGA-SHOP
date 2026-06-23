using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Libreria_Datos;
using Libreria_Negocio;

namespace LIBRERIA_SAKURA_MANGA_SHOP
{
    public partial class ventas : Form
    {
        private readonly ClienteNegocio _clienteNegocio = new ClienteNegocio();
        private readonly VentaNegocio _ventaNegocio = new VentaNegocio();

        private ProductoModel _productoElegido;

        private readonly Dictionary<int, DetalleVentaModel> _carrito = new Dictionary<int, DetalleVentaModel>();
        private readonly Dictionary<int, string> _nombresProductoCarrito = new Dictionary<int, string>();

        public ventas()
        {
            InitializeComponent();
        }

        private void ventas_Load(object sender, EventArgs e)
        {
            dgvCarritoCompra.AllowUserToAddRows = false;

           
            cmbVendedor.Items.Clear();
            cmbVendedor.Items.Add(SesionActual.UsuarioLogueado?.Nombre ?? "Sin sesión");
            cmbVendedor.SelectedIndex = 0;
            cmbVendedor.Enabled = false;

            datetimeFecha.Value = DateTime.Now;
            datetimeFecha.Enabled = false; 

            ActualizarTotal();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            using (var dialogo = new FormSeleccionarProducto())
            {
                if (dialogo.ShowDialog(this) == DialogResult.OK && dialogo.ProductoSeleccionado != null)
                {
                    _productoElegido = dialogo.ProductoSeleccionado;
                    txtMangaElegido.Text = $"{_productoElegido.Nombre_Producto} (Stock disponible: {_productoElegido.Stock})";
                    numericUpDown1.Maximum = _productoElegido.Stock > 0 ? _productoElegido.Stock : 1;
                    numericUpDown1.Value = 1;
                }
            }
        }

        private void txtMagaElegido_TextChanged(object sender, EventArgs e) { }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e) { }

        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (_productoElegido == null)
            {
                MessageBox.Show("Selecciona un manga del inventario antes de agregarlo.",
                                 "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int cantidad = (int)numericUpDown1.Value;

            if (cantidad > _productoElegido.Stock)
            {
                MessageBox.Show($"No hay suficiente stock. Disponible: {_productoElegido.Stock}",
                                 "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_carrito.TryGetValue(_productoElegido.ID_Producto, out var existente))
            {
                existente.Cantidad += cantidad;
                existente.Subtotal = existente.Cantidad * existente.Precio_U_Historico;
            }
            else
            {
                _carrito[_productoElegido.ID_Producto] = new DetalleVentaModel
                {
                    ID_Producto = _productoElegido.ID_Producto,
                    Cantidad = cantidad,
                    Precio_U_Historico = _productoElegido.Precio_V_Actual,
                    Subtotal = cantidad * _productoElegido.Precio_V_Actual
                };
                _nombresProductoCarrito[_productoElegido.ID_Producto] = _productoElegido.Nombre_Producto;
            }

            ActualizarGridCarrito();
            ActualizarTotal();

            _productoElegido = null;
            txtMangaElegido.Clear();
            numericUpDown1.Value = 1;
        }

        private void ActualizarGridCarrito()
        {
            dgvCarritoCompra.Rows.Clear();

            foreach (var item in _carrito.Values)
            {
                dgvCarritoCompra.Rows.Add(
                    item.ID_Producto,
                    _nombresProductoCarrito[item.ID_Producto],
                    item.Cantidad,
                    item.Precio_U_Historico.ToString("C2"),
                    item.Subtotal.ToString("C2")
                );
            }
        }

        private void ActualizarTotal()
        {
            decimal total = _carrito.Values.Sum(d => d.Subtotal);
            txtTotalPagar.Text = total.ToString("C2");
        }

        private void dgvCarritoCompra_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        
        private void rxrCliente_TextChanged(object sender, EventArgs e) { }

        private int ObtenerOResolverIdCliente(string nombreCliente)
        {
            var clientes = _clienteNegocio.ListarClientes();

            var encontrado = clientes.FirstOrDefault(c =>
                string.Equals(c.Nombre?.Trim(), nombreCliente.Trim(), StringComparison.OrdinalIgnoreCase));

            if (encontrado != null)
                return encontrado.ID_Cliente;

            var nuevoCliente = new ClienteModel
            {
                Nombre = nombreCliente.Trim(),
                Celular = string.Empty,
                Gmail = string.Empty
            };
            _clienteNegocio.RegistrarCliente(nuevoCliente);

            var clientesActualizados = _clienteNegocio.ListarClientes();
            var creado = clientesActualizados
                .Where(c => string.Equals(c.Nombre?.Trim(), nombreCliente.Trim(), StringComparison.OrdinalIgnoreCase))
                .OrderByDescending(c => c.ID_Cliente)
                .FirstOrDefault();

            return creado?.ID_Cliente ?? 0;
        }

     

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            if (_carrito.Count == 0)
            {
                MessageBox.Show("Agrega al menos un manga al carrito antes de registrar la venta.",
                                 "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                MessageBox.Show("Escribe el nombre del cliente.",
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
                int idCliente = ObtenerOResolverIdCliente(txtCliente.Text);

                var venta = new VentaModel
                {
                    ID_Cliente = idCliente,
                    ID_Usuario = SesionActual.UsuarioLogueado.ID_Usuario
                };

                var detalles = _carrito.Values.ToList();

                int idVenta = _ventaNegocio.RegistrarVentaCompleta(venta, detalles);

                MessageBox.Show($"Venta registrada correctamente. N° de venta: {idVenta} 🌸",
                                 "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarVenta();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo registrar la venta: " + ex.Message,
                                 "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            if (_carrito.Count > 0)
            {
                var confirmacion = MessageBox.Show("¿Seguro que deseas cancelar esta venta? Se perderá el carrito actual.",
                                                    "Confirmar cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion != DialogResult.Yes)
                    return;
            }

            LimpiarVenta();
        }

        private void LimpiarVenta()
        {
            _carrito.Clear();
            _nombresProductoCarrito.Clear();
            _productoElegido = null;
            txtMangaElegido.Clear();
            numericUpDown1.Value = 1;
            txtCliente.Clear();
            ActualizarGridCarrito();
            ActualizarTotal();
        }

        
        private void label7_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label11_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e) { }
        private void txtTotalPagar_TextChanged(object sender, EventArgs e) { }
    }
}
