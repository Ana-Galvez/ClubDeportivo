using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClubDeportivo
{
    public partial class FormPagoSocio : Form
    {
        private string nombreUsuario;
        public FormPagoSocio(string usuario)
        {
            InitializeComponent();
            nombreUsuario = usuario;
        }
        //Si se elige tarjeta se habilitan los campos
        private void comboBoxModoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool habilitar = comboBoxModoPago.SelectedItem?.ToString() == "Tarjeta";
            labelNumCuota.Enabled = habilitar;
            comboBoxNumCuota.Enabled = habilitar;
            labelNumTarjeta.Enabled = habilitar;
            textBoxNumTarjeta.Enabled = habilitar;
            textBoxNumVerificacion.Enabled = habilitar;
            labelNumVerificacion.Enabled = habilitar;
            labelFechVenc.Enabled = habilitar;
            dateTimePickerFechVen.Enabled = habilitar;
            label5Warning.Enabled = habilitar;
            label6Warning.Enabled = habilitar;
            label7Warning.Enabled = habilitar;
            label8Warning.Enabled = habilitar;
        }

        private string ValidarCamposObligatoriosDetalle()
        {
            //Id Cliente
            //Valida que no esté vacio el campo
            if (string.IsNullOrWhiteSpace(textBoxIdClienteSocio.Text))
                return "Debe ingresar ID del cliente.";
            //Verifica que solo se usen números
            if (!int.TryParse(textBoxIdClienteSocio.Text, out int idCliente))
                return "El ID del cliente debe ser un número válido.";

            // Valida que el cliente existe
            Datos.Cliente dato = new Datos.Cliente();
            DataTable tablaCliente = dato.VerificarClienteID(idCliente);
            if (tablaCliente.Rows.Count == 0)
                return "El ID del cliente no existe.";

            //Monto
            if (string.IsNullOrWhiteSpace(textBoxMontoPagoSocio.Text))
                return "Debe ingresar el monto a pagar.";
            if (!int.TryParse(textBoxMontoPagoSocio.Text, out int monto) || monto <= 0)
                return "El monto debe ser un número válido y mayor a 0.";
            //Seleccionar Cuota
            if (string.IsNullOrWhiteSpace(comboBoxSeleccionarCuota.Text))
                return "Debe ingresar la cuota a pagar.";
            //Modo Pago
            if (string.IsNullOrWhiteSpace(comboBoxModoPago.Text))
                return "Debe ingresar el modo de pago.";
            // Se validan como campos obligarios solo si el modo de pago seleccionado es Tarjeta
            if (comboBoxModoPago.SelectedItem?.ToString() == "Tarjeta")
            {
                //Cuota
                if (string.IsNullOrWhiteSpace(comboBoxNumCuota.Text))
                    return "Debe ingresar la cantidad de cuotas a pagar.";
                //Num Tarjeta
                if (string.IsNullOrWhiteSpace(textBoxNumTarjeta.Text))
                    return "Debe ingresar el N° de tarjeta.";
                if (!int.TryParse(textBoxNumTarjeta.Text, out _))
                    return "El N° de tarjeta debe contener solo números.";
                //Num Verificación
                if (string.IsNullOrWhiteSpace(textBoxNumVerificacion.Text))
                    return "Debe ingresar el N° de verificación de la tarjeta.";
                if (!int.TryParse(textBoxNumVerificacion.Text, out _))
                    return "El N° de verificación debe contener solo números.";
                //Fecha de vencimiento
                if (dateTimePickerFechVen.Value.Date <= DateTime.Today)
                    return "La fecha de vencimiento de la tarjeta debe ser futura.";
            }
            return "";
        }
        private void buttonPagoSocioAceptar_Click(object sender, EventArgs e)
        {
            //verifico las validaciones de campos y que el cliente existe
            string mensajeValidacion = ValidarCamposObligatoriosDetalle();
            if (mensajeValidacion != "")
            {
                MessageBox.Show(mensajeValidacion, "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }
        private void buttonPagoSocioCancelar_Click(object sender, EventArgs e)
        {
            new FormHome(nombreUsuario).Show();
            this.Close();
        }

        private void labelPagoSocioTitulo_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxSeleccionarCuota_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxNumCuota_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
