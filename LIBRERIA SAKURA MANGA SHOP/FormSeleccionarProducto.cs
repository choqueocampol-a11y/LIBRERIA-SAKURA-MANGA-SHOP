using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Libreria_Datos;
using Libreria_Negocio;

namespace LIBRERIA_SAKURA_MANGA_SHOP
{
    
    public class FormSeleccionarProducto : Form
    {
        private readonly ProductoNegocio _productoNegocio = new ProductoNegocio();

        private TextBox txtBuscar;
        private DataGridView dgvProductos;
        private Button btnSeleccionar;
        private Button btnCancelar;

        public ProductoModel ProductoSeleccionado { get; private set; }

        public FormSeleccionarProducto()
        {
            ConstruirInterfaz();
            this.Load += FormSeleccionarProducto_Load;
        }

        private void ConstruirInterfaz()
        {
            this.Text = "Seleccionar producto 📦";
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ClientSize = new Size(700, 480);
            this.BackColor = Color.MistyRose;

            var lblBuscar = new Label
            {
                Text = "Buscar por nombre, autor o tomo:",
                Location = new Point(20, 15),
                AutoSize = true
            };

            txtBuscar = new TextBox
            {
                Location = new Point(20, 38),
                Size = new Size(660, 27)
            };
            txtBuscar.TextChanged += txtBuscar_TextChanged;

            dgvProductos = new DataGridView
            {
                Location = new Point(20, 75),
                Size = new Size(660, 330),
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                MultiSelect = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };
            dgvProductos.CellDoubleClick += (s, e) => ConfirmarSeleccion();

            btnSeleccionar = new Button
            {
                Text = "Seleccionar ✅",
                Location = new Point(460, 420),
                Size = new Size(110, 36),
                BackColor = Color.PaleVioletRed,
                ForeColor = Color.White
            };
            btnSeleccionar.Click += (s, e) => ConfirmarSeleccion();

            btnCancelar = new Button
            {
                Text = "Cancelar",
                Location = new Point(580, 420),
                Size = new Size(100, 36),
                BackColor = Color.PaleVioletRed,
                ForeColor = Color.White
            };
            btnCancelar.Click += (s, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };

            this.Controls.Add(lblBuscar);
            this.Controls.Add(txtBuscar);
            this.Controls.Add(dgvProductos);
            this.Controls.Add(btnSeleccionar);
            this.Controls.Add(btnCancelar);
        }

        private System.Collections.Generic.List<ProductoModel> _todos;

        private void FormSeleccionarProducto_Load(object sender, EventArgs e)
        {
            try
            {
                _todos = _productoNegocio.ListarProductos();
                MostrarProductos(_todos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los productos: " + ex.Message,
                                 "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarProductos(System.Collections.Generic.List<ProductoModel> lista)
        {
            dgvProductos.DataSource = lista
                .Select(p => new
                {
                    p.ID_Producto,
                    Nombre = p.Nombre_Producto,
                    p.Autor,
                    p.Tomo,
                    Precio = p.Precio_V_Actual,
                    p.Stock
                })
                .ToList();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (_todos == null) return;

            string filtro = txtBuscar.Text.Trim().ToLower();

            var filtrados = string.IsNullOrEmpty(filtro)
                ? _todos
                : _todos.Where(p =>
                    (p.Nombre_Producto ?? "").ToLower().Contains(filtro) ||
                    (p.Autor ?? "").ToLower().Contains(filtro) ||
                    (p.Tomo ?? "").ToLower().Contains(filtro)).ToList();

            MostrarProductos(filtrados);
        }

        private void ConfirmarSeleccion()
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un producto de la lista.",
                                 "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idProducto = (int)dgvProductos.CurrentRow.Cells["ID_Producto"].Value;
            ProductoSeleccionado = _todos.FirstOrDefault(p => p.ID_Producto == idProducto);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
