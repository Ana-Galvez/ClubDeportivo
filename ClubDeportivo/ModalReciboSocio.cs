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
    public partial class ModalReciboSocio : Form
    {
        public ModalReciboSocio()
        {
            InitializeComponent();
        }
        //datos pasados desde formPagoSocio
        public int IdPagoSocioDb;
        public string? NombreYApellidoSocioDb;
        public string? ReciboSocioCuotaDb;
        public int ReciboSocioMontoDb;
        public string ReciboSocioModoPagoDb;
        public int? ReciboSocioNCuotasDb;
        public DateTime ReciboSocioFechaDb;
      

        private void ModalReciboSocio_Load(object sender, EventArgs e)
        {
            labelIdPagoSocioDb.Text = IdPagoSocioDb.ToString();
            labelNombreYApellidoSocioDb.Text= NombreYApellidoSocioDb;
            labelReciboSocioCuotaDb.Text= ReciboSocioCuotaDb;
            labelReciboSocioMontoDb.Text = ReciboSocioMontoDb.ToString();
            labelReciboSocioModoPagoDb.Text = ReciboSocioModoPagoDb;
            labelReciboSocioNCuotasDb.Text= ReciboSocioNCuotasDb.ToString();
            labelReciboSocioFechaDb.Text= ReciboSocioFechaDb.ToString();
           
        }
    }
}
