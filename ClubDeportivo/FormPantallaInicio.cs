namespace ClubDeportivo
{
    public partial class FormPantallaInicio : Form
    {
        public FormPantallaInicio()
        {
            InitializeComponent();
        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            FormIniciarSesion nuevoFormulario = new FormIniciarSesion();
            nuevoFormulario.Show();
            this.Hide(); //la deja en memoria
        }

        private void FormPantallaInicio_Load(object sender, EventArgs e)
        {
            //pido los datos y creo la conexion a la base de datos
            var con = Datos.Conexion.getInstancia().CrearConexion();
            
        }
    }
}
