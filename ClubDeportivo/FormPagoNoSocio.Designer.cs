namespace ClubDeportivo
{
    partial class FormPagoNoSocio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelPagoNoSocioHeader = new Panel();
            labelInicioHeader = new Label();
            labelPagoNoSocioTitulo = new Label();
            labelIdClienteNoSocio = new Label();
            textBoxIdClienteNoSocio = new TextBox();
            labelSeleccionarActividad = new Label();
            comboBoxSeleccionarActividad = new ComboBox();
            labelMonto = new Label();
            labelHorarios = new Label();
            buttonPagoNoSocioCancelar = new Button();
            buttonPagoNoSocioAceptar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            labelMoneda = new Label();
            textBoxMontoPagoNoSocio = new TextBox();
            textBoxHoraActividad = new TextBox();
            panelPagoNoSocioHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelPagoNoSocioHeader
            // 
            panelPagoNoSocioHeader.BackColor = Color.FromArgb(0, 70, 160);
            panelPagoNoSocioHeader.Controls.Add(labelInicioHeader);
            panelPagoNoSocioHeader.Location = new Point(0, 1);
            panelPagoNoSocioHeader.Name = "panelPagoNoSocioHeader";
            panelPagoNoSocioHeader.Size = new Size(801, 48);
            panelPagoNoSocioHeader.TabIndex = 39;
            panelPagoNoSocioHeader.Paint += panelPagoNoSocioHeader_Paint;
            // 
            // labelInicioHeader
            // 
            labelInicioHeader.AutoSize = true;
            labelInicioHeader.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInicioHeader.ForeColor = Color.White;
            labelInicioHeader.Location = new Point(0, 11);
            labelInicioHeader.Name = "labelInicioHeader";
            labelInicioHeader.Padding = new Padding(10, 0, 0, 0);
            labelInicioHeader.Size = new Size(181, 25);
            labelInicioHeader.TabIndex = 0;
            labelInicioHeader.Text = "CLUB DEPORTIVO";
            labelInicioHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelPagoNoSocioTitulo
            // 
            labelPagoNoSocioTitulo.AutoSize = true;
            labelPagoNoSocioTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPagoNoSocioTitulo.ForeColor = Color.Black;
            labelPagoNoSocioTitulo.Location = new Point(275, 79);
            labelPagoNoSocioTitulo.Name = "labelPagoNoSocioTitulo";
            labelPagoNoSocioTitulo.Size = new Size(210, 25);
            labelPagoNoSocioTitulo.TabIndex = 46;
            labelPagoNoSocioTitulo.Text = "Registrar pago no socio";
            // 
            // labelIdClienteNoSocio
            // 
            labelIdClienteNoSocio.AutoSize = true;
            labelIdClienteNoSocio.Location = new Point(259, 152);
            labelIdClienteNoSocio.Name = "labelIdClienteNoSocio";
            labelIdClienteNoSocio.Size = new Size(63, 17);
            labelIdClienteNoSocio.TabIndex = 47;
            labelIdClienteNoSocio.Text = "ID Cliente";
            // 
            // textBoxIdClienteNoSocio
            // 
            textBoxIdClienteNoSocio.Location = new Point(425, 144);
            textBoxIdClienteNoSocio.Name = "textBoxIdClienteNoSocio";
            textBoxIdClienteNoSocio.Size = new Size(161, 25);
            textBoxIdClienteNoSocio.TabIndex = 48;
            // 
            // labelSeleccionarActividad
            // 
            labelSeleccionarActividad.AutoSize = true;
            labelSeleccionarActividad.Location = new Point(259, 209);
            labelSeleccionarActividad.Name = "labelSeleccionarActividad";
            labelSeleccionarActividad.Size = new Size(131, 17);
            labelSeleccionarActividad.TabIndex = 49;
            labelSeleccionarActividad.Text = "Seleccionar Actividad";
            // 
            // comboBoxSeleccionarActividad
            // 
            comboBoxSeleccionarActividad.FormattingEnabled = true;
            comboBoxSeleccionarActividad.Items.AddRange(new object[] { "Natación: Lunes 11hs", "Natación: Jueves 15hs", "Pilates: Lunes y Miércoles 18hs", "Tenis: Miércoles y Viernes 20hs", "Musculación: Martes y Jueves 19hs", "Yoga:  Lunes y Miércoles 16hs", "Aerobic: Martes y Jueves 12hs", "Danza: Lunes, Miércoles y Viernes 19hs", "Danza: Lunes, Miércoles y Viernes 11hs" });
            comboBoxSeleccionarActividad.Location = new Point(426, 200);
            comboBoxSeleccionarActividad.Name = "comboBoxSeleccionarActividad";
            comboBoxSeleccionarActividad.Size = new Size(160, 25);
            comboBoxSeleccionarActividad.TabIndex = 50;
            comboBoxSeleccionarActividad.SelectedIndexChanged += comboBoxSeleccionarActividad_SelectedIndexChanged;
            // 
            // labelMonto
            // 
            labelMonto.AutoSize = true;
            labelMonto.Location = new Point(259, 318);
            labelMonto.Name = "labelMonto";
            labelMonto.Size = new Size(47, 17);
            labelMonto.TabIndex = 51;
            labelMonto.Text = "Monto";
            // 
            // labelHorarios
            // 
            labelHorarios.AutoSize = true;
            labelHorarios.Location = new Point(258, 265);
            labelHorarios.Name = "labelHorarios";
            labelHorarios.Size = new Size(59, 17);
            labelHorarios.TabIndex = 53;
            labelHorarios.Text = "Horarios";
            // 
            // buttonPagoNoSocioCancelar
            // 
            buttonPagoNoSocioCancelar.BackColor = Color.FromArgb(128, 0, 70, 160);
            buttonPagoNoSocioCancelar.FlatStyle = FlatStyle.Flat;
            buttonPagoNoSocioCancelar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonPagoNoSocioCancelar.ForeColor = Color.White;
            buttonPagoNoSocioCancelar.Location = new Point(413, 402);
            buttonPagoNoSocioCancelar.Name = "buttonPagoNoSocioCancelar";
            buttonPagoNoSocioCancelar.Size = new Size(200, 32);
            buttonPagoNoSocioCancelar.TabIndex = 59;
            buttonPagoNoSocioCancelar.Text = "Cancelar";
            buttonPagoNoSocioCancelar.UseVisualStyleBackColor = false;
            buttonPagoNoSocioCancelar.Click += buttonPagoNoSocioCancelar_Click;
            // 
            // buttonPagoNoSocioAceptar
            // 
            buttonPagoNoSocioAceptar.BackColor = Color.FromArgb(0, 70, 160);
            buttonPagoNoSocioAceptar.FlatStyle = FlatStyle.Flat;
            buttonPagoNoSocioAceptar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPagoNoSocioAceptar.ForeColor = Color.White;
            buttonPagoNoSocioAceptar.Location = new Point(189, 402);
            buttonPagoNoSocioAceptar.Name = "buttonPagoNoSocioAceptar";
            buttonPagoNoSocioAceptar.Size = new Size(200, 32);
            buttonPagoNoSocioAceptar.TabIndex = 58;
            buttonPagoNoSocioAceptar.Text = "Aceptar";
            buttonPagoNoSocioAceptar.UseVisualStyleBackColor = false;
            buttonPagoNoSocioAceptar.Click += buttonPagoNoSocioAceptar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(592, 147);
            label1.Name = "label1";
            label1.Size = new Size(17, 21);
            label1.TabIndex = 62;
            label1.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(592, 204);
            label2.Name = "label2";
            label2.Size = new Size(17, 21);
            label2.TabIndex = 63;
            label2.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(592, 313);
            label3.Name = "label3";
            label3.Size = new Size(17, 21);
            label3.TabIndex = 64;
            label3.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(591, 261);
            label4.Name = "label4";
            label4.Size = new Size(17, 21);
            label4.TabIndex = 65;
            label4.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8.25F);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(345, 372);
            label6.Name = "label6";
            label6.Size = new Size(124, 13);
            label6.TabIndex = 67;
            label6.Text = "* Campos Obligatorios";
            // 
            // labelMoneda
            // 
            labelMoneda.AutoSize = true;
            labelMoneda.Location = new Point(405, 318);
            labelMoneda.Name = "labelMoneda";
            labelMoneda.Size = new Size(15, 17);
            labelMoneda.TabIndex = 70;
            labelMoneda.Text = "$";
            // 
            // textBoxMontoPagoNoSocio
            // 
            textBoxMontoPagoNoSocio.BackColor = Color.White;
            textBoxMontoPagoNoSocio.Location = new Point(426, 313);
            textBoxMontoPagoNoSocio.Name = "textBoxMontoPagoNoSocio";
            textBoxMontoPagoNoSocio.ReadOnly = true;
            textBoxMontoPagoNoSocio.Size = new Size(161, 25);
            textBoxMontoPagoNoSocio.TabIndex = 69;
            // 
            // textBoxHoraActividad
            // 
            textBoxHoraActividad.BackColor = Color.White;
            textBoxHoraActividad.Location = new Point(426, 261);
            textBoxHoraActividad.Name = "textBoxHoraActividad";
            textBoxHoraActividad.ReadOnly = true;
            textBoxHoraActividad.Size = new Size(161, 25);
            textBoxHoraActividad.TabIndex = 71;
            // 
            // FormPagoNoSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxHoraActividad);
            Controls.Add(labelMoneda);
            Controls.Add(textBoxMontoPagoNoSocio);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonPagoNoSocioCancelar);
            Controls.Add(buttonPagoNoSocioAceptar);
            Controls.Add(labelHorarios);
            Controls.Add(labelMonto);
            Controls.Add(comboBoxSeleccionarActividad);
            Controls.Add(labelSeleccionarActividad);
            Controls.Add(textBoxIdClienteNoSocio);
            Controls.Add(labelIdClienteNoSocio);
            Controls.Add(labelPagoNoSocioTitulo);
            Controls.Add(panelPagoNoSocioHeader);
            Name = "FormPagoNoSocio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CLUB DEPORTIVO";
            Load += FormPagoNoSocio_Load;
            panelPagoNoSocioHeader.ResumeLayout(false);
            panelPagoNoSocioHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelPagoNoSocioHeader;
        private Label labelInicioHeader;
        private Label labelPagoNoSocioTitulo;
        private Label labelIdClienteNoSocio;
        private TextBox textBoxIdClienteNoSocio;
        private Label labelSeleccionarActividad;
        private ComboBox comboBoxSeleccionarActividad;
        private Label labelMonto;
        private Label labelHorarios;
        private Button buttonPagoNoSocioCancelar;
        private Button buttonPagoNoSocioAceptar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label labelMoneda;
        private TextBox textBoxMontoPagoNoSocio;
        private TextBox textBoxHoraActividad;
    }
}