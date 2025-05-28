using ClubDeportivo.Datos;
using ClubDeportivo.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace ClubDeportivo
{
    public partial class FormPagoNoSocio : Form
    {
        private string nombreUsuario;

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

        private void panelPagoNoSocioHeader_Paint(object sender, PaintEventArgs e)
        {

        }
        private void buttonPagoNoSocioAceptar_Click(object sender, EventArgs e)
        {

        }

        private void buttonPagoNoSocioCancelar_Click(object sender, EventArgs e)
        {
            new FormHome(nombreUsuario).Show();
            this.Close();
        }
    } 
}
    
