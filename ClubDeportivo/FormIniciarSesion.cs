using System.Data;

namespace ClubDeportivo
{
    public partial class FormIniciarSesion : Form
    {
        public FormIniciarSesion()
        {
            InitializeComponent();
        }

        //prueba sin base de datos
        /*private void buttonIngresar_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsuario.Text;
            string contrasena = textBoxContrasena.Text;

            if (usuario == "admin" && contrasena == "1234")
            {
                FormHome formHome = new FormHome();
                formHome.Show();
                this.Hide();//this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/

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



        //nose si queremos q el boton cancelar vuelva a inicio o cierre todo
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            FormPantallaInicio formInicio = new FormPantallaInicio();
            formInicio.Show();
            this.Hide();// this.Close();        
        }

        //version que cierra toda la aplicación
        /*private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }*/
        

        /* private void labelInicioBienvenida_Click(object sender, EventArgs e)
         {

         }*/
    }
}
