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
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            pd.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            pd.DefaultPageSettings.Landscape = true;
            pd.Print();

            MessageBox.Show("Impresión exitosa", "AVISO DEL SISTEMA",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            buttonCarnetVolver.Visible = true;
            buttonImprimirCarnet.Visible = true;
            FormHome principal = new FormHome(usuario);
            principal.Show();
            this.Close();
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
