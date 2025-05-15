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

       
    }
}
