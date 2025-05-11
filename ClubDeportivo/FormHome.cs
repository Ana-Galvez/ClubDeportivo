using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo
{
    public partial class FormHome : Form
    {
        private string nombreUsuario;
        public FormHome(string usuario)
        {
            InitializeComponent();
            nombreUsuario = usuario;
            labelBienvenida.Text = $"¡Bienvenido/a, {nombreUsuario}!";
        }

        private void labelBienvenida_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegistrarCliente_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegistrarPago_Click(object sender, EventArgs e)
        {

        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;

        }

        private void buttonListadoSociosMorosos_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro que deseas cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                // Oculta el formulario actual (por ejemplo, FormHome)
                this.Hide();

                // Abre nuevamente el formulario de inicio de sesión
                FormIniciarSesion login = new FormIniciarSesion();
                login.Show();
            }
        }
    }
}
