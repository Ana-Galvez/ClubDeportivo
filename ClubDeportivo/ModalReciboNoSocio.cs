using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        private void buttonReciboSocioImprimir_Click(object sender, EventArgs e)
        {

        }
    }
}
