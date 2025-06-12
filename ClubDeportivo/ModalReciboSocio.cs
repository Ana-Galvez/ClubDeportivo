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
using ClubDeportivo.Helpers;

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
        public string usuarioActual;


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
            var datos = new ReciboDatos
            {
                IdCliente = idCliente,
                NombreApellido = nombreApellido,
                MontoPago = montoPago,
                ActividadOCuota = cuotaAbonada,
                NumeroCuotas = numCuotas,
                ModoPago = modoPago,
                EsSocio = true
            };
            var impresion = new ImpresionReciboPago(datos, buttonReciboSocioImprimir, usuarioActual);

            impresion.Boton();
            this.Close();
        }

        private void buttonReciboSocioCancelar_Click(object sender, EventArgs e)
        {
            new FormHome(usuarioActual).Show();
            this.Close();
        }
    }
}
