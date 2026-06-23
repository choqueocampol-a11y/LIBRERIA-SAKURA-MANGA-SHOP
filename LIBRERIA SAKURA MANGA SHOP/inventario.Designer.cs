namespace LIBRERIA_SAKURA_MANGA_SHOP
{
    partial class inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inventario));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            pictureBoxBuscar = new PictureBox();
            label2 = new Label();
            txtBuacarProducto = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnEliminar = new Button();
            btnModificar = new Button();
            butProducto = new Button();
            button1 = new Button();
            dgvInventario = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Tomo = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Ubicación = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            dgvAlertaStock = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            Tomo2 = new DataGridViewTextBoxColumn();
            Stock1 = new DataGridViewTextBoxColumn();
            panel4 = new Panel();
            label3 = new Label();
            panel5 = new Panel();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBuscar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlertaStock).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Pink;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-3, -103);
            panel1.Name = "panel1";
            panel1.Size = new Size(1541, 81);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(471, 9);
            label1.Name = "label1";
            label1.Size = new Size(655, 62);
            label1.TabIndex = 0;
            label1.Text = "GESTIÓN DE INVENTARIO";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.SeaShell;
            panel2.Controls.Add(pictureBoxBuscar);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtBuacarProducto);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnEliminar);
            panel2.Controls.Add(btnModificar);
            panel2.Controls.Add(butProducto);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(12, 115);
            panel2.Name = "panel2";
            panel2.Size = new Size(1565, 89);
            panel2.TabIndex = 1;
            // 
            // pictureBoxBuscar
            // 
            pictureBoxBuscar.BackColor = Color.PaleVioletRed;
            pictureBoxBuscar.Image = (Image)resources.GetObject("pictureBoxBuscar.Image");
            pictureBoxBuscar.Location = new Point(1207, 30);
            pictureBoxBuscar.Name = "pictureBoxBuscar";
            pictureBoxBuscar.Size = new Size(32, 32);
            pictureBoxBuscar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxBuscar.TabIndex = 8;
            pictureBoxBuscar.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.PaleVioletRed;
            label2.Location = new Point(629, 35);
            label2.Name = "label2";
            label2.Size = new Size(153, 22);
            label2.TabIndex = 7;
            label2.Text = "Buscar Producto:";
            // 
            // txtBuacarProducto
            // 
            txtBuacarProducto.Location = new Point(802, 30);
            txtBuacarProducto.Name = "txtBuacarProducto";
            txtBuacarProducto.Size = new Size(338, 27);
            txtBuacarProducto.TabIndex = 6;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.PaleVioletRed;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(485, 21);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(54, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.PaleVioletRed;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(299, 15);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.PaleVioletRed;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(83, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.PaleVioletRed;
            btnEliminar.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(441, 11);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(153, 66);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.BottomCenter;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.PaleVioletRed;
            btnModificar.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(236, 11);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(153, 66);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.TextAlign = ContentAlignment.BottomCenter;
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // butProducto
            // 
            butProducto.BackColor = Color.PaleVioletRed;
            butProducto.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butProducto.ForeColor = Color.White;
            butProducto.Location = new Point(24, 11);
            butProducto.Name = "butProducto";
            butProducto.Size = new Size(159, 66);
            butProducto.TabIndex = 0;
            butProducto.Text = "Nuevo Producto";
            butProducto.TextAlign = ContentAlignment.BottomCenter;
            butProducto.UseVisualStyleBackColor = false;
            butProducto.Click += butProducto_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.PaleVioletRed;
            button1.Location = new Point(1297, 21);
            button1.Name = "button1";
            button1.Size = new Size(89, 48);
            button1.TabIndex = 9;
            button1.UseVisualStyleBackColor = false;
            // 
            // dgvInventario
            // 
            dgvInventario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvInventario.BackgroundColor = Color.Pink;
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Columns.AddRange(new DataGridViewColumn[] { Nombre, Tomo, Precio, Stock, Ubicación });
            dgvInventario.Location = new Point(12, 239);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.RowHeadersWidth = 51;
            dgvInventario.Size = new Size(1021, 448);
            dgvInventario.TabIndex = 2;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 400;
            // 
            // Tomo
            // 
            Tomo.HeaderText = "Tomo";
            Tomo.MinimumWidth = 6;
            Tomo.Name = "Tomo";
            Tomo.Width = 90;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.Width = 125;
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.MinimumWidth = 6;
            Stock.Name = "Stock";
            Stock.Width = 90;
            // 
            // Ubicación
            // 
            Ubicación.HeaderText = "Ubicación";
            Ubicación.MinimumWidth = 6;
            Ubicación.Name = "Ubicación";
            Ubicación.Width = 200;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.BackColor = Color.SeaShell;
            panel3.Controls.Add(dgvAlertaStock);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(1107, 239);
            panel3.Name = "panel3";
            panel3.Size = new Size(470, 448);
            panel3.TabIndex = 3;
            // 
            // dgvAlertaStock
            // 
            dgvAlertaStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAlertaStock.BackgroundColor = Color.Pink;
            dgvAlertaStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlertaStock.Columns.AddRange(new DataGridViewColumn[] { Producto, Tomo2, Stock1 });
            dgvAlertaStock.Location = new Point(13, 83);
            dgvAlertaStock.Name = "dgvAlertaStock";
            dgvAlertaStock.RowHeadersWidth = 51;
            dgvAlertaStock.Size = new Size(439, 347);
            dgvAlertaStock.TabIndex = 1;
            dgvAlertaStock.CellContentClick += dgvAlertaStock_CellContentClick;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            Producto.Width = 200;
            // 
            // Tomo2
            // 
            Tomo2.HeaderText = "Tomo";
            Tomo2.MinimumWidth = 6;
            Tomo2.Name = "Tomo2";
            Tomo2.ReadOnly = true;
            Tomo2.Width = 90;
            // 
            // Stock1
            // 
            Stock1.HeaderText = "Stock";
            Stock1.MinimumWidth = 6;
            Stock1.Name = "Stock1";
            Stock1.ReadOnly = true;
            Stock1.Width = 90;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Pink;
            panel4.Controls.Add(label3);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(464, 62);
            panel4.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(124, 15);
            label3.Name = "label3";
            label3.Size = new Size(209, 32);
            label3.TabIndex = 0;
            label3.Text = "Alerta de Stock";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackColor = Color.Pink;
            panel5.Controls.Add(label4);
            panel5.Location = new Point(12, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(1565, 93);
            panel5.TabIndex = 4;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(468, 16);
            label4.Name = "label4";
            label4.Size = new Size(655, 62);
            label4.TabIndex = 0;
            label4.Text = "GESTIÓN DE INVENTARIO";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // inventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1589, 717);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(dgvInventario);
            Controls.Add(panel2);
            Name = "inventario";
            Text = "inventario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBuscar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAlertaStock).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private DataGridView dgvInventario;
        private Button btnEliminar;
        private Button btnModificar;
        private Button butProducto;
        private Panel panel3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label2;
        private TextBox txtBuacarProducto;
        private Panel panel4;
        private Label label3;
        private PictureBox pictureBoxBuscar;
        private DataGridView dgvAlertaStock;
        private Button button1;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Tomo;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Ubicación;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Tomo2;
        private DataGridViewTextBoxColumn Stock1;
        private Panel panel5;
        private Label label4;
    }
}