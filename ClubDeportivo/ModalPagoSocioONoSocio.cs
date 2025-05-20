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
    public partial class ModalPagoSocioONoSocio : Form
    {
        //Para guardar el resultado del modal y usarlo después
        public bool EsSocioModal { get; private set; }
        public ModalPagoSocioONoSocio()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void ModalPagoSocioONoSocio_Load(object sender, EventArgs e)
        {
           
        }
        //Me lleva al form correspondiente
        private void buttonModalPagoSi_Click(object sender, EventArgs e)
        {
            EsSocioModal = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonModalPagoNo_Click(object sender, EventArgs e)
        {
            EsSocioModal = false;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
