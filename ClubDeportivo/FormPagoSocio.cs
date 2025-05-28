using ClubDeportivo.Datos;
using ClubDeportivo.Entidades;
using ClubDeportivo.Helpers.Validaciones;
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
                var (existe, esSocio) = new Cliente().VerificarClienteIDYBooleanSocio(idCliente);

                if (!existe || !esSocio)
                {
                    MessageBox.Show("El ID del cliente no existe o no es socio .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    BeginInvoke(new Action(() =>
                    {
                        comboBoxSeleccionarCuota.DataSource = null;
                        comboBoxSeleccionarCuota.Items.Clear();
                    }));
                    return;
                }

                List<E_Cuota> cuotas = Socio.ObtenerCuotasImpagas(idCliente);

                BeginInvoke(new Action(() =>
                {
                    if (cuotas == null || cuotas.Count == 0)
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
                        comboBoxSeleccionarCuota.Refresh();
                        comboBoxSeleccionarCuota.Update();
                    }
                }));

            }
            else
            {
                MessageBox.Show("ID de cliente inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private bool ValidarYProcesarIdCliente()
        {
            if (ValidacionIdClienteHelper.ValidarIdCliente(textBoxIdClienteSocio, out int idCliente))
            {
                CargarCuotasImpagas();
                return true;
            }
            return false;
        }

        private void textBoxIdClienteSocio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ValidarYProcesarIdCliente())
                {
                    this.SelectNextControl(textBoxIdClienteSocio, true, true, true, true);
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void comboBoxSeleccionarCuota_Monto(object sender, EventArgs e)
        {
            if (comboBoxSeleccionarCuota.SelectedItem is E_Cuota cuotaSeleccionada)
            {
                decimal monto = cuotaSeleccionada.Monto;
                textBoxMontoPagoSocio.Text = monto.ToString();
            }
        }
        private void textBoxIdClienteSocio_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidarYProcesarIdCliente())
            {
                e.Cancel = true;
            }
        }

        private string ValidarCamposObligatoriosDetalle()
        {
            return ValidacionCamposPagoSocio.ValidarCamposPagoSocio(
                textBoxMontoPagoSocio.Text,
                comboBoxSeleccionarCuota.Text,
                comboBoxModoPago.Text,
                textBoxNumTarjeta.Text,
                textBoxNumVerificacion.Text,
                comboBoxNumCuota.Text,
                dateTimePickerFechVen.Value
            );
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
                var datosSocio = Cliente.ObtenerDatosCliente(Convert.ToInt32(textBoxIdClienteSocio.Text));
                // Obtener datos de la db y pasarlos al formulario siguiente
                doc.nombreApellido = datosSocio;

                // Datos ingresados manualmente en el formulario y pasarlos al formulario siguiente
                doc.idCliente = Convert.ToInt32(textBoxIdClienteSocio.Text);
                doc.montoPago = decimal.Parse(textBoxMontoPagoSocio.Text);
                doc.modoPago = comboBoxModoPago.SelectedItem.ToString();
                if (comboBoxSeleccionarCuota.SelectedItem is E_Cuota cuota)
                {
                    doc.cuotaAbonada = cuota.FechaVencimiento.ToString("dd/MM/yyyy");
                }
                doc.numCuotas = string.IsNullOrEmpty(comboBoxNumCuota.Text) ? null : int.Parse(comboBoxNumCuota.Text);
                doc.numTarjeta = comboBoxModoPago.SelectedItem.ToString() == "tarjeta" ? textBoxNumTarjeta.Text : null;
                doc.numVerificacion = comboBoxModoPago.SelectedItem.ToString() == "tarjeta" ? textBoxNumVerificacion.Text : null;

                int idCuotaSeleccionada = Convert.ToInt32(comboBoxSeleccionarCuota.SelectedValue);
                //usuario para home
                doc.usuarioActual = nombreUsuario;

                // Actualizar estado de la cuota existente
                Socio.RegistrarPagoCuota(idCuotaSeleccionada, DateTime.UtcNow);

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
            this.Close();
        }
        private void buttonPagoSocioCancelar_Click(object sender, EventArgs e)
        {
            new FormHome(nombreUsuario).Show();
            this.Close();
        }
    }
    }
