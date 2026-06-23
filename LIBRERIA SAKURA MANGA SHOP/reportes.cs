using System;
using System.Windows.Forms;
using Libreria_Negocio;

namespace LIBRERIA_SAKURA_MANGA_SHOP
{
    public partial class reportes : Form
    {
        private readonly VentaNegocio _ventaNegocio = new VentaNegocio();
        private readonly CompraNegocio _compraNegocio = new CompraNegocio();

        public reportes()
        {
            InitializeComponent();
            this.Load += reportes_Load;
        }

        private void reportes_Load(object sender, EventArgs e)
        {
            dataGridViewVentas.AllowUserToAddRows = false;
            dataGridViewCompras.AllowUserToAddRows = false;

            labelFechaValor.Text = DateTime.Now.ToString("dd/MM/yyyy");

            
            dateTimePickerReporte.Value = DateTime.Now;
            dateTimePickerReporte.Enabled = false;

            CargarResumenCaja();
        }

      
        private void CargarResumenCaja()
        {
            try
            {
                decimal totalVendido = _ventaNegocio.ObtenerTotalVendidoDelDia();
                decimal totalComprado = _compraNegocio.ObtenerTotalCompradoDelDia();
                decimal neto = totalVendido - totalComprado;

                labelTotalVendido.Text = totalVendido.ToString("C2");
                labelTotalComprado.Text = totalComprado.ToString("C2");
                labelTotalNeto.Text = neto.ToString("C2");

                CalcularEfectivoEsperado();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar el resumen de caja: " + ex.Message,
                                 "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonActualizarResumen_Click(object sender, EventArgs e)
        {
            CargarResumenCaja();
        }

        private void buttonCalcularCaja_Click(object sender, EventArgs e)
        {
            CalcularEfectivoEsperado();
        }

        private void CalcularEfectivoEsperado()
        {
            try
            {
                decimal totalVendido = _ventaNegocio.ObtenerTotalVendidoDelDia();

                decimal gastoManual = 0;
                if (!string.IsNullOrWhiteSpace(textBoxGastoManual.Text))
                {
                    if (!decimal.TryParse(textBoxGastoManual.Text, out gastoManual))
                    {
                        MessageBox.Show("El gasto manual debe ser un número válido.",
                                         "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                decimal efectivoEsperado = totalVendido - gastoManual;
                textBoxEfectivoFinal.Text = efectivoEsperado.ToString("C2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo calcular el efectivo esperado: " + ex.Message,
                                 "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void buttonVerVentasDia_Click(object sender, EventArgs e)
        {
            try
            {
                var ventas = _ventaNegocio.ListarVentasDelDia();

                dataGridViewVentas.Rows.Clear();
                foreach (var v in ventas)
                {
                    dataGridViewVentas.Rows.Add(
                        v.ID_Venta,
                        v.Nombre_Cliente,
                        v.Nombre_Usuario,
                        v.Fecha.ToString("dd/MM/yyyy"),
                        v.Monto_Total.ToString("C2")
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las ventas del día: " + ex.Message,
                                 "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonVerComprasDia_Click(object sender, EventArgs e)
        {
            try
            {
                var compras = _compraNegocio.ListarComprasDelDia();

                dataGridViewCompras.Rows.Clear();
                foreach (var c in compras)
                {
                    dataGridViewCompras.Rows.Add(
                        c.ID_Compra,
                        c.Nombre_Proveedor,
                        c.Nombre_Usuario,
                        c.Fecha.ToString("dd/MM/yyyy"),
                        c.Total_Pagado.ToString("C2")
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las compras del día: " + ex.Message,
                                 "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void dataGridViewCompras_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dataGridViewVentas_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void labelTotalVendido_Click(object sender, EventArgs e) { }
        private void labelTotalComprado_Click(object sender, EventArgs e) { }
        private void labelTotalNeto_Click(object sender, EventArgs e) { }
        private void textBoxGastoManual_TextChanged(object sender, EventArgs e) { }
        private void textBoxNotaGasto_TextChanged(object sender, EventArgs e) { }
        private void textBoxEfectivoFinal_TextChanged(object sender, EventArgs e) { }
        private void dateTimePickerReporte_ValueChanged(object sender, EventArgs e) { }
    }
}
