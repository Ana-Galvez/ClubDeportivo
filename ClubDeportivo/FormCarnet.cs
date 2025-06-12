using ClubDeportivo.Datos;
using ClubDeportivo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using ClubDeportivo;


namespace ClubDeportivo
{
    public partial class FormCarnet : Form
    {
        private string usuario;
        public FormCarnet(Entidades.E_Cliente cliente, string nombreUsuario)
        {
            InitializeComponent();
            this.usuario = nombreUsuario;

            labelID.Text = cliente.IDCliente.ToString();
            labelNombre.Text = cliente.Nombre;
            labelApellido.Text = cliente.Apellido;
            labelSocio.Text = cliente.Socio ? "Sí" : "No";
            labelAptoFisico.Text = cliente.AptoFisico ? "Sí" : "No";
            labelTelefono.Text = cliente.Telefono;
            labelGenero.Text = cliente.Genero;
            labelDireccion.Text = cliente.Direccion;
            labelDNI.Text = cliente.DNI.ToString();
            labelFechaNacimiento.Text = cliente.FechaNacimiento.ToShortDateString();
            labelFechaInscripcion.Text = cliente.FechaInscripcion.ToShortDateString();
        }

        private void buttonCarnetVolver_Click(object sender, EventArgs e)
        {
            FormHome nuevoFormulario = new FormHome(usuario);
            nuevoFormulario.Show();
            this.Hide();
        }

        private void buttonImprimirCarnet_Click(object sender, EventArgs e)
        {
            buttonCarnetVolver.Visible = false;
            buttonImprimirCarnet.Visible = false;
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";
            saveDialog.Title = "Guardar carnet como PDF";
            saveDialog.FileName = "Carnet de Miembro.pdf";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
                pd.PrinterSettings.PrinterName = "Microsoft Print to PDF";
                pd.PrinterSettings.PrintToFile = true;
                pd.PrinterSettings.PrintFileName = saveDialog.FileName;
                pd.DefaultPageSettings.Landscape = true;

                try
                {
                    pd.Print();
                    MessageBox.Show("Carnet guardado exitosamente.", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar: " + ex.Message, "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            buttonCarnetVolver.Visible = true;
            buttonImprimirCarnet.Visible = true;
        }
            

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int ancho = this.Width;
            int alto = this.Height;
            Rectangle bounds = new Rectangle(x, y, ancho, alto);
            Bitmap img = new Bitmap(ancho, alto);
            this.DrawToBitmap(img, bounds);
            Point p = new Point(175, 200);
            e.Graphics.DrawImage(img, p);
        }
    }
}
