using System;
using System.Drawing;
using System.Windows.Forms;
using Libreria_Datos;

namespace LIBRERIA_SAKURA_MANGA_SHOP
{
   
    public class FormProducto : Form
    {
        private TextBox txtNombre;
        private TextBox txtAutor;
        private TextBox txtTomo;
        private NumericUpDown numPrecio;
        private NumericUpDown numStock;
        private TextBox txtUbicacion;
        private Button btnGuardar;
        private Button btnCancelar;

        private readonly int _idProductoExistente;

        public ProductoModel ProductoResultado { get; private set; }

        public FormProducto(ProductoModel productoExistente = null)
        {
            _idProductoExistente = productoExistente?.ID_Producto ?? 0;
            ConstruirInterfaz();

            if (productoExistente != null)
            {
                this.Text = "Editar producto ✏️";
                txtNombre.Text = productoExistente.Nombre_Producto;
                txtAutor.Text = productoExistente.Autor;
                txtTomo.Text = productoExistente.Tomo;
                numPrecio.Value = productoExistente.Precio_V_Actual;
                numStock.Value = productoExistente.Stock;
                txtUbicacion.Text = productoExistente.Ubicacion;
            }
            else
            {
                this.Text = "Nuevo producto ➕";
            }
        }

        private void ConstruirInterfaz()
        {
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ClientSize = new Size(420, 380);
            this.BackColor = Color.MistyRose;

            var lblNombre = new Label { Text = "Nombre:", Location = new Point(20, 20), AutoSize = true };
            txtNombre = new TextBox { Location = new Point(20, 42), Size = new Size(370, 27) };

            var lblAutor = new Label { Text = "Autor:", Location = new Point(20, 80), AutoSize = true };
            txtAutor = new TextBox { Location = new Point(20, 102), Size = new Size(370, 27) };

            var lblTomo = new Label { Text = "Tomo:", Location = new Point(20, 140), AutoSize = true };
            txtTomo = new TextBox { Location = new Point(20, 162), Size = new Size(170, 27) };

            var lblPrecio = new Label { Text = "Precio:", Location = new Point(220, 140), AutoSize = true };
            numPrecio = new NumericUpDown
            {
                Location = new Point(220, 162),
                Size = new Size(170, 27),
                DecimalPlaces = 2,
                Maximum = 99999
            };

            var lblStock = new Label { Text = "Stock:", Location = new Point(20, 200), AutoSize = true };
            numStock = new NumericUpDown
            {
                Location = new Point(20, 222),
                Size = new Size(170, 27),
                Maximum = 99999
            };

            var lblUbicacion = new Label { Text = "Ubicación:", Location = new Point(220, 200), AutoSize = true };
            txtUbicacion = new TextBox { Location = new Point(220, 222), Size = new Size(170, 27) };

            btnGuardar = new Button
            {
                Text = "Guardar 💾",
                Location = new Point(110, 300),
                Size = new Size(150, 38),
                BackColor = Color.PaleVioletRed,
                ForeColor = Color.White
            };
            btnGuardar.Click += btnGuardar_Click;

            btnCancelar = new Button
            {
                Text = "Cancelar",
                Location = new Point(270, 300),
                Size = new Size(120, 38),
                BackColor = Color.PaleVioletRed,
                ForeColor = Color.White
            };
            btnCancelar.Click += (s, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };

            this.Controls.Add(lblNombre);
            this.Controls.Add(txtNombre);
            this.Controls.Add(lblAutor);
            this.Controls.Add(txtAutor);
            this.Controls.Add(lblTomo);
            this.Controls.Add(txtTomo);
            this.Controls.Add(lblPrecio);
            this.Controls.Add(numPrecio);
            this.Controls.Add(lblStock);
            this.Controls.Add(numStock);
            this.Controls.Add(lblUbicacion);
            this.Controls.Add(txtUbicacion);
            this.Controls.Add(btnGuardar);
            this.Controls.Add(btnCancelar);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre del producto es obligatorio.",
                                 "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ProductoResultado = new ProductoModel
            {
                ID_Producto = _idProductoExistente,
                Nombre_Producto = txtNombre.Text.Trim(),
                Autor = txtAutor.Text.Trim(),
                Tomo = txtTomo.Text.Trim(),
                Precio_V_Actual = numPrecio.Value,
                Stock = (int)numStock.Value,
                Ubicacion = txtUbicacion.Text.Trim()
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
