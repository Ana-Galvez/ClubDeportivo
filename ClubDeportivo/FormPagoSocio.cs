using ClubDeportivo.Entidades;
using MySql.Data.MySqlClient;
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
        public ModalReciboSocio doc = new ModalReciboSocio();
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
        private void CargarCuotasImpagas()
        {
            if (int.TryParse(textBoxIdClienteSocio.Text, out int idCliente))
            {
                //Valida el cliente existe y es socio
                if (!E_Socio.EsSocio(idCliente))
                {
                    MessageBox.Show("El ID del cliente no existe o no es socio .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comboBoxSeleccionarCuota.DataSource = null;
                    comboBoxSeleccionarCuota.Items.Clear();
                    return;
                }

                DataTable cuotas = E_Socio.ObtenerCuotasImpagas(idCliente);
                if (cuotas.Rows.Count == 0)
                {
                    MessageBox.Show("No hay cuotas pendientes para este cliente.", "Sin cuotas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboBoxSeleccionarCuota.DataSource = null;
                    comboBoxSeleccionarCuota.Items.Clear();
                }
                else
                {
                    comboBoxSeleccionarCuota.DataSource = cuotas;
                    comboBoxSeleccionarCuota.DisplayMember = "FechaVencimiento";
                    comboBoxSeleccionarCuota.ValueMember = "IdCuota";
                }
            }
            else
            {
                MessageBox.Show("ID de cliente inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxIdClienteSocio_Leave(object sender, EventArgs e)
        {
            //Id Cliente
            //Valida que no esté vacio el campo
            if (string.IsNullOrWhiteSpace(textBoxIdClienteSocio.Text))
            {
                MessageBox.Show("Debe ingresar ID del cliente..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }//Verifica que solo se usen números
            else if
                (!int.TryParse(textBoxIdClienteSocio.Text, out int idCliente))
            {

                MessageBox.Show("El ID del cliente debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            CargarCuotasImpagas();
        }
        private void comboBoxSeleccionarCuota_Monto(object sender, EventArgs e)
        {
            if (comboBoxSeleccionarCuota.SelectedItem is DataRowView filaSeleccionada)
            {
                decimal monto = Convert.ToDecimal(filaSeleccionada["Monto"]);
                textBoxMontoPagoSocio.Text = monto.ToString();
            }
        }

        private string ValidarCamposObligatoriosDetalle()
        {
            //Monto
            if (string.IsNullOrWhiteSpace(textBoxMontoPagoSocio.Text))
                return "Debe ingresar el monto a pagar.";
            //Seleccionar Cuota
            if (string.IsNullOrWhiteSpace(comboBoxSeleccionarCuota.Text))
                return "Debe ingresar la cuota a pagar.";
            //Modo Pago
            if (string.IsNullOrWhiteSpace(comboBoxModoPago.Text))
                return "Debe ingresar el modo de pago.";
            // Se validan como campos obligarios solo si el modo de pago seleccionado es Tarjeta
            if (comboBoxModoPago.SelectedItem?.ToString() == "Tarjeta")
            {
                //Fecha de vencimiento
                if (dateTimePickerFechVen.Value.Date <= DateTime.Today)
                    return "La fecha de vencimiento de la tarjeta debe ser futura.";
                //Cuota
                if (string.IsNullOrWhiteSpace(comboBoxNumCuota.Text))
                    return "Debe ingresar la cantidad de cuotas a pagar.";
                //Num Tarjeta
                if (string.IsNullOrWhiteSpace(textBoxNumTarjeta.Text))
                    return "Debe ingresar el N° de tarjeta.";
                //Num Verificación
                if (string.IsNullOrWhiteSpace(textBoxNumVerificacion.Text))
                    return "Debe ingresar el N° de verificación de la tarjeta.";
            }
            return "";
        }


        private void buttonPagoSocioAceptar_Click(object sender, EventArgs e)
        {
            //verifico las validaciones de campos
            string mensajeValidacion = ValidarCamposObligatoriosDetalle();
            if (mensajeValidacion != "")
            {
                MessageBox.Show(mensajeValidacion, "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                var datosSocio = E_Socio.ObtenerDatosSocio(Convert.ToInt32(textBoxIdClienteSocio.Text));
                // Obtener datos de la db y pasarlos al formulario siguiente
                doc.nombreApellido = datosSocio.NombreApellido;
                // Datos ingresados manualmente en el formulario y pasarlos al formulario siguiente
                doc.idCliente = Convert.ToInt32(textBoxIdClienteSocio.Text);
                doc.montoPago = decimal.Parse(textBoxMontoPagoSocio.Text);
                doc.modoPago = comboBoxModoPago.SelectedItem.ToString();
                if (comboBoxSeleccionarCuota.SelectedItem is DataRowView fila)
                {
                    doc.cuotaAbonada = Convert.ToDateTime(fila["FechaVencimiento"]).ToString("dd/MM/yyyy"); // o el formato que prefieras
                }
                doc.numCuotas = string.IsNullOrEmpty(comboBoxNumCuota.Text) ? null : int.Parse(comboBoxNumCuota.Text);
                doc.numTarjeta = comboBoxModoPago.SelectedItem.ToString() == "tarjeta" ? textBoxNumTarjeta.Text : null;
                doc.numVerificacion = comboBoxModoPago.SelectedItem.ToString() == "tarjeta" ? textBoxNumVerificacion.Text : null;

                int idCuotaSeleccionada = Convert.ToInt32(comboBoxSeleccionarCuota.SelectedValue);

                // Actualizar estado de la cuota existente
                E_Socio.RegistrarPago(idCuotaSeleccionada, DateTime.UtcNow);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\n\nStackTrace:\n{ex.StackTrace}",
        "MENSAJE DEL CATCH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); }
            }
            MessageBox.Show("Pago registrado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            doc.Show();

        }
        private void buttonPagoSocioCancelar_Click(object sender, EventArgs e)
        {
            new FormHome(nombreUsuario).Show();
            this.Close();
        }

    }
}
