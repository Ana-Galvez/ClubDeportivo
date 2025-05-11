using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClubDeportivo.Datos;

namespace ClubDeportivo
{
    public partial class FormRegistroCliente : Form
    {
      private string nombreUsuario;
        public FormRegistroCliente(string usuario)
        {
            InitializeComponent();
            nombreUsuario = usuario;
        }
        //al cargar el formulario sale un recordatorio del apto fisico
        private void FormRegistroCliente_Load(object sender, EventArgs e)
        {
            MessageBox.Show(
        "Recuerda solicitar el apto físico",
        "Ayuda para registro",
        MessageBoxButtons.OK,
        MessageBoxIcon.Exclamation
    );
        }
        //NOMBRE
        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }
        //APELLIDO
        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {

        }
        //FECHA DE NACIMIENTO
        private void dateTimePickerFechNac_ValueChanged(object sender, EventArgs e)
        {

        }
        //DNI
        private void textBoxDNI_TextChanged(object sender, EventArgs e)
        {

        }
        //GÉNERO
        //############################################
        private void radioButtonFemenino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonMasculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonPrefNoDecir_CheckedChanged(object sender, EventArgs e)
        {

        }
        //############################################
        //DIRECCIÓN
        private void textBoxDireccion_TextChanged(object sender, EventArgs e)
        {

        }
        //TÉLEFONO
        private void textBoxTelefono_TextChanged(object sender, EventArgs e)
        {

        }
        //FECHA DE INSCRIPCIÓN
        private void dateTimePickerFechIns_ValueChanged(object sender, EventArgs e)
        {

        }
        //############################################
        //¿APTO FÍSICO?
        private void radioButtonAptoFisicoSi_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButtonAptoFisicoNo_CheckedChanged(object sender, EventArgs e)
        {

        }
        //############################################
        //¿SOCIO?
        private void radioButtonSocioSi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonSocioNo_CheckedChanged(object sender, EventArgs e)
        {

        }
        //############################################
        //Botones
        //ACEPTAR Y EMITIR CARNET
        private void buttonRegistro_Click(object sender, EventArgs e)
        {
           
        }
        //CANCELAR 
        private void buttonRegistroClienteCancelar_Click(object sender, EventArgs e)
        {
            FormHome nuevoFormulario = new FormHome(nombreUsuario);
            nuevoFormulario.Show();
            this.Hide();
        }

    }
    }

