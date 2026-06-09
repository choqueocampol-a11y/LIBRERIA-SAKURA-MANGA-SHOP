using System;
using System.Windows.Forms;
using Libreria_Negocio;
using Libreria_Datos;


namespace LIBRERIA_SAKURA_MANGA_SHOP

{
    public partial class login : Form

    {
        private UsuarioNegocio _usuarioNegocio = new UsuarioNegocio();
        public login()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = user.Text;
            string passwordIngresado = password.Text;
            try
            {

                UsuarioModel usuarioLogueado = _usuarioNegocio.Login(usuarioIngresado, passwordIngresado);
                if (usuarioLogueado == null)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos. Inténtalo de nuevo. 🌸",
                                    "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MenuForm formularioMenu = new MenuForm();
                    formularioMenu.Show();

                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en el Sistema 🌸", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
