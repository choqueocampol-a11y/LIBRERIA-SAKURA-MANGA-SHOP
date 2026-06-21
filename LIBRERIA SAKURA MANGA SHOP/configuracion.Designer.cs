namespace LIBRERIA_SAKURA_MANGA_SHOP
{
    partial class configuracion
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
            panel2 = new Panel();
            label2 = new Label();
            textBoxNombre = new TextBox();
            label3 = new Label();
            textBoxUsername = new TextBox();
            label4 = new Label();
            textBoxPassword = new TextBox();
            label5 = new Label();
            comboBoxRol = new ComboBox();
            buttonRegistrar = new Button();
            buttonModificar = new Button();
            buttonEliminar = new Button();
            buttonLimpiar = new Button();
            panel3 = new Panel();
            label6 = new Label();
            textBoxBuscar = new TextBox();
            buttonBuscar = new Button();
            panel4 = new Panel();
            dataGridView1 = new DataGridView();
            ID_Usuario = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            Nombre_Rol = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            label1.Text = "CONFIGURACIÓN DE SEGURIDAD";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.SeaShell;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBoxNombre);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBoxUsername);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBoxPassword);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(comboBoxRol);
            panel2.Controls.Add(buttonRegistrar);
            panel2.Controls.Add(buttonModificar);
            panel2.Controls.Add(buttonEliminar);
            panel2.Controls.Add(buttonLimpiar);
            panel2.Location = new Point(21, 117);
            panel2.Name = "panel2";
            panel2.Size = new Size(1598, 145);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.PaleVioletRed;
            label2.Location = new Point(16, 30);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 0;
            label2.Text = "Nombre:";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(16, 57);
            textBoxNombre.MaxLength = 50;
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(279, 27);
            textBoxNombre.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.PaleVioletRed;
            label3.Location = new Point(326, 30);
            label3.Name = "label3";
            label3.Size = new Size(186, 21);
            label3.TabIndex = 2;
            label3.Text = "Nombre de Usuario:";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(326, 57);
            textBoxUsername.MaxLength = 50;
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(230, 27);
            textBoxUsername.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.PaleVioletRed;
            label4.Location = new Point(588, 30);
            label4.Name = "label4";
            label4.Size = new Size(117, 21);
            label4.TabIndex = 4;
            label4.Text = "Contraseña:";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(588, 57);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '●';
            textBoxPassword.Size = new Size(220, 27);
            textBoxPassword.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.PaleVioletRed;
            label5.Location = new Point(864, 30);
            label5.Name = "label5";
            label5.Size = new Size(46, 21);
            label5.TabIndex = 6;
            label5.Text = "Rol:";
            // 
            // comboBoxRol
            // 
            comboBoxRol.FormattingEnabled = true;
            comboBoxRol.Location = new Point(838, 56);
            comboBoxRol.Name = "comboBoxRol";
            comboBoxRol.Size = new Size(220, 28);
            comboBoxRol.TabIndex = 7;
            // 
            // buttonRegistrar
            // 
            buttonRegistrar.BackColor = Color.PaleVioletRed;
            buttonRegistrar.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRegistrar.ForeColor = Color.White;
            buttonRegistrar.Location = new Point(1116, 18);
            buttonRegistrar.Name = "buttonRegistrar";
            buttonRegistrar.Size = new Size(130, 44);
            buttonRegistrar.TabIndex = 8;
            buttonRegistrar.Text = "➕ Agregar";
            buttonRegistrar.UseVisualStyleBackColor = false;
            // 
            // buttonModificar
            // 
            buttonModificar.BackColor = Color.PaleVioletRed;
            buttonModificar.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonModificar.ForeColor = Color.White;
            buttonModificar.Location = new Point(1275, 18);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(140, 44);
            buttonModificar.TabIndex = 9;
            buttonModificar.Text = "✏️ Modificar";
            buttonModificar.UseVisualStyleBackColor = false;
            // 
            // buttonEliminar
            // 
            buttonEliminar.BackColor = Color.PaleVioletRed;
            buttonEliminar.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEliminar.ForeColor = Color.White;
            buttonEliminar.Location = new Point(1116, 84);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(130, 42);
            buttonEliminar.TabIndex = 10;
            buttonEliminar.Text = "🗑️ Eliminar";
            buttonEliminar.UseVisualStyleBackColor = false;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.BackColor = Color.PaleVioletRed;
            buttonLimpiar.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLimpiar.ForeColor = Color.White;
            buttonLimpiar.Location = new Point(1275, 84);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(140, 42);
            buttonLimpiar.TabIndex = 11;
            buttonLimpiar.Text = "\U0001f9f9 Limpiar Campos";
            buttonLimpiar.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.SeaShell;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(textBoxBuscar);
            panel3.Controls.Add(buttonBuscar);
            panel3.Location = new Point(21, 280);
            panel3.Name = "panel3";
            panel3.Size = new Size(1598, 80);
            panel3.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.PaleVioletRed;
            label6.Location = new Point(42, 16);
            label6.Name = "label6";
            label6.Size = new Size(269, 21);
            label6.TabIndex = 0;
            label6.Text = "Buscar por Nombre / Usuario:";
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Location = new Point(42, 40);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.Size = new Size(500, 27);
            textBoxBuscar.TabIndex = 1;
            // 
            // buttonBuscar
            // 
            buttonBuscar.BackColor = Color.PaleVioletRed;
            buttonBuscar.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBuscar.ForeColor = Color.White;
            buttonBuscar.Location = new Point(561, 32);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(130, 35);
            buttonBuscar.TabIndex = 2;
            buttonBuscar.Text = "🔍 Buscar";
            buttonBuscar.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.SeaShell;
            panel4.Controls.Add(dataGridView1);
            panel4.Location = new Point(21, 380);
            panel4.Name = "panel4";
            panel4.Size = new Size(1598, 539);
            panel4.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.Pink;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID_Usuario, Nombre, Username, Nombre_Rol });
            dataGridView1.GridColor = Color.Pink;
            dataGridView1.Location = new Point(16, 16);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1566, 522);
            dataGridView1.TabIndex = 0;
            // 
            // ID_Usuario
            // 
            ID_Usuario.HeaderText = "ID Usuario";
            ID_Usuario.MinimumWidth = 6;
            ID_Usuario.Name = "ID_Usuario";
            ID_Usuario.ReadOnly = true;
            ID_Usuario.Width = 120;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 500;
            // 
            // Username
            // 
            Username.HeaderText = "Nombre de Usuario";
            Username.MinimumWidth = 6;
            Username.Name = "Username";
            Username.Width = 400;
            // 
            // Nombre_Rol
            // 
            Nombre_Rol.HeaderText = "Rol";
            Nombre_Rol.MinimumWidth = 6;
            Nombre_Rol.Name = "Nombre_Rol";
            Nombre_Rol.Width = 300;
            // 
            // configuracion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1631, 1019);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "configuracion";
            Text = "seguridad";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private TextBox textBoxNombre;
        private Label label3;
        private TextBox textBoxUsername;
        private Label label4;
        private TextBox textBoxPassword;
        private Label label5;
        private ComboBox comboBoxRol;
        private Button buttonRegistrar;
        private Button buttonModificar;
        private Button buttonEliminar;
        private Button buttonLimpiar;
        private Panel panel3;
        private Label label6;
        private TextBox textBoxBuscar;
        private Button buttonBuscar;
        private Panel panel4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID_Usuario;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Nombre_Rol;
    }
}