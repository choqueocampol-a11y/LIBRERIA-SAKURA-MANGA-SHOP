namespace LIBRERIA_SAKURA_MANGA_SHOP
{
    partial class reportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPageCaja = new TabPage();
            panelResumenCaja = new Panel();
            labelFecha = new Label();
            labelFechaValor = new Label();
            panelTarjetaVendido = new Panel();
            labelTituloVendido = new Label();
            labelTotalVendido = new Label();
            panelTarjetaComprado = new Panel();
            labelTituloComprado = new Label();
            labelTotalComprado = new Label();
            panelTarjetaNeto = new Panel();
            labelTituloNeto = new Label();
            labelTotalNeto = new Label();
            buttonActualizarResumen = new Button();
            panelCalculoCaja = new Panel();
            label13 = new Label();
            labelEfectivoEsperado = new Label();
            label14 = new Label();
            textBoxGastoManual = new TextBox();
            label15 = new Label();
            textBoxNotaGasto = new TextBox();
            buttonCalcularCaja = new Button();
            labelResultadoFinal = new Label();
            textBoxEfectivoFinal = new TextBox();
            tabPageReportes = new TabPage();
            panelFiltroReportes = new Panel();
            label16 = new Label();
            dateTimePickerReporte = new DateTimePicker();
            buttonVerVentasDia = new Button();
            buttonVerComprasDia = new Button();
            panelReporteVentas = new Panel();
            label17 = new Label();
            dataGridViewVentas = new DataGridView();
            colVentaID = new DataGridViewTextBoxColumn();
            colVentaCliente = new DataGridViewTextBoxColumn();
            colVentaUsuario = new DataGridViewTextBoxColumn();
            colVentaFecha = new DataGridViewTextBoxColumn();
            colVentaMonto = new DataGridViewTextBoxColumn();
            panelReporteCompras = new Panel();
            label18 = new Label();
            dataGridViewCompras = new DataGridView();
            colCompraID = new DataGridViewTextBoxColumn();
            colCompraProveedor = new DataGridViewTextBoxColumn();
            colCompraUsuario = new DataGridViewTextBoxColumn();
            colCompraFecha = new DataGridViewTextBoxColumn();
            colCompraTotal = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageCaja.SuspendLayout();
            panelResumenCaja.SuspendLayout();
            panelTarjetaVendido.SuspendLayout();
            panelTarjetaComprado.SuspendLayout();
            panelTarjetaNeto.SuspendLayout();
            panelCalculoCaja.SuspendLayout();
            tabPageReportes.SuspendLayout();
            panelFiltroReportes.SuspendLayout();
            panelReporteVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVentas).BeginInit();
            panelReporteCompras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCompras).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Pink;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(21, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1598, 77);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Arial Black", 25.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(42, 12);
            label1.Name = "label1";
            label1.Size = new Size(1525, 61);
            label1.TabIndex = 1;
            label1.Text = "REPORTES Y CAJA CHICA";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPageCaja);
            tabControl1.Controls.Add(tabPageReportes);
            tabControl1.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(21, 117);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1598, 802);
            tabControl1.TabIndex = 1;
            // 
            // tabPageCaja
            // 
            tabPageCaja.BackColor = Color.MistyRose;
            tabPageCaja.Controls.Add(panelResumenCaja);
            tabPageCaja.Controls.Add(panelCalculoCaja);
            tabPageCaja.Location = new Point(4, 30);
            tabPageCaja.Name = "tabPageCaja";
            tabPageCaja.Padding = new Padding(12);
            tabPageCaja.Size = new Size(1590, 768);
            tabPageCaja.TabIndex = 0;
            tabPageCaja.Text = "💰 Caja Chica";
            // 
            // panelResumenCaja
            // 
            panelResumenCaja.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelResumenCaja.BackColor = Color.SeaShell;
            panelResumenCaja.Controls.Add(labelFecha);
            panelResumenCaja.Controls.Add(labelFechaValor);
            panelResumenCaja.Controls.Add(panelTarjetaVendido);
            panelResumenCaja.Controls.Add(panelTarjetaComprado);
            panelResumenCaja.Controls.Add(panelTarjetaNeto);
            panelResumenCaja.Controls.Add(buttonActualizarResumen);
            panelResumenCaja.Location = new Point(12, 12);
            panelResumenCaja.Name = "panelResumenCaja";
            panelResumenCaja.Size = new Size(1566, 260);
            panelResumenCaja.TabIndex = 0;
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFecha.ForeColor = Color.PaleVioletRed;
            labelFecha.Location = new Point(26, 20);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(170, 22);
            labelFecha.TabIndex = 0;
            labelFecha.Text = "Resumen del día:";
            // 
            // labelFechaValor
            // 
            labelFechaValor.AutoSize = true;
            labelFechaValor.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFechaValor.ForeColor = Color.Gray;
            labelFechaValor.Location = new Point(200, 20);
            labelFechaValor.Name = "labelFechaValor";
            labelFechaValor.Size = new Size(114, 22);
            labelFechaValor.TabIndex = 1;
            labelFechaValor.Text = "dd/mm/aaaa";
            // 
            // panelTarjetaVendido
            // 
            panelTarjetaVendido.BackColor = Color.Pink;
            panelTarjetaVendido.Controls.Add(labelTituloVendido);
            panelTarjetaVendido.Controls.Add(labelTotalVendido);
            panelTarjetaVendido.Location = new Point(26, 60);
            panelTarjetaVendido.Name = "panelTarjetaVendido";
            panelTarjetaVendido.Size = new Size(400, 140);
            panelTarjetaVendido.TabIndex = 2;
            // 
            // labelTituloVendido
            // 
            labelTituloVendido.AutoSize = true;
            labelTituloVendido.Font = new Font("Arial", 12.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTituloVendido.ForeColor = Color.White;
            labelTituloVendido.Location = new Point(24, 22);
            labelTituloVendido.Name = "labelTituloVendido";
            labelTituloVendido.Size = new Size(218, 24);
            labelTituloVendido.TabIndex = 0;
            labelTituloVendido.Text = "\U0001f6d2 Total Vendido Hoy";
            // 
            // labelTotalVendido
            // 
            labelTotalVendido.AutoSize = true;
            labelTotalVendido.Font = new Font("Arial Black", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotalVendido.ForeColor = Color.White;
            labelTotalVendido.Location = new Point(24, 60);
            labelTotalVendido.Name = "labelTotalVendido";
            labelTotalVendido.Size = new Size(173, 52);
            labelTotalVendido.TabIndex = 1;
            labelTotalVendido.Text = "Bs 0.00";
            // 
            // panelTarjetaComprado
            // 
            panelTarjetaComprado.BackColor = Color.PaleVioletRed;
            panelTarjetaComprado.Controls.Add(labelTituloComprado);
            panelTarjetaComprado.Controls.Add(labelTotalComprado);
            panelTarjetaComprado.Location = new Point(477, 60);
            panelTarjetaComprado.Name = "panelTarjetaComprado";
            panelTarjetaComprado.Size = new Size(410, 140);
            panelTarjetaComprado.TabIndex = 3;
            // 
            // labelTituloComprado
            // 
            labelTituloComprado.AutoSize = true;
            labelTituloComprado.Font = new Font("Arial", 12.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTituloComprado.ForeColor = Color.White;
            labelTituloComprado.Location = new Point(24, 22);
            labelTituloComprado.Name = "labelTituloComprado";
            labelTituloComprado.Size = new Size(243, 24);
            labelTituloComprado.TabIndex = 0;
            labelTituloComprado.Text = "📦 Total Comprado Hoy";
            // 
            // labelTotalComprado
            // 
            labelTotalComprado.AutoSize = true;
            labelTotalComprado.Font = new Font("Arial Black", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotalComprado.ForeColor = Color.White;
            labelTotalComprado.Location = new Point(24, 60);
            labelTotalComprado.Name = "labelTotalComprado";
            labelTotalComprado.Size = new Size(173, 52);
            labelTotalComprado.TabIndex = 1;
            labelTotalComprado.Text = "Bs 0.00";
            // 
            // panelTarjetaNeto
            // 
            panelTarjetaNeto.BackColor = Color.MediumVioletRed;
            panelTarjetaNeto.Controls.Add(labelTituloNeto);
            panelTarjetaNeto.Controls.Add(labelTotalNeto);
            panelTarjetaNeto.Location = new Point(947, 60);
            panelTarjetaNeto.Name = "panelTarjetaNeto";
            panelTarjetaNeto.Size = new Size(399, 140);
            panelTarjetaNeto.TabIndex = 4;
            // 
            // labelTituloNeto
            // 
            labelTituloNeto.AutoSize = true;
            labelTituloNeto.Font = new Font("Arial", 12.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTituloNeto.ForeColor = Color.White;
            labelTituloNeto.Location = new Point(24, 22);
            labelTituloNeto.Name = "labelTituloNeto";
            labelTituloNeto.Size = new Size(159, 24);
            labelTituloNeto.TabIndex = 0;
            labelTituloNeto.Text = "📊 Neto del Día";
            // 
            // labelTotalNeto
            // 
            labelTotalNeto.AutoSize = true;
            labelTotalNeto.Font = new Font("Arial Black", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotalNeto.ForeColor = Color.White;
            labelTotalNeto.Location = new Point(24, 60);
            labelTotalNeto.Name = "labelTotalNeto";
            labelTotalNeto.Size = new Size(173, 52);
            labelTotalNeto.TabIndex = 1;
            labelTotalNeto.Text = "Bs 0.00";
            // 
            // buttonActualizarResumen
            // 
            buttonActualizarResumen.BackColor = Color.PaleVioletRed;
            buttonActualizarResumen.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonActualizarResumen.ForeColor = Color.White;
            buttonActualizarResumen.Location = new Point(1236, 20);
            buttonActualizarResumen.Name = "buttonActualizarResumen";
            buttonActualizarResumen.Size = new Size(110, 33);
            buttonActualizarResumen.TabIndex = 5;
            buttonActualizarResumen.Text = "🔄 Actualizar";
            buttonActualizarResumen.UseVisualStyleBackColor = false;
            // 
            // panelCalculoCaja
            // 
            panelCalculoCaja.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelCalculoCaja.BackColor = Color.SeaShell;
            panelCalculoCaja.Controls.Add(label13);
            panelCalculoCaja.Controls.Add(labelEfectivoEsperado);
            panelCalculoCaja.Controls.Add(label14);
            panelCalculoCaja.Controls.Add(textBoxGastoManual);
            panelCalculoCaja.Controls.Add(label15);
            panelCalculoCaja.Controls.Add(textBoxNotaGasto);
            panelCalculoCaja.Controls.Add(buttonCalcularCaja);
            panelCalculoCaja.Controls.Add(labelResultadoFinal);
            panelCalculoCaja.Controls.Add(textBoxEfectivoFinal);
            panelCalculoCaja.Location = new Point(12, 284);
            panelCalculoCaja.Name = "panelCalculoCaja";
            panelCalculoCaja.Size = new Size(1566, 220);
            panelCalculoCaja.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.PaleVioletRed;
            label13.Location = new Point(26, 18);
            label13.Name = "label13";
            label13.Size = new Size(400, 27);
            label13.TabIndex = 0;
            label13.Text = "\U0001f9ee Calculadora de Efectivo en Caja";
            // 
            // labelEfectivoEsperado
            // 
            labelEfectivoEsperado.AutoSize = true;
            labelEfectivoEsperado.Font = new Font("Arial", 9.5F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelEfectivoEsperado.ForeColor = Color.Gray;
            labelEfectivoEsperado.Location = new Point(26, 50);
            labelEfectivoEsperado.Name = "labelEfectivoEsperado";
            labelEfectivoEsperado.Size = new Size(490, 19);
            labelEfectivoEsperado.TabIndex = 1;
            labelEfectivoEsperado.Text = "Este cálculo es solo informativo y no se guarda en la base de datos.";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.PaleVioletRed;
            label14.Location = new Point(26, 90);
            label14.Name = "label14";
            label14.Size = new Size(203, 21);
            label14.TabIndex = 2;
            label14.Text = "Gasto / Retiro Manual:";
            // 
            // textBoxGastoManual
            // 
            textBoxGastoManual.Location = new Point(26, 117);
            textBoxGastoManual.Name = "textBoxGastoManual";
            textBoxGastoManual.Size = new Size(160, 29);
            textBoxGastoManual.TabIndex = 3;
            textBoxGastoManual.Text = "0";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.PaleVioletRed;
            label15.Location = new Point(235, 90);
            label15.Name = "label15";
            label15.Size = new Size(167, 21);
            label15.TabIndex = 4;
            label15.Text = "Motivo (opcional):";
            // 
            // textBoxNotaGasto
            // 
            textBoxNotaGasto.Location = new Point(212, 117);
            textBoxNotaGasto.Name = "textBoxNotaGasto";
            textBoxNotaGasto.Size = new Size(400, 29);
            textBoxNotaGasto.TabIndex = 5;
            // 
            // buttonCalcularCaja
            // 
            buttonCalcularCaja.BackColor = Color.PaleVioletRed;
            buttonCalcularCaja.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCalcularCaja.ForeColor = Color.White;
            buttonCalcularCaja.Location = new Point(642, 113);
            buttonCalcularCaja.Name = "buttonCalcularCaja";
            buttonCalcularCaja.Size = new Size(190, 36);
            buttonCalcularCaja.TabIndex = 6;
            buttonCalcularCaja.Text = "\U0001f9ee Calcular";
            buttonCalcularCaja.UseVisualStyleBackColor = false;
            // 
            // labelResultadoFinal
            // 
            labelResultadoFinal.AutoSize = true;
            labelResultadoFinal.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelResultadoFinal.ForeColor = Color.PaleVioletRed;
            labelResultadoFinal.Location = new Point(900, 90);
            labelResultadoFinal.Name = "labelResultadoFinal";
            labelResultadoFinal.Size = new Size(261, 22);
            labelResultadoFinal.TabIndex = 7;
            labelResultadoFinal.Text = "Efectivo Esperado en Caja:";
            // 
            // textBoxEfectivoFinal
            // 
            textBoxEfectivoFinal.BackColor = Color.White;
            textBoxEfectivoFinal.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxEfectivoFinal.ForeColor = Color.MediumVioletRed;
            textBoxEfectivoFinal.Location = new Point(900, 117);
            textBoxEfectivoFinal.Name = "textBoxEfectivoFinal";
            textBoxEfectivoFinal.ReadOnly = true;
            textBoxEfectivoFinal.Size = new Size(220, 34);
            textBoxEfectivoFinal.TabIndex = 8;
            textBoxEfectivoFinal.Text = "Bs 0.00";
            // 
            // tabPageReportes
            // 
            tabPageReportes.BackColor = Color.MistyRose;
            tabPageReportes.Controls.Add(panelFiltroReportes);
            tabPageReportes.Controls.Add(panelReporteVentas);
            tabPageReportes.Controls.Add(panelReporteCompras);
            tabPageReportes.Location = new Point(4, 30);
            tabPageReportes.Name = "tabPageReportes";
            tabPageReportes.Padding = new Padding(12);
            tabPageReportes.Size = new Size(1590, 768);
            tabPageReportes.TabIndex = 1;
            tabPageReportes.Text = "📊 Reportes";
            // 
            // panelFiltroReportes
            // 
            panelFiltroReportes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelFiltroReportes.BackColor = Color.SeaShell;
            panelFiltroReportes.Controls.Add(label16);
            panelFiltroReportes.Controls.Add(dateTimePickerReporte);
            panelFiltroReportes.Controls.Add(buttonVerVentasDia);
            panelFiltroReportes.Controls.Add(buttonVerComprasDia);
            panelFiltroReportes.Location = new Point(12, 12);
            panelFiltroReportes.Name = "panelFiltroReportes";
            panelFiltroReportes.Size = new Size(1566, 86);
            panelFiltroReportes.TabIndex = 0;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.PaleVioletRed;
            label16.Location = new Point(26, 35);
            label16.Name = "label16";
            label16.Size = new Size(174, 21);
            label16.TabIndex = 0;
            label16.Text = "Fecha a Consultar:";
            // 
            // dateTimePickerReporte
            // 
            dateTimePickerReporte.Location = new Point(220, 33);
            dateTimePickerReporte.Name = "dateTimePickerReporte";
            dateTimePickerReporte.Size = new Size(250, 29);
            dateTimePickerReporte.TabIndex = 1;
            // 
            // buttonVerVentasDia
            // 
            buttonVerVentasDia.BackColor = Color.PaleVioletRed;
            buttonVerVentasDia.Font = new Font("Arial", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonVerVentasDia.ForeColor = Color.White;
            buttonVerVentasDia.Location = new Point(510, 27);
            buttonVerVentasDia.Name = "buttonVerVentasDia";
            buttonVerVentasDia.Size = new Size(220, 40);
            buttonVerVentasDia.TabIndex = 2;
            buttonVerVentasDia.Text = "\U0001f6d2 Ver Ventas del Día";
            buttonVerVentasDia.UseVisualStyleBackColor = false;
            // 
            // buttonVerComprasDia
            // 
            buttonVerComprasDia.BackColor = Color.PaleVioletRed;
            buttonVerComprasDia.Font = new Font("Arial", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonVerComprasDia.ForeColor = Color.White;
            buttonVerComprasDia.Location = new Point(750, 27);
            buttonVerComprasDia.Name = "buttonVerComprasDia";
            buttonVerComprasDia.Size = new Size(227, 40);
            buttonVerComprasDia.TabIndex = 3;
            buttonVerComprasDia.Text = "📦 Ver Compras del Día";
            buttonVerComprasDia.UseVisualStyleBackColor = false;
            // 
            // panelReporteVentas
            // 
            panelReporteVentas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelReporteVentas.BackColor = Color.SeaShell;
            panelReporteVentas.Controls.Add(label17);
            panelReporteVentas.Controls.Add(dataGridViewVentas);
            panelReporteVentas.Location = new Point(12, 110);
            panelReporteVentas.Name = "panelReporteVentas";
            panelReporteVentas.Size = new Size(773, 642);
            panelReporteVentas.TabIndex = 1;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Arial", 12.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.PaleVioletRed;
            label17.Location = new Point(16, 16);
            label17.Name = "label17";
            label17.Size = new Size(181, 24);
            label17.TabIndex = 0;
            label17.Text = "\U0001f6d2 Ventas del Día";
            // 
            // dataGridViewVentas
            // 
            dataGridViewVentas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewVentas.BackgroundColor = Color.Pink;
            dataGridViewVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVentas.Columns.AddRange(new DataGridViewColumn[] { colVentaID, colVentaCliente, colVentaUsuario, colVentaFecha, colVentaMonto });
            dataGridViewVentas.GridColor = Color.Pink;
            dataGridViewVentas.Location = new Point(16, 50);
            dataGridViewVentas.Name = "dataGridViewVentas";
            dataGridViewVentas.ReadOnly = true;
            dataGridViewVentas.RowHeadersWidth = 51;
            dataGridViewVentas.Size = new Size(741, 576);
            dataGridViewVentas.TabIndex = 1;
            // 
            // colVentaID
            // 
            colVentaID.HeaderText = "ID Venta";
            colVentaID.MinimumWidth = 6;
            colVentaID.Name = "colVentaID";
            colVentaID.ReadOnly = true;
            colVentaID.Width = 90;
            // 
            // colVentaCliente
            // 
            colVentaCliente.HeaderText = "Cliente";
            colVentaCliente.MinimumWidth = 6;
            colVentaCliente.Name = "colVentaCliente";
            colVentaCliente.ReadOnly = true;
            colVentaCliente.Width = 200;
            // 
            // colVentaUsuario
            // 
            colVentaUsuario.HeaderText = "Vendedor";
            colVentaUsuario.MinimumWidth = 6;
            colVentaUsuario.Name = "colVentaUsuario";
            colVentaUsuario.ReadOnly = true;
            colVentaUsuario.Width = 150;
            // 
            // colVentaFecha
            // 
            colVentaFecha.HeaderText = "Fecha";
            colVentaFecha.MinimumWidth = 6;
            colVentaFecha.Name = "colVentaFecha";
            colVentaFecha.ReadOnly = true;
            colVentaFecha.Width = 120;
            // 
            // colVentaMonto
            // 
            colVentaMonto.HeaderText = "Monto Total";
            colVentaMonto.MinimumWidth = 6;
            colVentaMonto.Name = "colVentaMonto";
            colVentaMonto.ReadOnly = true;
            colVentaMonto.Width = 130;
            // 
            // panelReporteCompras
            // 
            panelReporteCompras.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelReporteCompras.BackColor = Color.SeaShell;
            panelReporteCompras.Controls.Add(label18);
            panelReporteCompras.Controls.Add(dataGridViewCompras);
            panelReporteCompras.Location = new Point(801, 110);
            panelReporteCompras.Name = "panelReporteCompras";
            panelReporteCompras.Size = new Size(777, 642);
            panelReporteCompras.TabIndex = 2;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial", 12.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.PaleVioletRed;
            label18.Location = new Point(16, 16);
            label18.Name = "label18";
            label18.Size = new Size(205, 24);
            label18.TabIndex = 0;
            label18.Text = "📦 Compras del Día";
            // 
            // dataGridViewCompras
            // 
            dataGridViewCompras.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCompras.BackgroundColor = Color.Pink;
            dataGridViewCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCompras.Columns.AddRange(new DataGridViewColumn[] { colCompraID, colCompraProveedor, colCompraUsuario, colCompraFecha, colCompraTotal });
            dataGridViewCompras.GridColor = Color.Pink;
            dataGridViewCompras.Location = new Point(16, 50);
            dataGridViewCompras.Name = "dataGridViewCompras";
            dataGridViewCompras.ReadOnly = true;
            dataGridViewCompras.RowHeadersWidth = 51;
            dataGridViewCompras.Size = new Size(745, 576);
            dataGridViewCompras.TabIndex = 1;
            // 
            // colCompraID
            // 
            colCompraID.HeaderText = "ID Compra";
            colCompraID.MinimumWidth = 6;
            colCompraID.Name = "colCompraID";
            colCompraID.ReadOnly = true;
            colCompraID.Width = 90;
            // 
            // colCompraProveedor
            // 
            colCompraProveedor.HeaderText = "Proveedor";
            colCompraProveedor.MinimumWidth = 6;
            colCompraProveedor.Name = "colCompraProveedor";
            colCompraProveedor.ReadOnly = true;
            colCompraProveedor.Width = 220;
            // 
            // colCompraUsuario
            // 
            colCompraUsuario.HeaderText = "Registrado por";
            colCompraUsuario.MinimumWidth = 6;
            colCompraUsuario.Name = "colCompraUsuario";
            colCompraUsuario.ReadOnly = true;
            colCompraUsuario.Width = 150;
            // 
            // colCompraFecha
            // 
            colCompraFecha.HeaderText = "Fecha";
            colCompraFecha.MinimumWidth = 6;
            colCompraFecha.Name = "colCompraFecha";
            colCompraFecha.ReadOnly = true;
            colCompraFecha.Width = 120;
            // 
            // colCompraTotal
            // 
            colCompraTotal.HeaderText = "Total Pagado";
            colCompraTotal.MinimumWidth = 6;
            colCompraTotal.Name = "colCompraTotal";
            colCompraTotal.ReadOnly = true;
            colCompraTotal.Width = 130;
            // 
            // reportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1631, 1019);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "reportes";
            Text = "reporteCaja";
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPageCaja.ResumeLayout(false);
            panelResumenCaja.ResumeLayout(false);
            panelResumenCaja.PerformLayout();
            panelTarjetaVendido.ResumeLayout(false);
            panelTarjetaVendido.PerformLayout();
            panelTarjetaComprado.ResumeLayout(false);
            panelTarjetaComprado.PerformLayout();
            panelTarjetaNeto.ResumeLayout(false);
            panelTarjetaNeto.PerformLayout();
            panelCalculoCaja.ResumeLayout(false);
            panelCalculoCaja.PerformLayout();
            tabPageReportes.ResumeLayout(false);
            panelFiltroReportes.ResumeLayout(false);
            panelFiltroReportes.PerformLayout();
            panelReporteVentas.ResumeLayout(false);
            panelReporteVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVentas).EndInit();
            panelReporteCompras.ResumeLayout(false);
            panelReporteCompras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCompras).EndInit();
            ResumeLayout(false);
        }

        #endregion

        // ---- Generales ----
        private Panel panel1;
        private Label label1;
        private TabControl tabControl1;

        // ---- Tab Caja Chica ----
        private TabPage tabPageCaja;
        private Panel panelResumenCaja;
        private Label labelFecha;
        private Label labelFechaValor;
        private Panel panelTarjetaVendido;
        private Label labelTituloVendido;
        private Label labelTotalVendido;
        private Panel panelTarjetaComprado;
        private Label labelTituloComprado;
        private Label labelTotalComprado;
        private Panel panelTarjetaNeto;
        private Label labelTituloNeto;
        private Label labelTotalNeto;
        private Button buttonActualizarResumen;
        private Panel panelCalculoCaja;
        private Label label13;
        private Label labelEfectivoEsperado;
        private Label label14;
        private TextBox textBoxGastoManual;
        private Label label15;
        private TextBox textBoxNotaGasto;
        private Button buttonCalcularCaja;
        private Label labelResultadoFinal;
        private TextBox textBoxEfectivoFinal;

        // ---- Tab Reportes ----
        private TabPage tabPageReportes;
        private Panel panelFiltroReportes;
        private Label label16;
        private DateTimePicker dateTimePickerReporte;
        private Button buttonVerVentasDia;
        private Button buttonVerComprasDia;
        private Panel panelReporteVentas;
        private Label label17;
        private DataGridView dataGridViewVentas;
        private DataGridViewTextBoxColumn colVentaID;
        private DataGridViewTextBoxColumn colVentaCliente;
        private DataGridViewTextBoxColumn colVentaUsuario;
        private DataGridViewTextBoxColumn colVentaFecha;
        private DataGridViewTextBoxColumn colVentaMonto;
        private Panel panelReporteCompras;
        private Label label18;
        private DataGridView dataGridViewCompras;
        private DataGridViewTextBoxColumn colCompraID;
        private DataGridViewTextBoxColumn colCompraProveedor;
        private DataGridViewTextBoxColumn colCompraUsuario;
        private DataGridViewTextBoxColumn colCompraFecha;
        private DataGridViewTextBoxColumn colCompraTotal;
    }
}