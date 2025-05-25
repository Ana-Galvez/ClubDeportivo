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
    public partial class ModalReciboSocio : Form
    {
        public ModalReciboSocio()
        {
            InitializeComponent();
            this.Text = "Club Deportivo";
        }
        //datos pasados desde formPagoSocio
        public int? idCliente;
        public string? nombreApellido;
        public decimal? montoPago;
        public string? cuotaAbonada;
        public string? modoPago;
        public int? numCuotas;
        public string? numTarjeta;
        public string? numVerificacion;


        private void ModalReciboSocio_Load(object sender, EventArgs e)
        {
            labelIdPagoSocioDb.Text = Convert.ToString(idCliente);
            labelNombreYApellidoSocioDb.Text = nombreApellido;
            labelReciboSocioCuotaDb.Text = cuotaAbonada;
            labelReciboSocioMontoDb.Text = Convert.ToString(montoPago);
            labelReciboSocioModoPagoDb.Text = modoPago;
            labelReciboSocioNCuotasDb.Text = numCuotas.HasValue ? numCuotas.Value.ToString() : "No aplica";
            labelReciboSocioFechaDb.Text = DateTime.UtcNow.ToShortDateString();

        }

        private void buttonReciboSocioImprimir_Click(object sender, EventArgs e)
        {
            buttonReciboSocioImprimir.Visible = false;

            // Mostrar cuadro de diálogo para elegir nombre y ruta del PDF
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";
            saveDialog.Title = "Guardar comprobante como PDF";
            saveDialog.FileName = "Comprobante de Pago Socio";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler(ImprimirRecibo);
                pd.PrinterSettings.PrinterName = "Microsoft Print to PDF"; // Cambia esto al nombre de tu impresora si es necesario
                pd.PrinterSettings.PrintToFile = true; // Configura la orientación del papel
                pd.PrinterSettings.PrintFileName = saveDialog.FileName;
                pd.DefaultPageSettings.Landscape = true;

                try
                {
                    pd.Print();
                    MessageBox.Show("Impresión exitosa", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al imprimir: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            buttonReciboSocioImprimir.Visible = true;

            this.Close();
        }

        private void ImprimirRecibo(object sender, PrintPageEventArgs e)
        {
            // Fuentes
            Font fontTitulo = new Font("Roboto", 14, FontStyle.Bold);
            Font font = new Font("Roboto", 12);
            Font fontPequeña = new Font("Roboto", 10);
            Font fontMini = new Font("Roboto", 9);
            Brush brush = Brushes.Black;

            // Márgenes y espaciado
            float posY = 20;
            float pageWidth = e.PageBounds.Width;
            float espacioEntreLineas = 25;

            // Título centrado
            string titulo = "Club Deportivo";
            SizeF sizeTitulo = e.Graphics.MeasureString(titulo, fontTitulo);
            e.Graphics.DrawString(titulo, fontTitulo, brush, (pageWidth - sizeTitulo.Width) / 2, posY);
            posY += espacioEntreLineas;

            // Fecha y hora actual
            string fechaTexto = $"Fecha de Impresión: {DateTime.Now.ToShortDateString()}";
            string horaTexto = $"Hora de Impresión: {DateTime.Now.ToShortTimeString()}";
            SizeF sizeFecha = e.Graphics.MeasureString(fechaTexto, fontPequeña);
            SizeF sizeHora = e.Graphics.MeasureString(horaTexto, fontPequeña);
            e.Graphics.DrawString(fechaTexto, fontPequeña, brush, pageWidth - sizeFecha.Width - 20, posY);
            posY += espacioEntreLineas - 10;
            e.Graphics.DrawString(horaTexto, fontPequeña, brush, pageWidth - sizeHora.Width - 20, posY);
            posY += espacioEntreLineas;

            // Línea divisoria
            e.Graphics.DrawString("---------------------------------------------", fontPequeña, brush, 200, posY);
            posY += espacioEntreLineas;

            // Factura título
            e.Graphics.DrawString("Factura de Socio", fontTitulo, brush, 200, posY);
            posY += espacioEntreLineas * 2;

            // Contenido principal
            e.Graphics.DrawString($"Número de Socio: {idCliente}", font, brush, 200, posY); posY += espacioEntreLineas;
            e.Graphics.DrawString($"Nombre y Apellido: {nombreApellido}", font, brush, 200, posY); posY += espacioEntreLineas;
            e.Graphics.DrawString($"Cuota abonada: {cuotaAbonada}", font, brush, 200, posY); posY += espacioEntreLineas;
            e.Graphics.DrawString($"Monto: {montoPago}", font, brush, 200, posY); posY += espacioEntreLineas;
            e.Graphics.DrawString($"Modo de Pago: {modoPago}", font, brush, 200, posY); posY += espacioEntreLineas;
            e.Graphics.DrawString($"Número de Cuotas: {numCuotas}", font, brush, 200, posY); posY += espacioEntreLineas;
            e.Graphics.DrawString($"Fecha de pago: {DateTime.UtcNow.ToShortDateString()}", font, brush, 200, posY); posY += espacioEntreLineas;

            //e.Graphics.DrawString($"Próximo Vencimiento: {ReciboSocioFechaDb.ToShortDateString()}", font, brush, 200, posY); posY += espacioEntreLineas;

            // Línea divisoria
            e.Graphics.DrawString("---------------------------------------------", fontPequeña, brush, 200, posY);
            posY += espacioEntreLineas;

            // Avisos generales
            string nota1 = "Este comprobante refleja el pago del socio en el sistema.";
            SizeF sizeNota1 = e.Graphics.MeasureString(nota1, fontMini);
            e.Graphics.DrawString(nota1, fontMini, brush, (pageWidth - sizeNota1.Width) / 2, posY);
            posY += espacioEntreLineas - 10;

            string nota2 = "Este comprobante no es válido como factura fiscal";
            SizeF sizeNota2 = e.Graphics.MeasureString(nota2, fontMini);
            e.Graphics.DrawString(nota2, fontMini, brush, (pageWidth - sizeNota2.Width) / 2, posY);

        }
    }
}
