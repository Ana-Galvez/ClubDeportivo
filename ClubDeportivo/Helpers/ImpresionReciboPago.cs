using System.Drawing.Printing;

namespace ClubDeportivo.Helpers
{
    public class ReciboDatos
    {   public int? IdCliente { get; set; }
        public string NombreApellido { get; set; }
        public decimal? MontoPago { get; set; }
        public string ActividadOCuota { get; set; }
        public string Horario { get; set; } // solo para No Socio
        public string ModoPago { get; set; }
        public int? NumeroCuotas { get; set; } // solo para Socio
        public bool EsSocio { get; set; }
    }
    class ImpresionReciboPago : ReciboDatos
    {
        private ReciboDatos datos;
        private string usuarioActual;
        private Button botonImprimir;

        public ImpresionReciboPago(ReciboDatos datos, Button botonImprimir, string usuarioActual)
        {
            this.datos = datos;
            this.botonImprimir = botonImprimir;
            this.usuarioActual = usuarioActual;
        }

        public void Boton()
        {
            botonImprimir.Visible = false;

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";
            saveDialog.Title = "Guardar comprobante como PDF";
            saveDialog.FileName = datos.EsSocio ? "Comprobante de Pago Socio" : "Comprobante de Pago No Socio";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler(ImprimirRecibo);
                pd.PrinterSettings.PrinterName = "Microsoft Print to PDF";
                pd.PrinterSettings.PrintToFile = true;
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

            botonImprimir.Visible = true;
            new FormHome(usuarioActual).Show();
        }

        private void ImprimirRecibo(object sender, PrintPageEventArgs e)
        {
            Font fontTitulo = new Font("Roboto", 14, FontStyle.Bold);
            Font font = new Font("Roboto", 12);
            Font fontPequeña = new Font("Roboto", 10);
            Font fontMini = new Font("Roboto", 9);
            Brush brush = Brushes.Black;

            float posY = 20;
            float pageWidth = e.PageBounds.Width;
            float espacioEntreLineas = 25;

            string titulo = "Club Deportivo";
            SizeF sizeTitulo = e.Graphics.MeasureString(titulo, fontTitulo);
            e.Graphics.DrawString(titulo, fontTitulo, brush, (pageWidth - sizeTitulo.Width) / 2, posY);
            posY += espacioEntreLineas;

            string fechaTexto = $"Fecha de Impresión: {DateTime.Now.ToShortDateString()}";
            string horaTexto = $"Hora de Impresión: {DateTime.Now.ToShortTimeString()}";
            e.Graphics.DrawString(fechaTexto, fontPequeña, brush, pageWidth - 300, posY); posY += espacioEntreLineas - 10;
            e.Graphics.DrawString(horaTexto, fontPequeña, brush, pageWidth - 300, posY); posY += espacioEntreLineas;

            e.Graphics.DrawString("---------------------------------------------", fontPequeña, brush, 200, posY); posY += espacioEntreLineas;

            e.Graphics.DrawString(datos.EsSocio ? "Factura de Socio" : "Factura de No Socio", fontTitulo, brush, 200, posY);
            posY += espacioEntreLineas * 2;

            e.Graphics.DrawString(datos.EsSocio ? $"ID de cliente: {datos.IdCliente}" : $"ID de cliente: {datos.IdCliente}", font, brush, 200, posY); posY += espacioEntreLineas;
            e.Graphics.DrawString($"Nombre y Apellido: {datos.NombreApellido}", font, brush, 200, posY); posY += espacioEntreLineas;

            if (datos.EsSocio)
            {
                e.Graphics.DrawString($"Cuota Abonada: {datos.ActividadOCuota}", font, brush, 200, posY); posY += espacioEntreLineas;
                e.Graphics.DrawString($"Número de Cuotas: {datos.NumeroCuotas ?? 1}", font, brush, 200, posY); posY += espacioEntreLineas;
            }
            else
            {
                e.Graphics.DrawString($"Actividad Abonada: {datos.ActividadOCuota}", font, brush, 200, posY); posY += espacioEntreLineas;
                e.Graphics.DrawString($"Horario: {datos.Horario}", font, brush, 200, posY); posY += espacioEntreLineas;
            }

            e.Graphics.DrawString($"Monto: {datos.MontoPago}", font, brush, 200, posY); posY += espacioEntreLineas;
            e.Graphics.DrawString($"Modo de Pago: {datos.ModoPago}", font, brush, 200, posY); posY += espacioEntreLineas;
            e.Graphics.DrawString($"Fecha de Pago: {DateTime.Now.ToShortDateString()}", font, brush, 200, posY); posY += espacioEntreLineas;

            e.Graphics.DrawString("---------------------------------------------", fontPequeña, brush, 200, posY); posY += espacioEntreLineas;

            string nota1 = datos.EsSocio
                ? "Este comprobante refleja el pago del socio en el sistema."
                : "Este comprobante refleja el pago del no socio en el sistema.";
            string nota2 = "Este comprobante no es válido como factura fiscal.";

            SizeF sizeNota1 = e.Graphics.MeasureString(nota1, fontMini);
            SizeF sizeNota2 = e.Graphics.MeasureString(nota2, fontMini);

            e.Graphics.DrawString(nota1, fontMini, brush, (pageWidth - sizeNota1.Width) / 2, posY); posY += espacioEntreLineas - 10;
            e.Graphics.DrawString(nota2, fontMini, brush, (pageWidth - sizeNota2.Width) / 2, posY);
        }
    }
}
