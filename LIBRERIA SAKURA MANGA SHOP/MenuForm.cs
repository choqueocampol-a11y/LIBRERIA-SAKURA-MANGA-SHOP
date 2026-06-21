using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBRERIA_SAKURA_MANGA_SHOP
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }
        private void abrirpanel(object formhijo)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(fh);
            this.panel2.Tag = fh;
            fh.Show();
        }

        private void modulo_ventas_Click(object sender, EventArgs e)
        {
            abrirpanel(new ventas());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirpanel(new inventario());
        }

        private void btn_modulo_proveedor_Click(object sender, EventArgs e)
        {
            abrirpanel(new compraProveedor());
        }

        private void btn_reportes_Click(object sender, EventArgs e)
        {
            abrirpanel(new reportes());
        }

        private void btn_configuracion_Click(object sender, EventArgs e)
        {
            abrirpanel(new configuracion());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas cerrar sesión?",
                             "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Hide();
                login login = new login();
                login.Show();
            }
        }
    }
}

