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
        private DateTime fechaInicial;
        public FormRegistroCliente(string usuario)
        {
            InitializeComponent();
            nombreUsuario = usuario;
            fechaInicial = dateTimePickerFechNac.Value;
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
        // Validar campos requeridos
        private bool ValidarCamposObligatorios()
        {
            if(textBoxNombre.Text == ""|| textBoxApellido.Text == ""|| textBoxDNI.Text == ""|| textBoxDireccion.Text == ""|| textBoxTelefono.Text == "" ){
                return false;
            }

            bool radioSeleccionadoGenero = groupBoxGenero.Controls
        .OfType<RadioButton>()
        .Any(r => r.Checked);

            bool radioSeleccionadoSocio = groupBoxSocio.Controls
       .OfType<RadioButton>()
       .Any(r => r.Checked);
            bool radioSeleccionadoAptoFisico = groupBoxAptoFisico.Controls
        .OfType<RadioButton>()
        .Any(r => r.Checked);

            if (!radioSeleccionadoGenero || !radioSeleccionadoSocio || !radioSeleccionadoAptoFisico)
            {
                return false;
            }

            if (dateTimePickerFechNac.Value.Date == fechaInicial.Date)
            {
                return false;
            }

            return true; 
        }

        //############################################
        //Botones
        //ACEPTAR Y EMITIR CARNET
        private void buttonRegistroClienteAceptar_Click(object sender, EventArgs e)
        {
            // Función de validación
            if (!ValidarCamposObligatorios())
            {
                
                MessageBox.Show("Todos los campos son obligatorios.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //Configuracion aceptar

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

