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
using ClubDeportivo.Helpers;

namespace ClubDeportivo
{
    public partial class ModalReciboNoSocio : Form
    {
        public ModalReciboNoSocio()
        {
            InitializeComponent();
        }
        //datos pasados desde formPagoSocio
        public int? idCliente;
        public string? nombreApellido;
        public decimal? montoPago;
        public string? actividadAbonada;
        public string? horario;
        public string? modoPago = "Efectivo";
        public string usuarioActual;
        private void ModalReciboNoSocio_Load(object sender, EventArgs e)
        {
            labelIdPagoNoSocioDb.Text = Convert.ToString(idCliente);
            labelNombreYApellidoNoSocioDb.Text = nombreApellido;
            labelReciboNoSocioActividad.Text = actividadAbonada;
            labelReciboNoSocioHoraDb.Text = horario;
            labelReciboNoSocioMontoDb.Text = Convert.ToString(montoPago);
            labelReciboSocioModoPagoDb.Text = modoPago;
        }
        private void buttonReciboNoSocioImprimir_Click(object sender, EventArgs e)
        {
            var datos = new ReciboDatos
            {
                IdCliente = idCliente,
                NombreApellido = nombreApellido,
                MontoPago = montoPago,
                ActividadOCuota = actividadAbonada,
                Horario = horario,
                ModoPago = modoPago,
                EsSocio = false,
            };
            var impresion = new ImpresionReciboPago(datos, buttonReciboNoSocioImprimir, usuarioActual);

            impresion.Boton();
            this.Close();
        }

        private void buttonReciboNoSocioCancelar_Click(object sender, EventArgs e)
        {
            new FormHome(usuarioActual).Show();
            this.Close();
        }
    }
}
