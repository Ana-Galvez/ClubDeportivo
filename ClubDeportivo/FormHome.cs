﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClubDeportivo.Helpers;

namespace ClubDeportivo
{
    public partial class FormHome : Form
    {
        private string nombreUsuario;
        public FormHome(string usuario)
        {
            InitializeComponent();
            nombreUsuario = usuario;
            labelBienvenida.Text = $"¡Bienvenido/a, {nombreUsuario}!";

           
        }

        private void labelBienvenida_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegistrarCliente_Click(object sender, EventArgs e)
        {
            FormRegistroCliente nuevoFormulario = new FormRegistroCliente(nombreUsuario);
            nuevoFormulario.Show();
            this.Hide();
        }

        private void buttonRegistrarPago_Click(object sender, EventArgs e)
        {
            using (var modal = new ModalPagoSocioONoSocio())
            {
                if (modal.ShowDialog() == DialogResult.OK)
                {
                    if (modal.EsSocioModal)
                    {
                        // Abrir formulario para socios
                        new FormPagoSocio(nombreUsuario).Show();
                        this.Close();
                    } else
                    {
                        new FormPagoNoSocio(nombreUsuario).Show();
                            this.Close();
                    }
                    
                }
            }
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;

        }

        private void buttonListadoSociosMorosos_Click_1(object sender, EventArgs e)
        {
            FormVencimiento nuevoListado = new FormVencimiento(nombreUsuario);
            nuevoListado.Show();
            this.Hide();

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro que deseas cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.Hide();
                // Abre nuevamente el formulario de inicio de sesión
                FormIniciarSesion login = new FormIniciarSesion();
                login.Show();

            }
        }
    }
}
