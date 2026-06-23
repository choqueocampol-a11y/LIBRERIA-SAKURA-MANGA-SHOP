namespace LIBRERIA_SAKURA_MANGA_SHOP
{
    partial class ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventas));
            panel1 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            label6 = new Label();
            label5 = new Label();
            btnAgregarCarrito = new Button();
            txtMangaElegido = new TextBox();
            numericUpDown1 = new NumericUpDown();
            btnBuscarmanga = new Button();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            txtTotalPagar = new TextBox();
            label9 = new Label();
            btnRegistrarVenta = new Button();
            btnCancelarVenta = new Button();
            dgvCarritoCompra = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Manga = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            label8 = new Label();
            panel5 = new Panel();
            label3 = new Label();
            label2 = new Label();
            txtCliente = new TextBox();
            cmbVendedor = new ComboBox();
            datetimeFecha = new DateTimePicker();
            label7 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarritoCompra).BeginInit();
            panel5.SuspendLayout();
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
            label1.Font = new Font("Arial Black", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(42, 12);
            label1.Name = "label1";
            label1.Size = new Size(1525, 61);
            label1.TabIndex = 1;
            label1.Text = "DATOS DE LA VENTA ACTUAL";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.SeaShell;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(btnAgregarCarrito);
            panel3.Controls.Add(txtMangaElegido);
            panel3.Controls.Add(numericUpDown1);
            panel3.Controls.Add(btnBuscarmanga);
            panel3.Location = new Point(21, 235);
            panel3.Name = "panel3";
            panel3.Size = new Size(1598, 100);
            panel3.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.PaleVioletRed;
            label6.Location = new Point(540, 43);
            label6.Name = "label6";
            label6.Size = new Size(145, 21);
            label6.TabIndex = 5;
            label6.Text = "Manga Elegido:";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.PaleVioletRed;
            label5.Location = new Point(16, 43);
            label5.Name = "label5";
            label5.Size = new Size(154, 21);
            label5.TabIndex = 4;
            label5.Text = "Buscar el Manga";
            // 
            // btnAgregarCarrito
            // 
            btnAgregarCarrito.BackColor = Color.PaleVioletRed;
            btnAgregarCarrito.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarCarrito.ForeColor = Color.White;
            btnAgregarCarrito.Location = new Point(1229, 27);
            btnAgregarCarrito.Name = "btnAgregarCarrito";
            btnAgregarCarrito.Size = new Size(200, 44);
            btnAgregarCarrito.TabIndex = 3;
            btnAgregarCarrito.Text = "➕ Agregar al Carrito";
            btnAgregarCarrito.UseVisualStyleBackColor = false;
            btnAgregarCarrito.Click += btnAgregar_Click;
            // 
            // txtMangaElegido
            // 
            txtMangaElegido.Location = new Point(686, 37);
            txtMangaElegido.Name = "txtMangaElegido";
            txtMangaElegido.Size = new Size(449, 27);
            txtMangaElegido.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(1141, 37);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(82, 27);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // btnBuscarmanga
            // 
            btnBuscarmanga.BackColor = Color.PaleVioletRed;
            btnBuscarmanga.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarmanga.ForeColor = Color.White;
            btnBuscarmanga.Location = new Point(176, 27);
            btnBuscarmanga.Name = "btnBuscarmanga";
            btnBuscarmanga.Size = new Size(358, 44);
            btnBuscarmanga.TabIndex = 0;
            btnBuscarmanga.Text = "🔍 Seleccionar Manga del Inventario";
            btnBuscarmanga.UseVisualStyleBackColor = false;
            btnBuscarmanga.Click += button1_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.SeaShell;
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(txtTotalPagar);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(btnRegistrarVenta);
            panel4.Controls.Add(btnCancelarVenta);
            panel4.Controls.Add(dgvCarritoCompra);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(21, 370);
            panel4.Name = "panel4";
            panel4.Size = new Size(1598, 549);
            panel4.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(306, 336);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // txtTotalPagar
            // 
            txtTotalPagar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtTotalPagar.BackColor = Color.White;
            txtTotalPagar.Location = new Point(1278, 400);
            txtTotalPagar.Name = "txtTotalPagar";
            txtTotalPagar.ReadOnly = true;
            txtTotalPagar.Size = new Size(125, 27);
            txtTotalPagar.TabIndex = 5;
            txtTotalPagar.TextChanged += txtTotalPagar_TextChanged;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.PaleVioletRed;
            label9.Location = new Point(1101, 411);
            label9.Name = "label9";
            label9.Size = new Size(122, 21);
            label9.TabIndex = 4;
            label9.Text = "Total a Pagar";
            label9.Click += label9_Click;
            // 
            // btnRegistrarVenta
            // 
            btnRegistrarVenta.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRegistrarVenta.BackColor = Color.PaleVioletRed;
            btnRegistrarVenta.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarVenta.ForeColor = Color.White;
            btnRegistrarVenta.Location = new Point(686, 389);
            btnRegistrarVenta.Name = "btnRegistrarVenta";
            btnRegistrarVenta.RightToLeft = RightToLeft.No;
            btnRegistrarVenta.Size = new Size(218, 43);
            btnRegistrarVenta.TabIndex = 3;
            btnRegistrarVenta.Text = "💾 Registra Venta";
            btnRegistrarVenta.UseVisualStyleBackColor = false;
            btnRegistrarVenta.Click += btnRegistrarVenta_Click;
            // 
            // btnCancelarVenta
            // 
            btnCancelarVenta.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelarVenta.BackColor = Color.PaleVioletRed;
            btnCancelarVenta.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarVenta.ForeColor = Color.White;
            btnCancelarVenta.Location = new Point(371, 389);
            btnCancelarVenta.Name = "btnCancelarVenta";
            btnCancelarVenta.Size = new Size(205, 43);
            btnCancelarVenta.TabIndex = 2;
            btnCancelarVenta.Text = "\U0001f9f9 Cancelar Venta";
            btnCancelarVenta.UseVisualStyleBackColor = false;
            btnCancelarVenta.Click += btnCancelarVenta_Click;
            // 
            // dgvCarritoCompra
            // 
            dgvCarritoCompra.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvCarritoCompra.BackgroundColor = Color.Pink;
            dgvCarritoCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarritoCompra.Columns.AddRange(new DataGridViewColumn[] { ID, Manga, Cantidad, precio, Subtotal });
            dgvCarritoCompra.GridColor = Color.Pink;
            dgvCarritoCompra.Location = new Point(371, 83);
            dgvCarritoCompra.Name = "dgvCarritoCompra";
            dgvCarritoCompra.RowHeadersWidth = 51;
            dgvCarritoCompra.Size = new Size(1032, 268);
            dgvCarritoCompra.TabIndex = 1;
            dgvCarritoCompra.CellContentClick += dgvCarritoCompra_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID_Producto";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Visible = false;
            ID.Width = 125;
            // 
            // Manga
            // 
            Manga.HeaderText = "Manga / Producto";
            Manga.MinimumWidth = 6;
            Manga.Name = "Manga";
            Manga.Width = 500;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 125;
            // 
            // precio
            // 
            precio.HeaderText = "Precio Unitario";
            precio.MinimumWidth = 6;
            precio.Name = "precio";
            precio.Width = 125;
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.MinimumWidth = 6;
            Subtotal.Name = "Subtotal";
            Subtotal.Width = 125;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.PaleVioletRed;
            label8.Location = new Point(633, 29);
            label8.Name = "label8";
            label8.Size = new Size(334, 27);
            label8.TabIndex = 0;
            label8.Text = "📋 CARRITO DE LA COMPRA";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackColor = Color.SeaShell;
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(txtCliente);
            panel5.Controls.Add(cmbVendedor);
            panel5.Controls.Add(datetimeFecha);
            panel5.Controls.Add(label7);
            panel5.Location = new Point(21, 117);
            panel5.Name = "panel5";
            panel5.Size = new Size(1598, 86);
            panel5.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.PaleVioletRed;
            label3.Location = new Point(1021, 40);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 7;
            label3.Text = "Cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.PaleVioletRed;
            label2.Location = new Point(506, 40);
            label2.Name = "label2";
            label2.Size = new Size(70, 21);
            label2.TabIndex = 6;
            label2.Text = "Fecha:";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(1106, 35);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(323, 27);
            txtCliente.TabIndex = 5;
            // 
            // cmbVendedor
            // 
            cmbVendedor.FormattingEnabled = true;
            cmbVendedor.Location = new Point(183, 33);
            cmbVendedor.Name = "cmbVendedor";
            cmbVendedor.Size = new Size(175, 28);
            cmbVendedor.TabIndex = 4;
            // 
            // datetimeFecha
            // 
            datetimeFecha.Location = new Point(633, 33);
            datetimeFecha.Name = "datetimeFecha";
            datetimeFecha.Size = new Size(299, 27);
            datetimeFecha.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.PaleVioletRed;
            label7.Location = new Point(42, 35);
            label7.Name = "label7";
            label7.Size = new Size(102, 21);
            label7.TabIndex = 0;
            label7.Text = "Vendedor:";
            // 
            // ventas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1631, 1019);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "ventas";
            Text = "ventas";
            Load += ventas_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarritoCompra).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Button btnAgregarCarrito;
        private NumericUpDown numericUpDown1;
        private TextBox txtMangaElegido;
        private Button btnBuscarmanga;
        private Label label6;
        private Label label5;
        private Panel panel4;
        private Label label8;
        private DataGridView dgvCarritoCompra;
        private Button btnRegistrarVenta;
        private Button btnCancelarVenta;
        private TextBox txtTotalPagar;
        private Label label9;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Manga;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn Subtotal;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Panel panel5;
        private TextBox txtCliente;
        private ComboBox cmbVendedor;
        private DateTimePicker datetimeFecha;
        private Label label7;
    }
}