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
        private bool cancelando = false;
        public FormPagoSocio(string usuario)
        {
            InitializeComponent();
            nombreUsuario = usuario;
            //si ingreso un idCliente incorrecto igual puedo cerrar el form
            buttonPagoSocioCancelar.CausesValidation = false;
        }


        //Si se elige tarjeta se habilitan los campos
        private void comboBoxModoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool habilitar = comboBoxModoPago.SelectedItem?.ToString() == "Tarjeta";
            labelNumCuota.Enabled = habilitar;
            comboBoxNumCuota.Enabled = habilitar;
            labelNumTarjeta.Enabled = habilitar;
            textBoxNumTarjeta.Enabled = habilitar;
            label5Warning.Enabled = habilitar;
            label6Warning.Enabled = habilitar;
            
        }

        //Fc. para obtener las cuotas impagas de un cliente que debe ser socio
        private void CargarCuotasImpagas()
        {
            if (int.TryParse(textBoxIdClienteSocio.Text, out int idCliente))
            {
                //Valida el cliente existe y es socio
                var (existe, esSocio) = new Cliente().VerificarClienteIDYBooleanSocio(idCliente);

                if (!existe)
                {
                    MessageBox.Show("El ID del cliente no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!esSocio)
                {
                    MessageBox.Show("El cliente no es socio, no se puede registrar el pago.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (!existe || !esSocio)
                {
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
            if (cancelando) return;

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
                comboBoxNumCuota.Text
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
                int idCliente = Convert.ToInt32(textBoxIdClienteSocio.Text);
                doc.idCliente = idCliente;
                decimal monto = decimal.Parse(textBoxMontoPagoSocio.Text);
                doc.montoPago = monto;
                doc.modoPago = comboBoxModoPago.SelectedItem.ToString();
                if (comboBoxSeleccionarCuota.SelectedItem is E_Cuota cuota)
                {
                    doc.cuotaAbonada = cuota.FechaVencimiento.ToString("dd/MM/yyyy");
                }
                doc.numCuotas = string.IsNullOrEmpty(comboBoxNumCuota.Text) ? null : int.Parse(comboBoxNumCuota.Text);
                doc.numTarjeta = comboBoxModoPago.SelectedItem.ToString() == "tarjeta" ? textBoxNumTarjeta.Text : null;
                int idCuotaSeleccionada = Convert.ToInt32(comboBoxSeleccionarCuota.SelectedValue);
                //usuario para home
                doc.usuarioActual = nombreUsuario;
                int cantCuotas = 0;
                int digTarj = 0;
                if (doc.modoPago == "Tarjeta")
                {
                    cantCuotas = Convert.ToInt32(comboBoxNumCuota.SelectedItem.ToString());
                    digTarj = Convert.ToInt32(textBoxNumTarjeta.Text);

                    
                }
                
                // Actualizar estado de la cuota existente
                Socio.RegistrarPagoCuota(idCuotaSeleccionada, DateTime.UtcNow, doc.modoPago, cantCuotas, digTarj);

                Socio.CrearProximaCuota(idCliente, monto);

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
            cancelando = true;
            this.Close();
            new FormHome(nombreUsuario).Show();
            
        }
    }
    }
