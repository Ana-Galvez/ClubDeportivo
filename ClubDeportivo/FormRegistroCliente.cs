using ClubDeportivo.Datos;
using ClubDeportivo.Entidades;
using ClubDeportivo.Helpers;
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
        private void radioButtonFemenino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonMasculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonPrefNoDecir_CheckedChanged(object sender, EventArgs e)
        {

        }
        
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
        //¿APTO FÍSICO?
        private void radioButtonAptoFisicoSi_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButtonAptoFisicoNo_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        //¿SOCIO?
        private void radioButtonSocioSi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonSocioNo_CheckedChanged(object sender, EventArgs e)
        {

        }

        //Versión del validar datos de entrada con mensajes
        private string ValidarCamposObligatoriosDetalle()
        {
            //nombre
            if (string.IsNullOrWhiteSpace(textBoxNombre.Text))
                return "Debe ingresar el nombre.";
            //apellido
            if (string.IsNullOrWhiteSpace(textBoxApellido.Text))
                return "Debe ingresar el apellido.";
            //Fecha nac
            if (dateTimePickerFechNac.Value.Date == DateTime.Today)
                return "Debe seleccionar una fecha de nacimiento válida.";
            if (dateTimePickerFechNac.Value.Date > DateTime.Today)
                return "La fecha de nacimiento no puede ser futura.";
            //dni
            if (string.IsNullOrWhiteSpace(textBoxDNI.Text))
                return "Debe ingresar el DNI.";
            //dirección
            if (string.IsNullOrWhiteSpace(textBoxDireccion.Text))
                return "Debe ingresar la dirección.";
            //telefono
            if (string.IsNullOrWhiteSpace(textBoxTelefono.Text))
                return "Debe ingresar el teléfono.";
            //genero
            bool generoOk = groupBoxGenero.Controls.OfType<RadioButton>().Any(r => r.Checked);
            if (!generoOk)
                return "Debe seleccionar un género.";
            //apto fisico
            bool aptoOk = groupBoxAptoFisico.Controls.OfType<RadioButton>().Any(r => r.Checked);
            if (!aptoOk)
                return "Debe indicar si tiene apto físico.";
            else if (!radioButtonAptoFisicoSi.Checked)
                return "Solo se pueden registrar clientes con apto físico aprobado.";

            //socio o no socio
            bool socioOk = groupBoxSocio.Controls.OfType<RadioButton>().Any(r => r.Checked);
            if (!socioOk)
                return "Debe indicar si es socio.";

            return ""; // Todo OK
        }


        //############################################
        //Botones
        //ACEPTAR Y EMITIR CARNET
        private void buttonRegistroClienteAceptar_Click(object sender, EventArgs e)
        {
            // ------------valido datos obligatorios ---------------------------
           
            string mensajeValidacion = ValidarCamposObligatoriosDetalle();
            if (mensajeValidacion != "")
            {
                MessageBox.Show(mensajeValidacion, "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //------------ obtengo los datos ------------------------------------
            //género
            string genero = radioButtonFemenino.Checked ? "F" : radioButtonMasculino.Checked ? "M" : "Prefiero no decir";
            //apto físico
            bool aptoFisico = radioButtonAptoFisicoSi.Checked;
            // Socio o no socio
            bool socio = radioButtonSocioSi.Checked;
            //Verificar que el ingreso de DNi solo sea números
            int dni;
            if(!int.TryParse(textBoxDNI.Text.Trim(),out dni))
            {
                MessageBox.Show("El campo DNI debe contener SÓLO NÚMEROS.", "ERROR DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // objeto cliente
            Entidades.E_Cliente cliente = new Entidades.E_Cliente
            {
                Nombre = textBoxNombre.Text.Trim(),
                Apellido = textBoxApellido.Text.Trim(),
                FechaNacimiento = dateTimePickerFechNac.Value.Date,
                DNI = dni,
                Genero = genero,
                Direccion = textBoxDireccion.Text.Trim(),
                Telefono = textBoxTelefono.Text.Trim(),
                FechaInscripcion = dateTimePickerFechIns.Value.Date,
                AptoFisico = aptoFisico,
                Socio = socio
            };

            // Llamar al método de inserción
            Datos.Cliente clienteDatos = new Datos.Cliente();
            string respuesta = clienteDatos.Nuevo_Cliente(cliente);

            // Mostrar resultado
            if (respuesta.StartsWith("Cliente creado"))
            {
                string idStr = respuesta.Replace("Cliente creado con ID: ", "").Trim();
                if (int.TryParse(idStr, out int id))
                {
                    cliente.IDCliente = id;
                }
                MessageBox.Show(respuesta, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                FormCarnet volver = new FormCarnet(cliente, nombreUsuario);
                volver.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

