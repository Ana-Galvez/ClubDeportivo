using ClubDeportivo.Datos;
using ClubDeportivo.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo
{
    public partial class FormVencimiento : Form
    {
        private string nombreUsuario;
        private DateTime fechaInicial;

        //Constructor
        public FormVencimiento(string usuario)
        {
            InitializeComponent();
            nombreUsuario = usuario;

        }
        //Carga del formulario
        private void FormVencimiento_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        //Fc encargada de cargar la grilla con los datos de las cuotas que vencen hoy
        private void CargarGrilla()
        {

            try
            {
                var lista = CuotaSocio.ObtenerCuotasVencidasHoy();//obtengo los datos de las cuotas y sus socios
                dgvCuotas.Rows.Clear();

                if (lista.Count == 0)
                {   //si no hay datos muestro alerta
                    MessageBox.Show("No hay socios con cuotas vencidas hoy.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //recorro la lista que contiene los datos, creo filas en la grilla y cargo los datos
                foreach (var item in lista)
                {
                    int fila = dgvCuotas.Rows.Add();
                    dgvCuotas.Rows[fila].Cells["colIDCliente"].Value = item.IDCliente;
                    dgvCuotas.Rows[fila].Cells["colNombre"].Value = item.Nombre;
                    dgvCuotas.Rows[fila].Cells["colApellido"].Value = item.Apellido;
                    dgvCuotas.Rows[fila].Cells["colDNI"].Value = item.DNI;
                    dgvCuotas.Rows[fila].Cells["colTelefono"].Value = item.Telefono;
                    dgvCuotas.Rows[fila].Cells["colMonto"].Value = item.Monto.ToString("C2");
                    dgvCuotas.Rows[fila].Cells["colFechaVenc"].Value = item.FechaVencimiento.ToShortDateString();
                }
                //mejoro estilo de la grilla
                dgvCuotas.DefaultCellStyle.BackColor = Color.White;
                dgvCuotas.DefaultCellStyle.ForeColor = Color.Black;
                dgvCuotas.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 70, 160); // azul 
                dgvCuotas.DefaultCellStyle.SelectionForeColor = Color.White;
                dgvCuotas.DefaultCellStyle.Font = new Font("Segoe UI", 9);
                dgvCuotas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 70, 160);
                dgvCuotas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvCuotas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                dgvCuotas.ColumnHeadersHeight = 35;
                dgvCuotas.BorderStyle = BorderStyle.None;
                dgvCuotas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dgvCuotas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
                dgvCuotas.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la grilla: " + ex.Message);
            }
        }

        //boton cancelar
        private void buttonVencimientosCancelar_Click(object sender, EventArgs e)
        {
            FormHome nuevoFormulario = new FormHome(nombreUsuario);
            nuevoFormulario.Show();
            this.Hide();

        }
    }
}

