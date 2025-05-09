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
    }
}
