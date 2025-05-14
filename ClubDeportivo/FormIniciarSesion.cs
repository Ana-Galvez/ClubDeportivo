using System.Data;

namespace ClubDeportivo
{
    public partial class FormIniciarSesion : Form
    {
        public FormIniciarSesion()
        {
            InitializeComponent();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsuario.Text.Trim();
            string contrasena = textBoxContrasena.Text.Trim();

            Datos.Usuario datosUsuario = new Datos.Usuario();
            DataTable dt = datosUsuario.Log_Usu(usuario, contrasena);

            if (dt.Rows.Count > 0)
            {
                string nombre = dt.Rows[0]["NombreUsu"].ToString();
                string rol = dt.Rows[0]["NomRol"].ToString();
                FormHome home = new FormHome(nombre);
                home.Show();
                this.Hide();
            }
            else
            {
                // Fallo login
                MessageBox.Show("Usuario o contraseña incorrectos o el usuario está inactivo.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxContrasena.Clear();
                textBoxContrasena.Focus();
            }
        }


        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            FormPantallaInicio formInicio = new FormPantallaInicio();
            formInicio.Show();
            this.Hide();// this.Close();        
        }

        
    }
}
