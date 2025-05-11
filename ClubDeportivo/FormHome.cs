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
            FormRegistroCliente nuevoFormulario = new FormRegistroCliente(nombreUsuario);
            nuevoFormulario.Show();
            this.Hide();
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
    }
}
