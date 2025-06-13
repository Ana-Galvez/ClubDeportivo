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
        public FormVencimiento(string usuario)
        {
            InitializeComponent();
            nombreUsuario = usuario;

        }
        //al cargar el formulario sale un recordatorio del apto fisico
        private void FormVencimiento_Load(object sender, EventArgs e)
        {
            CargarGrilla();

        }

        //CANCELAR 
        private void buttonRegistroClienteCancelar_Click(object sender, EventArgs e)
        {
            FormHome nuevoFormulario = new FormHome(nombreUsuario);
            nuevoFormulario.Show();
            this.Hide();
        }

        private void CargarGrilla()
        {

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                string query = @"
                    SELECT c.IDCliente, cli.Nombre, cli.Apellido,cli.DNI, cli.Telefono, c.Monto, c.FechaVencimiento
                    FROM cuotas c
                    INNER JOIN cliente cli ON cli.IDCliente = c.IDCliente
                    WHERE c.Estado = 'Pendiente' AND c.FechaVencimiento = CURDATE();";

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                MySqlDataReader reader = comando.ExecuteReader();
                dgvCuotas.Rows.Clear();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int fila = dgvCuotas.Rows.Add();
                        dgvCuotas.Rows[fila].Cells["colIDCliente"].Value = reader.GetInt32(0);
                        dgvCuotas.Rows[fila].Cells["colNombre"].Value = reader.GetString(1);
                        dgvCuotas.Rows[fila].Cells["colApellido"].Value = reader.GetString(2);
                        dgvCuotas.Rows[fila].Cells["colDNI"].Value = reader.GetInt32(3);
                        dgvCuotas.Rows[fila].Cells["colTelefono"].Value = reader.GetString(4);
                        dgvCuotas.Rows[fila].Cells["colMonto"].Value = reader.GetDecimal(5).ToString("C2");
                        dgvCuotas.Rows[fila].Cells["colFechaVenc"].Value = reader.GetDateTime(6).ToShortDateString();
                    }

                    // Estilo 
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
                else
                {
                    MessageBox.Show("No hay socios con cuotas vencidas hoy.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la grilla: " + ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
        }

        private void buttonImprimirListado_Click(object sender, EventArgs e)
        {

        }

        private void labelTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}

