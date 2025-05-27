using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
            this.Load += new EventHandler(FormPagoNoSocio_Load);
        }

        // Clase para representar una actividad con nombre, monto y horarios
        public class Actividad
        {
            public string Nombre { get; set; }
            public decimal Monto { get; set; }
            public List<string> Horarios { get; set; }

            public override string ToString()
            {
                return Nombre;
            }
        }

        // Lista de actividades disponibles
        private List<Actividad> actividades = new List<Actividad>
        {
            new Actividad
            {
                Nombre = "Natación",
                Monto = 20000,
                Horarios = new List<string> { "Lunes y Jueves 11hs" }
            },
            new Actividad
            {
                Nombre = "Pilates",
                Monto = 10000,
                Horarios = new List<string> { "Lunes y Miércoles 18hs" }
            },
            new Actividad
            {
                Nombre = "Yoga",
                Monto = 10000,
                Horarios = new List<string> { "Lunes y Miércoles 16hs" }
            },
            new Actividad
            {
                Nombre = "Tenis",
                Monto = 15000,
                Horarios = new List<string> { "Miércoles y Viernes 20hs" }
            },
            new Actividad
            {
                Nombre = "Musculación",
                Monto = 15000,
                Horarios = new List<string> { "Martes y Jueves 19hs" }
            },
            new Actividad
            {
                Nombre = "Aerobic",
                Monto = 12000,
                Horarios = new List<string> { "Martes y Jueves 12hs" }
            },
            new Actividad
            {
                Nombre = "Danza",
                Monto = 15000,
                Horarios = new List<string> { "Lunes, Miércoles y Viernes 19hs", "Lunes, Miércoles y Viernes 11hs" }
            }
        };

        // Evento Load del formulario
        private void FormPagoNoSocio_Load(object sender, EventArgs e)
        {
            comboBoxSeleccionarActividad.Items.Clear();

            foreach (var actividad in actividades)
            {
                comboBoxSeleccionarActividad.Items.Add(actividad);
            }

            textBoxMonto.ReadOnly = true;

            // Configurar textBoxHorarios para mostrar multilinea y solo lectura
            textBoxHorarios.ReadOnly = true;
            textBoxHorarios.Multiline = true;
            textBoxHorarios.ScrollBars = ScrollBars.Vertical;
        }

        private void comboBoxSeleccionarActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            var actividadSeleccionada = comboBoxSeleccionarActividad.SelectedItem as Actividad;

            if (actividadSeleccionada != null)
            {
                textBoxMonto.Text = actividadSeleccionada.Monto.ToString("C"); // Formato moneda

                // Mostrar los horarios en el textBox separados por coma y espacio
                textBoxHorarios.Text = string.Join(", ", actividadSeleccionada.Horarios);

                // Se eliminó el MessageBox para mostrar horarios
            }
        }

        // Métodos vacíos (si no los usás, podés eliminarlos)
        private void labelPagoNoSocioTitulo_Click(object sender, EventArgs e) { }
        private void labelIdClienteNoSocio_Click(object sender, EventArgs e) { }
        private void textBoxIdClienteNoSocio_TextChanged(object sender, EventArgs e) { }
        private void labelSeleccionarActividad_Click(object sender, EventArgs e) { }
        private void textBoxMonto_TextChanged(object sender, EventArgs e) { }
        private void labelHorarios_Click(object sender, EventArgs e) { }
        private void textBoxHorarios_TextChanged(object sender, EventArgs e) { }

        private void panelPagoNoSocioHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelInicioHeader_Click(object sender, EventArgs e)
        {

        }

        private void labelMonto_Click(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Código que querés ejecutar cuando cambia el texto
        }

        private void FormPagoNoSocio_Load_1(object sender, EventArgs e)
        {
            // Código al cargar el formulario
        }

        private void labelFormaPago_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBoxFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
