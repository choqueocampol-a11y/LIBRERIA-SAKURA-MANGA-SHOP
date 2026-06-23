using System;
using System.Windows.Forms;
using Libreria_Datos;
using Libreria_Negocio;

namespace LIBRERIA_SAKURA_MANGA_SHOP
{
    public partial class configuracion : Form
    {
        private readonly UsuarioNegocio _usuarioNegocio = new UsuarioNegocio();
        private int _idUsuarioSeleccionado = 0;
        private readonly RolNegocio _rolNegocio = new RolNegocio();
        public configuracion()
        {
            InitializeComponent();
            CargarUsuarios();
            CargarRoles();
        }

        private void configuracion_Load(object sender, EventArgs e)
        {
            
        }
        private void CargarRoles()
        {
            try
            {
                var roles = _rolNegocio.ListarRoles();

                
                comboBoxRol.DataSource = null; 
                comboBoxRol.DataSource = roles;
                comboBoxRol.DisplayMember = "Nombre_Rol";
                comboBoxRol.ValueMember = "ID_Rol";
                comboBoxRol.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar roles: " + ex.Message);
            }
        }
        private void CargarUsuarios()
        {
            try
            {
                var usuarios = _usuarioNegocio.ListarUsuarios();
                MostrarUsuariosEnGrid(usuarios);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarUsuariosEnGrid(System.Collections.Generic.List<UsuarioModel> usuarios)
        {
            dataGridView1.DataSource = null;
            dataGridView1.AutoGenerateColumns = false; 
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID Usuario",
                DataPropertyName = "ID_Usuario",
                Name = "ID_Usuario",
                Width = 80
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Nombre",
                DataPropertyName = "Nombre",
                Name = "Nombre",
                Width = 200
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Nombre de Usuario",
                DataPropertyName = "Username",
                Name = "Username",
                Width = 200
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Rol",
                DataPropertyName = "Nombre_Rol",
                Name = "Nombre_Rol",
                Width = 150
            });

            dataGridView1.DataSource = usuarios;
        }
        

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBoxRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            if (comboBoxRol.SelectedValue == null || comboBoxRol.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecciona un rol válido.");
                return;
            }

            if (ValidarCampos())
            {
                try
                {
                    var nuevoUsuario = new UsuarioModel
                    {
                        Nombre = textBoxNombre.Text.Trim(),
                        Username = textBoxUsername.Text.Trim(),
                        Password = textBoxPassword.Text,
                        ID_Rol = Convert.ToInt32(comboBoxRol.SelectedValue)
                    };

                    _usuarioNegocio.RegistrarUsuario(nuevoUsuario);
                    MessageBox.Show("Usuario registrado correctamente 🌸", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    LimpiarFormulario(); 
                    CargarUsuarios();    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar: " + ex.Message);
                }
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (_idUsuarioSeleccionado == 0)
            {
                MessageBox.Show("Selecciona un usuario para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBoxRol.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecciona un rol válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ValidarCampos())
            {
                try
                {
                    var usuarioModificado = new UsuarioModel
                    {
                        ID_Usuario = _idUsuarioSeleccionado,
                        Nombre = textBoxNombre.Text.Trim(),
                        Username = textBoxUsername.Text.Trim(),
                        Password = textBoxPassword.Text.Trim(),
                        ID_Rol = Convert.ToInt32(comboBoxRol.SelectedValue) 
                    };

                    _usuarioNegocio.ModificarUsuario(usuarioModificado);
                    MessageBox.Show("Usuario modificado correctamente 🌸", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                    CargarUsuarios();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (_idUsuarioSeleccionado == 0)
            {
                MessageBox.Show("Selecciona un usuario para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    _usuarioNegocio.EliminarUsuario(_idUsuarioSeleccionado);
                    MessageBox.Show("Usuario eliminado correctamente 🌸", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                    CargarUsuarios();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
                _idUsuarioSeleccionado = Convert.ToInt32(fila.Cells["ID_Usuario"].Value);
                textBoxNombre.Text = fila.Cells["Nombre"].Value.ToString();
                textBoxUsername.Text = fila.Cells["Username"].Value.ToString();

                foreach (RolModel rol in comboBoxRol.Items)
                {
                    if (rol.Nombre_Rol == fila.Cells["Nombre_Rol"].Value.ToString())
                    {
                        comboBoxRol.SelectedItem = rol;
                        break;
                    }
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
                _idUsuarioSeleccionado = Convert.ToInt32(fila.Cells["ID_Usuario"].Value);
                textBoxNombre.Text = fila.Cells["Nombre"].Value.ToString();
                textBoxUsername.Text = fila.Cells["Username"].Value.ToString();

                foreach (RolModel rol in comboBoxRol.Items)
                {
                    if (rol.Nombre_Rol == fila.Cells["Nombre_Rol"].Value.ToString())
                    {
                        comboBoxRol.SelectedItem = rol;
                        break;
                    }
                }
            }
        }

        private void LimpiarFormulario()
        {
            textBoxNombre.Clear();
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            _idUsuarioSeleccionado = 0;
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(textBoxNombre.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxUsername.Text))
            {
                MessageBox.Show("El nombre de usuario no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxPassword.Text) && _idUsuarioSeleccionado == 0)
            {
                MessageBox.Show("La contraseña no puede estar vacía para nuevos usuarios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void configuracion_Load_1(object sender, EventArgs e)
        {
            
        }
    }
}