namespace LIBRERIA_SAKURA_MANGA_SHOP
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            user = new TextBox();
            password = new TextBox();
            Contraseña = new Label();
            usuario = new Label();
            button1 = new Button();
            panel1 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Narrow", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(202, 37);
            label1.Name = "label1";
            label1.Size = new Size(236, 86);
            label1.TabIndex = 7;
            label1.Text = "SAKURA \r\nMANGA SHOP ";
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(30, 49);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(166, 98);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(158, 196);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(153, 141);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // user
            // 
            user.Location = new Point(240, 365);
            user.Name = "user";
            user.Size = new Size(125, 27);
            user.TabIndex = 3;
            user.TextChanged += user_TextChanged;
            // 
            // password
            // 
            password.Location = new Point(240, 419);
            password.Name = "password";
            password.Size = new Size(125, 27);
            password.TabIndex = 4;
            password.UseSystemPasswordChar = true;
            // 
            // Contraseña
            // 
            Contraseña.AutoSize = true;
            Contraseña.BackColor = Color.Transparent;
            Contraseña.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Contraseña.ForeColor = SystemColors.ActiveCaptionText;
            Contraseña.Location = new Point(92, 419);
            Contraseña.Name = "Contraseña";
            Contraseña.Size = new Size(104, 24);
            Contraseña.TabIndex = 2;
            Contraseña.Text = "Contraseña:";
            // 
            // usuario
            // 
            usuario.AutoSize = true;
            usuario.BackColor = Color.Transparent;
            usuario.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usuario.ForeColor = SystemColors.ActiveCaptionText;
            usuario.Location = new Point(121, 368);
            usuario.Name = "usuario";
            usuario.Size = new Size(75, 24);
            usuario.TabIndex = 1;
            usuario.Text = "Usuario:";
            // 
            // button1
            // 
            button1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(142, 500);
            button1.Name = "button1";
            button1.Size = new Size(191, 40);
            button1.TabIndex = 0;
            button1.Text = "Iniciar sesión";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FloralWhite;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(password);
            panel1.Controls.Add(Contraseña);
            panel1.Controls.Add(user);
            panel1.Controls.Add(usuario);
            panel1.Location = new Point(587, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 608);
            panel1.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(204, 123);
            label2.Name = "label2";
            label2.Size = new Size(234, 33);
            label2.TabIndex = 12;
            label2.Text = "サクラマンガショップ";
            label2.Click += label2_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1646, 819);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "login";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private TextBox user;
        private TextBox password;
        private Label Contraseña;
        private Label usuario;
        private Button button1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
    }
}
