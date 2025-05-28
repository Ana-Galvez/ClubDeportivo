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
          
        }
        private List<E_Actividad> actividades;
        private void FormPagoNoSocio_Load(object sender, EventArgs e)
        {
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

            if (!existe || esSocio)
            {
                MessageBox.Show("El ID del cliente no existe o es socio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (comboBoxSeleccionarActividad.SelectedValue is int idActividadSeleccionada)
            {
                E_Actividad actividad = actividades.FirstOrDefault(a => a.IDActividad == idActividadSeleccionada);

                if (actividad != null)
                {
                    textBoxHoraActividad.Text = actividad.Hora.ToString(@"hh\:mm");
                    textBoxMontoPagoNoSocio.Text = actividad.Precio.ToString(); 
                }
            }
        }
        private string ValidarCamposObligatoriosDetalle()
        {
            string actividad = comboBoxSeleccionarActividad.SelectedItem?.ToString() ?? "";
            return ValidacionCamposNoSocio.ValidarCamposPagoNoSocio(
                actividad,
                textBoxHoraActividad.Text,
                textBoxMontoPagoNoSocio.Text
            );
        }
        private void buttonPagoNoSocioAceptar_Click(object sender, EventArgs e)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                int idCliente = Convert.ToInt32(textBoxIdClienteNoSocio.Text);
                decimal monto = decimal.Parse(textBoxMontoPagoNoSocio.Text);
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

        private void buttonPagoNoSocioCancelar_Click(object sender, EventArgs e)
        {
            new FormHome(nombreUsuario).Show();
            this.Close();
        }
    } 
}
    
