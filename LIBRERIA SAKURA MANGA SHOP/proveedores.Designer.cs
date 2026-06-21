namespace LIBRERIA_SAKURA_MANGA_SHOP
{
    partial class compraProveedor
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
            tabPageCompras = new TabPage();
            panelCabeceraCompra = new Panel();
            label7 = new Label();
            comboBoxUsuario = new ComboBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            comboBoxProveedorCompra = new ComboBox();
            panelBuscarProducto = new Panel();
            label5 = new Label();
            label6 = new Label();
            textBoxBuscarProducto = new TextBox();
            numericUpDownCantidadRecibida = new NumericUpDown();
            labelCosto = new Label();
            textBoxCostoUnitario = new TextBox();
            buttonSeleccionarProducto = new Button();
            buttonAgregarDetalle = new Button();
            panelDetalleCompra = new Panel();
            label8 = new Label();
            dataGridViewDetalleCompra = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            CantidadRecibida = new DataGridViewTextBoxColumn();
            CostoUnitario = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            label9 = new Label();
            textBoxTotalCompra = new TextBox();
            buttonCancelarCompra = new Button();
            buttonRegistrarCompra = new Button();
            tabPageProveedores = new TabPage();
            panelFormularioProveedor = new Panel();
            label10 = new Label();
            textBoxNombreEmpresa = new TextBox();
            label11 = new Label();
            textBoxTelefono = new TextBox();
            buttonRegistrarProveedor = new Button();
            buttonModificarProveedor = new Button();
            buttonEliminarProveedor = new Button();
            buttonLimpiarProveedor = new Button();
            panelBuscarProveedor = new Panel();
            label12 = new Label();
            textBoxBuscarProveedor = new TextBox();
            buttonBuscarProveedor = new Button();
            panelListaProveedores = new Panel();
            dataGridViewProveedores = new DataGridView();
            ID_Proveedor = new DataGridViewTextBoxColumn();
            Nombre_Empresa = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageCompras.SuspendLayout();
            panelCabeceraCompra.SuspendLayout();
            panelBuscarProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCantidadRecibida).BeginInit();
            panelDetalleCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetalleCompra).BeginInit();
            tabPageProveedores.SuspendLayout();
            panelFormularioProveedor.SuspendLayout();
            panelBuscarProveedor.SuspendLayout();
            panelListaProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProveedores).BeginInit();
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
            label1.Location = new Point(16, 0);
            label1.Name = "label1";
            label1.Size = new Size(1525, 61);
            label1.TabIndex = 1;
            label1.Text = "GESTIÓN DE COMPRAS Y PROVEEDORES";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPageCompras);
            tabControl1.Controls.Add(tabPageProveedores);
            tabControl1.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(21, 117);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1598, 802);
            tabControl1.TabIndex = 1;
            // 
            // tabPageCompras
            // 
            tabPageCompras.BackColor = Color.MistyRose;
            tabPageCompras.Controls.Add(panelCabeceraCompra);
            tabPageCompras.Controls.Add(panelBuscarProducto);
            tabPageCompras.Controls.Add(panelDetalleCompra);
            tabPageCompras.Location = new Point(4, 30);
            tabPageCompras.Name = "tabPageCompras";
            tabPageCompras.Padding = new Padding(12);
            tabPageCompras.Size = new Size(1590, 768);
            tabPageCompras.TabIndex = 0;
            tabPageCompras.Text = "\U0001f6d2 Compras";
            // 
            // panelCabeceraCompra
            // 
            panelCabeceraCompra.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelCabeceraCompra.BackColor = Color.SeaShell;
            panelCabeceraCompra.Controls.Add(label7);
            panelCabeceraCompra.Controls.Add(comboBoxUsuario);
            panelCabeceraCompra.Controls.Add(label2);
            panelCabeceraCompra.Controls.Add(dateTimePicker1);
            panelCabeceraCompra.Controls.Add(label3);
            panelCabeceraCompra.Controls.Add(comboBoxProveedorCompra);
            panelCabeceraCompra.Location = new Point(12, 12);
            panelCabeceraCompra.Name = "panelCabeceraCompra";
            panelCabeceraCompra.Size = new Size(1566, 86);
            panelCabeceraCompra.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.PaleVioletRed;
            label7.Location = new Point(26, 35);
            label7.Name = "label7";
            label7.Size = new Size(84, 21);
            label7.TabIndex = 0;
            label7.Text = "Usuario:";
            // 
            // comboBoxUsuario
            // 
            comboBoxUsuario.FormattingEnabled = true;
            comboBoxUsuario.Location = new Point(167, 33);
            comboBoxUsuario.Name = "comboBoxUsuario";
            comboBoxUsuario.Size = new Size(280, 29);
            comboBoxUsuario.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.PaleVioletRed;
            label2.Location = new Point(462, 39);
            label2.Name = "label2";
            label2.Size = new Size(70, 21);
            label2.TabIndex = 2;
            label2.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(551, 33);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(299, 25);
            dateTimePicker1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.PaleVioletRed;
            label3.Location = new Point(896, 36);
            label3.Name = "label3";
            label3.Size = new Size(109, 21);
            label3.TabIndex = 4;
            label3.Text = "Proveedor:";
            // 
            // comboBoxProveedorCompra
            // 
            comboBoxProveedorCompra.FormattingEnabled = true;
            comboBoxProveedorCompra.Location = new Point(1013, 33);
            comboBoxProveedorCompra.Name = "comboBoxProveedorCompra";
            comboBoxProveedorCompra.Size = new Size(315, 29);
            comboBoxProveedorCompra.TabIndex = 5;
            // 
            // panelBuscarProducto
            // 
            panelBuscarProducto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelBuscarProducto.BackColor = Color.SeaShell;
            panelBuscarProducto.Controls.Add(label5);
            panelBuscarProducto.Controls.Add(label6);
            panelBuscarProducto.Controls.Add(textBoxBuscarProducto);
            panelBuscarProducto.Controls.Add(numericUpDownCantidadRecibida);
            panelBuscarProducto.Controls.Add(labelCosto);
            panelBuscarProducto.Controls.Add(textBoxCostoUnitario);
            panelBuscarProducto.Controls.Add(buttonSeleccionarProducto);
            panelBuscarProducto.Controls.Add(buttonAgregarDetalle);
            panelBuscarProducto.Location = new Point(12, 110);
            panelBuscarProducto.Name = "panelBuscarProducto";
            panelBuscarProducto.Size = new Size(1566, 100);
            panelBuscarProducto.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.PaleVioletRed;
            label5.Location = new Point(16, 18);
            label5.Name = "label5";
            label5.Size = new Size(167, 21);
            label5.TabIndex = 0;
            label5.Text = "Producto Elegido:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(16, 70);
            label6.Name = "label6";
            label6.Size = new Size(267, 18);
            label6.TabIndex = 1;
            label6.Text = "Selecciona un producto del inventario";
            // 
            // textBoxBuscarProducto
            // 
            textBoxBuscarProducto.Location = new Point(16, 40);
            textBoxBuscarProducto.Name = "textBoxBuscarProducto";
            textBoxBuscarProducto.ReadOnly = true;
            textBoxBuscarProducto.Size = new Size(450, 29);
            textBoxBuscarProducto.TabIndex = 2;
            // 
            // numericUpDownCantidadRecibida
            // 
            numericUpDownCantidadRecibida.Location = new Point(713, 40);
            numericUpDownCantidadRecibida.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownCantidadRecibida.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownCantidadRecibida.Name = "numericUpDownCantidadRecibida";
            numericUpDownCantidadRecibida.Size = new Size(80, 29);
            numericUpDownCantidadRecibida.TabIndex = 4;
            numericUpDownCantidadRecibida.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelCosto
            // 
            labelCosto.AutoSize = true;
            labelCosto.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCosto.ForeColor = Color.PaleVioletRed;
            labelCosto.Location = new Point(830, 42);
            labelCosto.Name = "labelCosto";
            labelCosto.Size = new Size(68, 21);
            labelCosto.TabIndex = 5;
            labelCosto.Text = "Costo:";
            labelCosto.Click += labelCosto_Click;
            // 
            // textBoxCostoUnitario
            // 
            textBoxCostoUnitario.Location = new Point(905, 39);
            textBoxCostoUnitario.Name = "textBoxCostoUnitario";
            textBoxCostoUnitario.Size = new Size(100, 29);
            textBoxCostoUnitario.TabIndex = 6;
            // 
            // buttonSeleccionarProducto
            // 
            buttonSeleccionarProducto.BackColor = Color.PaleVioletRed;
            buttonSeleccionarProducto.Font = new Font("Arial", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSeleccionarProducto.ForeColor = Color.White;
            buttonSeleccionarProducto.Location = new Point(476, 37);
            buttonSeleccionarProducto.Name = "buttonSeleccionarProducto";
            buttonSeleccionarProducto.Size = new Size(190, 33);
            buttonSeleccionarProducto.TabIndex = 3;
            buttonSeleccionarProducto.Text = "🔍 Buscar Producto";
            buttonSeleccionarProducto.UseVisualStyleBackColor = false;
            // 
            // buttonAgregarDetalle
            // 
            buttonAgregarDetalle.BackColor = Color.PaleVioletRed;
            buttonAgregarDetalle.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAgregarDetalle.ForeColor = Color.White;
            buttonAgregarDetalle.Location = new Point(1108, 25);
            buttonAgregarDetalle.Name = "buttonAgregarDetalle";
            buttonAgregarDetalle.Size = new Size(220, 44);
            buttonAgregarDetalle.TabIndex = 7;
            buttonAgregarDetalle.Text = "➕ Agregar al Detalle";
            buttonAgregarDetalle.UseVisualStyleBackColor = false;
            // 
            // panelDetalleCompra
            // 
            panelDetalleCompra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelDetalleCompra.BackColor = Color.SeaShell;
            panelDetalleCompra.Controls.Add(label8);
            panelDetalleCompra.Controls.Add(dataGridViewDetalleCompra);
            panelDetalleCompra.Controls.Add(label9);
            panelDetalleCompra.Controls.Add(textBoxTotalCompra);
            panelDetalleCompra.Controls.Add(buttonCancelarCompra);
            panelDetalleCompra.Controls.Add(buttonRegistrarCompra);
            panelDetalleCompra.Location = new Point(12, 222);
            panelDetalleCompra.Name = "panelDetalleCompra";
            panelDetalleCompra.Size = new Size(1566, 530);
            panelDetalleCompra.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.PaleVioletRed;
            label8.Location = new Point(16, 16);
            label8.Name = "label8";
            label8.Size = new Size(333, 27);
            label8.TabIndex = 0;
            label8.Text = "📦 DETALLE DE LA COMPRA";
            // 
            // dataGridViewDetalleCompra
            // 
            dataGridViewDetalleCompra.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewDetalleCompra.BackgroundColor = Color.Pink;
            dataGridViewDetalleCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDetalleCompra.Columns.AddRange(new DataGridViewColumn[] { ID, Producto, CantidadRecibida, CostoUnitario, Subtotal });
            dataGridViewDetalleCompra.GridColor = Color.Pink;
            dataGridViewDetalleCompra.Location = new Point(16, 55);
            dataGridViewDetalleCompra.Name = "dataGridViewDetalleCompra";
            dataGridViewDetalleCompra.RowHeadersWidth = 51;
            dataGridViewDetalleCompra.Size = new Size(1509, 350);
            dataGridViewDetalleCompra.TabIndex = 1;
            // 
            // ID
            // 
            ID.HeaderText = "ID_Producto";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Visible = false;
            ID.Width = 125;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            Producto.Width = 650;
            // 
            // CantidadRecibida
            // 
            CantidadRecibida.HeaderText = "Cantidad Recibida";
            CantidadRecibida.MinimumWidth = 6;
            CantidadRecibida.Name = "CantidadRecibida";
            CantidadRecibida.Width = 200;
            // 
            // CostoUnitario
            // 
            CostoUnitario.HeaderText = "Costo Unitario";
            CostoUnitario.MinimumWidth = 6;
            CostoUnitario.Name = "CostoUnitario";
            CostoUnitario.Width = 200;
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.MinimumWidth = 6;
            Subtotal.Name = "Subtotal";
            Subtotal.Width = 200;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.PaleVioletRed;
            label9.Location = new Point(1246, 484);
            label9.Name = "label9";
            label9.Size = new Size(122, 21);
            label9.TabIndex = 2;
            label9.Text = "Total a Pagar";
            // 
            // textBoxTotalCompra
            // 
            textBoxTotalCompra.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxTotalCompra.BackColor = Color.White;
            textBoxTotalCompra.Location = new Point(1425, 473);
            textBoxTotalCompra.Name = "textBoxTotalCompra";
            textBoxTotalCompra.ReadOnly = true;
            textBoxTotalCompra.Size = new Size(125, 29);
            textBoxTotalCompra.TabIndex = 3;
            // 
            // buttonCancelarCompra
            // 
            buttonCancelarCompra.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonCancelarCompra.BackColor = Color.PaleVioletRed;
            buttonCancelarCompra.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCancelarCompra.ForeColor = Color.White;
            buttonCancelarCompra.Location = new Point(16, 473);
            buttonCancelarCompra.Name = "buttonCancelarCompra";
            buttonCancelarCompra.Size = new Size(205, 43);
            buttonCancelarCompra.TabIndex = 4;
            buttonCancelarCompra.Text = "\U0001f9f9 Cancelar Compra";
            buttonCancelarCompra.UseVisualStyleBackColor = false;
            // 
            // buttonRegistrarCompra
            // 
            buttonRegistrarCompra.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonRegistrarCompra.BackColor = Color.PaleVioletRed;
            buttonRegistrarCompra.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRegistrarCompra.ForeColor = Color.White;
            buttonRegistrarCompra.Location = new Point(238, 473);
            buttonRegistrarCompra.Name = "buttonRegistrarCompra";
            buttonRegistrarCompra.Size = new Size(218, 43);
            buttonRegistrarCompra.TabIndex = 5;
            buttonRegistrarCompra.Text = "💾 Registrar Compra";
            buttonRegistrarCompra.UseVisualStyleBackColor = false;
            // 
            // tabPageProveedores
            // 
            tabPageProveedores.BackColor = Color.MistyRose;
            tabPageProveedores.Controls.Add(panelFormularioProveedor);
            tabPageProveedores.Controls.Add(panelBuscarProveedor);
            tabPageProveedores.Controls.Add(panelListaProveedores);
            tabPageProveedores.Location = new Point(4, 30);
            tabPageProveedores.Name = "tabPageProveedores";
            tabPageProveedores.Padding = new Padding(12);
            tabPageProveedores.Size = new Size(1590, 768);
            tabPageProveedores.TabIndex = 1;
            tabPageProveedores.Text = "🚚 Proveedores";
            // 
            // panelFormularioProveedor
            // 
            panelFormularioProveedor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelFormularioProveedor.BackColor = Color.SeaShell;
            panelFormularioProveedor.Controls.Add(label10);
            panelFormularioProveedor.Controls.Add(textBoxNombreEmpresa);
            panelFormularioProveedor.Controls.Add(label11);
            panelFormularioProveedor.Controls.Add(textBoxTelefono);
            panelFormularioProveedor.Controls.Add(buttonRegistrarProveedor);
            panelFormularioProveedor.Controls.Add(buttonModificarProveedor);
            panelFormularioProveedor.Controls.Add(buttonEliminarProveedor);
            panelFormularioProveedor.Controls.Add(buttonLimpiarProveedor);
            panelFormularioProveedor.Location = new Point(12, 12);
            panelFormularioProveedor.Name = "panelFormularioProveedor";
            panelFormularioProveedor.Size = new Size(1566, 130);
            panelFormularioProveedor.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.PaleVioletRed;
            label10.Location = new Point(26, 30);
            label10.Name = "label10";
            label10.Size = new Size(170, 21);
            label10.TabIndex = 0;
            label10.Text = "Nombre Empresa:";
            // 
            // textBoxNombreEmpresa
            // 
            textBoxNombreEmpresa.Location = new Point(26, 57);
            textBoxNombreEmpresa.MaxLength = 50;
            textBoxNombreEmpresa.Name = "textBoxNombreEmpresa";
            textBoxNombreEmpresa.Size = new Size(352, 29);
            textBoxNombreEmpresa.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.PaleVioletRed;
            label11.Location = new Point(462, 30);
            label11.Name = "label11";
            label11.Size = new Size(92, 21);
            label11.TabIndex = 2;
            label11.Text = "Teléfono:";
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Location = new Point(462, 57);
            textBoxTelefono.MaxLength = 12;
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(220, 29);
            textBoxTelefono.TabIndex = 3;
            // 
            // buttonRegistrarProveedor
            // 
            buttonRegistrarProveedor.BackColor = Color.PaleVioletRed;
            buttonRegistrarProveedor.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRegistrarProveedor.ForeColor = Color.White;
            buttonRegistrarProveedor.Location = new Point(725, 48);
            buttonRegistrarProveedor.Name = "buttonRegistrarProveedor";
            buttonRegistrarProveedor.Size = new Size(130, 44);
            buttonRegistrarProveedor.TabIndex = 4;
            buttonRegistrarProveedor.Text = "➕ Agregar";
            buttonRegistrarProveedor.UseVisualStyleBackColor = false;
            // 
            // buttonModificarProveedor
            // 
            buttonModificarProveedor.BackColor = Color.PaleVioletRed;
            buttonModificarProveedor.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonModificarProveedor.ForeColor = Color.White;
            buttonModificarProveedor.Location = new Point(881, 48);
            buttonModificarProveedor.Name = "buttonModificarProveedor";
            buttonModificarProveedor.Size = new Size(140, 44);
            buttonModificarProveedor.TabIndex = 5;
            buttonModificarProveedor.Text = "✏️ Modificar";
            buttonModificarProveedor.UseVisualStyleBackColor = false;
            // 
            // buttonEliminarProveedor
            // 
            buttonEliminarProveedor.BackColor = Color.PaleVioletRed;
            buttonEliminarProveedor.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEliminarProveedor.ForeColor = Color.White;
            buttonEliminarProveedor.Location = new Point(1043, 48);
            buttonEliminarProveedor.Name = "buttonEliminarProveedor";
            buttonEliminarProveedor.Size = new Size(130, 44);
            buttonEliminarProveedor.TabIndex = 6;
            buttonEliminarProveedor.Text = "🗑️ Eliminar";
            buttonEliminarProveedor.UseVisualStyleBackColor = false;
            // 
            // buttonLimpiarProveedor
            // 
            buttonLimpiarProveedor.BackColor = Color.PaleVioletRed;
            buttonLimpiarProveedor.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLimpiarProveedor.ForeColor = Color.White;
            buttonLimpiarProveedor.Location = new Point(1194, 48);
            buttonLimpiarProveedor.Name = "buttonLimpiarProveedor";
            buttonLimpiarProveedor.Size = new Size(126, 44);
            buttonLimpiarProveedor.TabIndex = 7;
            buttonLimpiarProveedor.Text = "\U0001f9f9 Limpiar";
            buttonLimpiarProveedor.UseVisualStyleBackColor = false;
            // 
            // panelBuscarProveedor
            // 
            panelBuscarProveedor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelBuscarProveedor.BackColor = Color.SeaShell;
            panelBuscarProveedor.Controls.Add(label12);
            panelBuscarProveedor.Controls.Add(textBoxBuscarProveedor);
            panelBuscarProveedor.Controls.Add(buttonBuscarProveedor);
            panelBuscarProveedor.Location = new Point(12, 154);
            panelBuscarProveedor.Name = "panelBuscarProveedor";
            panelBuscarProveedor.Size = new Size(1566, 80);
            panelBuscarProveedor.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.PaleVioletRed;
            label12.Location = new Point(26, 18);
            label12.Name = "label12";
            label12.Size = new Size(280, 21);
            label12.TabIndex = 0;
            label12.Text = "Buscar por Nombre / Empresa:";
            // 
            // textBoxBuscarProveedor
            // 
            textBoxBuscarProveedor.Location = new Point(26, 42);
            textBoxBuscarProveedor.Name = "textBoxBuscarProveedor";
            textBoxBuscarProveedor.Size = new Size(500, 29);
            textBoxBuscarProveedor.TabIndex = 1;
            // 
            // buttonBuscarProveedor
            // 
            buttonBuscarProveedor.BackColor = Color.PaleVioletRed;
            buttonBuscarProveedor.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBuscarProveedor.ForeColor = Color.White;
            buttonBuscarProveedor.Location = new Point(553, 36);
            buttonBuscarProveedor.Name = "buttonBuscarProveedor";
            buttonBuscarProveedor.Size = new Size(130, 35);
            buttonBuscarProveedor.TabIndex = 2;
            buttonBuscarProveedor.Text = "🔍 Buscar";
            buttonBuscarProveedor.UseVisualStyleBackColor = false;
            // 
            // panelListaProveedores
            // 
            panelListaProveedores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelListaProveedores.BackColor = Color.SeaShell;
            panelListaProveedores.Controls.Add(dataGridViewProveedores);
            panelListaProveedores.Location = new Point(12, 246);
            panelListaProveedores.Name = "panelListaProveedores";
            panelListaProveedores.Size = new Size(1566, 506);
            panelListaProveedores.TabIndex = 2;
            // 
            // dataGridViewProveedores
            // 
            dataGridViewProveedores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProveedores.BackgroundColor = Color.Pink;
            dataGridViewProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProveedores.Columns.AddRange(new DataGridViewColumn[] { ID_Proveedor, Nombre_Empresa, Telefono });
            dataGridViewProveedores.GridColor = Color.Pink;
            dataGridViewProveedores.Location = new Point(16, 16);
            dataGridViewProveedores.MultiSelect = false;
            dataGridViewProveedores.Name = "dataGridViewProveedores";
            dataGridViewProveedores.RowHeadersWidth = 51;
            dataGridViewProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProveedores.Size = new Size(1509, 474);
            dataGridViewProveedores.TabIndex = 0;
            // 
            // ID_Proveedor
            // 
            ID_Proveedor.HeaderText = "ID Proveedor";
            ID_Proveedor.MinimumWidth = 6;
            ID_Proveedor.Name = "ID_Proveedor";
            ID_Proveedor.ReadOnly = true;
            ID_Proveedor.Width = 150;
            // 
            // Nombre_Empresa
            // 
            Nombre_Empresa.HeaderText = "Nombre Empresa";
            Nombre_Empresa.MinimumWidth = 6;
            Nombre_Empresa.Name = "Nombre_Empresa";
            Nombre_Empresa.Width = 700;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Teléfono";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            Telefono.Width = 300;
            // 
            // compraProveedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1631, 1019);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "compraProveedor";
            Text = "compraProveedor";
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPageCompras.ResumeLayout(false);
            panelCabeceraCompra.ResumeLayout(false);
            panelCabeceraCompra.PerformLayout();
            panelBuscarProducto.ResumeLayout(false);
            panelBuscarProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCantidadRecibida).EndInit();
            panelDetalleCompra.ResumeLayout(false);
            panelDetalleCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetalleCompra).EndInit();
            tabPageProveedores.ResumeLayout(false);
            panelFormularioProveedor.ResumeLayout(false);
            panelFormularioProveedor.PerformLayout();
            panelBuscarProveedor.ResumeLayout(false);
            panelBuscarProveedor.PerformLayout();
            panelListaProveedores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProveedores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        #endregion

        // ---- Generales ----
        private Panel panel1;
        private Label label1;
        private TabControl tabControl1;

        // ---- Tab Compras ----
        private TabPage tabPageCompras;
        private Panel panelCabeceraCompra;
        private Label label7;
        private ComboBox comboBoxUsuario;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private ComboBox comboBoxProveedorCompra;
        private Panel panelBuscarProducto;
        private Label label5;
        private Label label6;
        private TextBox textBoxBuscarProducto;
        private NumericUpDown numericUpDownCantidadRecibida;
        private Label labelCosto;
        private TextBox textBoxCostoUnitario;
        private Button buttonSeleccionarProducto;
        private Button buttonAgregarDetalle;
        private Panel panelDetalleCompra;
        private Label label8;
        private DataGridView dataGridViewDetalleCompra;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn CantidadRecibida;
        private DataGridViewTextBoxColumn CostoUnitario;
        private DataGridViewTextBoxColumn Subtotal;
        private Label label9;
        private TextBox textBoxTotalCompra;
        private Button buttonCancelarCompra;
        private Button buttonRegistrarCompra;

        // ---- Tab Proveedores ----
        private TabPage tabPageProveedores;
        private Panel panelFormularioProveedor;
        private Label label10;
        private TextBox textBoxNombreEmpresa;
        private Label label11;
        private TextBox textBoxTelefono;
        private Button buttonRegistrarProveedor;
        private Button buttonModificarProveedor;
        private Button buttonEliminarProveedor;
        private Button buttonLimpiarProveedor;
        private Panel panelBuscarProveedor;
        private Label label12;
        private TextBox textBoxBuscarProveedor;
        private Button buttonBuscarProveedor;
        private Panel panelListaProveedores;
        private DataGridView dataGridViewProveedores;
        private DataGridViewTextBoxColumn ID_Proveedor;
        private DataGridViewTextBoxColumn Nombre_Empresa;
        private DataGridViewTextBoxColumn Telefono;
    }
}