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
            button2 = new Button();
            textBox2 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            textBox3 = new TextBox();
            label9 = new Label();
            button4 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Manga = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            label8 = new Label();
            panel5 = new Panel();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            dateTimePicker2 = new DateTimePicker();
            label7 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            panel3.Controls.Add(button2);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(numericUpDown1);
            panel3.Controls.Add(button1);
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
            // button2
            // 
            button2.BackColor = Color.PaleVioletRed;
            button2.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1229, 27);
            button2.Name = "button2";
            button2.Size = new Size(200, 44);
            button2.TabIndex = 3;
            button2.Text = "➕ Agregar al Carrito";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(686, 37);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(449, 27);
            textBox2.TabIndex = 1;
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
            // button1
            // 
            button1.BackColor = Color.PaleVioletRed;
            button1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(176, 27);
            button1.Name = "button1";
            button1.Size = new Size(358, 44);
            button1.TabIndex = 0;
            button1.Text = "🔍 Seleccionar Manga del Inventario";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.SeaShell;
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(textBox3);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(button4);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(dataGridView1);
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
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox3.Location = new Point(1278, 400);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 5;
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
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button4.BackColor = Color.PaleVioletRed;
            button4.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(686, 389);
            button4.Name = "button4";
            button4.RightToLeft = RightToLeft.No;
            button4.Size = new Size(218, 43);
            button4.TabIndex = 3;
            button4.Text = "💾 Registra Venta";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button3.BackColor = Color.PaleVioletRed;
            button3.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(371, 389);
            button3.Name = "button3";
            button3.Size = new Size(205, 43);
            button3.TabIndex = 2;
            button3.Text = "\U0001f9f9 Cancelar Venta";
            button3.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.Pink;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Manga, Cantidad, precio, Subtotal });
            dataGridView1.GridColor = Color.Pink;
            dataGridView1.Location = new Point(371, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1032, 268);
            dataGridView1.TabIndex = 1;
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
            panel5.Controls.Add(textBox1);
            panel5.Controls.Add(comboBox2);
            panel5.Controls.Add(dateTimePicker2);
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
            // textBox1
            // 
            textBox1.Location = new Point(1106, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(323, 27);
            textBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(183, 33);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(175, 28);
            comboBox2.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(633, 33);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(299, 27);
            dateTimePicker2.TabIndex = 3;
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
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Button button2;
        private NumericUpDown numericUpDown1;
        private TextBox textBox2;
        private Button button1;
        private Label label6;
        private Label label5;
        private Panel panel4;
        private Label label8;
        private DataGridView dataGridView1;
        private Button button4;
        private Button button3;
        private TextBox textBox3;
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
        private TextBox textBox1;
        private ComboBox comboBox2;
        private DateTimePicker dateTimePicker2;
        private Label label7;
    }
}