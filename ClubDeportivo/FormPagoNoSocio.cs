using ClubDeportivo.Datos;
using ClubDeportivo.Entidades;
using ClubDeportivo.Helpers.Validaciones;
using ClubDeportivo.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ClubDeportivo
{
    public partial class FormPagoNoSocio : Form
    {
        private string nombreUsuario;
        public ModalReciboNoSocio doc = new ModalReciboNoSocio();
        // Constructor con parámetro
        public FormPagoNoSocio(string usuario)
        {
            InitializeComponent();
            nombreUsuario = usuario;
            buttonPagoNoSocioCancelar.CausesValidation = false;
        }
        private List<E_Actividad> actividades;
        private void FormPagoNoSocio_Load(object sender, EventArgs e)
        {
            MessageBox.Show(
        "Recuerda que los no socios solo abonan en efectivo",
        "Ayuda para pago no socios",
        MessageBoxButtons.OK,
        MessageBoxIcon.Exclamation);
            try
            {
                actividades = NoSocio.ObtenerActividades();
                actividades.Insert(0, new E_Actividad
                {
                    IDActividad = 0,
                    Nombre = "Seleccionar...",
                    DiaSemana = "",
                    Hora = TimeSpan.Zero,
                    Precio = 0
                });
                if (actividades != null && actividades.Count > 0)
                {
                    comboBoxSeleccionarActividad.DataSource = actividades;
                    comboBoxSeleccionarActividad.DisplayMember = "NombreYDia";
                    comboBoxSeleccionarActividad.ValueMember = "IDActividad";
                    comboBoxSeleccionarActividad.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("No se encontraron actividades disponibles.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar actividades: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxIdClienteNoSocio_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidacionIdClienteHelper.ValidarIdCliente(textBoxIdClienteNoSocio, out int idCliente))
            {
                e.Cancel = true;
                return;
            }

            var (existe, esSocio) = new Cliente().VerificarClienteIDYBooleanSocio(idCliente);

            if (!existe)
            {
                MessageBox.Show("El ID del cliente no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }else if (esSocio)
            {
                MessageBox.Show("El cliente es socio no se puede registrar el pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void textBoxIdClienteNoSocio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ValidacionIdClienteHelper.ValidarIdCliente(textBoxIdClienteNoSocio, out int idCliente))
                {
                    var (existe, esSocio) = new Cliente().VerificarClienteIDYBooleanSocio(idCliente);

                    if (!existe || esSocio)
                    {
                        MessageBox.Show("El ID del cliente no existe o es socio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        e.Handled = true;
                        return;
                    }

                    this.SelectNextControl(textBoxIdClienteNoSocio, true, true, true, true);
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void comboBoxSeleccionarActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSeleccionarActividad.SelectedValue != null &&
                int.TryParse(comboBoxSeleccionarActividad.SelectedValue.ToString(), out int idActividadSeleccionada))
            {
                E_Actividad actividad = actividades.FirstOrDefault(a => a.IDActividad == idActividadSeleccionada);

                if (actividad != null)
                {
                    textBoxHoraActividad.Text = actividad.Hora.ToString(@"hh\:mm");
                    textBoxMontoPagoNoSocio.Text = actividad.Precio.ToString("F2");
                }
            }
        }

        private string ValidarCamposObligatoriosDetalle()
        {
            string actividad = (comboBoxSeleccionarActividad.SelectedItem as E_Actividad)?.NombreYDia ?? "";
            string horario = textBoxHoraActividad.Text;

            if (string.IsNullOrWhiteSpace(horario) || horario == "00:00")
            {
                return "Debes seleccionar una actividad.";
            }

            return ValidacionCamposNoSocio.ValidarCamposPagoNoSocio(
                actividad,
                horario,
                textBoxMontoPagoNoSocio.Text
            );
        }

        private void buttonPagoNoSocioAceptar_Click(object sender, EventArgs e)
        {
            string errorValidacion = ValidarCamposObligatoriosDetalle();
            if (!string.IsNullOrEmpty(errorValidacion))
            {
                MessageBox.Show(errorValidacion, "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBoxIdClienteNoSocio.Text, out int idCliente))
            {
                MessageBox.Show("ID Cliente inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(textBoxMontoPagoNoSocio.Text, out decimal monto))
            {
                MessageBox.Show("Monto inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                DateTime fechaPago = DateTime.Now;
                var datosNoSocio = Cliente.ObtenerDatosCliente(idCliente);
                // Obtener datos de la db y pasarlos al formulario siguiente
                doc.nombreApellido = datosNoSocio;

                // Datos ingresados manualmente en el formulario y pasarlos al formulario siguiente
                doc.idCliente = idCliente;
                doc.montoPago = monto;
                if (comboBoxSeleccionarActividad.SelectedItem is E_Actividad actividad)
                {
                    doc.actividadAbonada = actividad.NombreYDia;
                    doc.horario = actividad.Hora.ToString(@"hh\:mm");
                }
                //usuario para home
                doc.usuarioActual = nombreUsuario;
                int idActividadSeleccionada = Convert.ToInt32(comboBoxSeleccionarActividad.SelectedValue);
                // Insertar el pago
                NoSocio.RegistrarPagoActividad(idCliente, idActividadSeleccionada, fechaPago, monto);

                MessageBox.Show("Pago registrado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                doc.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\n\nStackTrace:\n{ex.StackTrace}",
            "MENSAJE DEL CATCH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPagoNoSocioCancelar_Click(object sender, EventArgs e)
        {
            new FormHome(nombreUsuario).Show();
            this.Close();
        }

        private void labelPagoNoSocioTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}