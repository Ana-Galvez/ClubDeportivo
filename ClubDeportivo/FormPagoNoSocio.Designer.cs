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
            textBoxMonto = new TextBox();
            labelHorarios = new Label();
            textBoxHorarios = new TextBox();
            buttonPagoNoSocioCancelar = new Button();
            buttonPagoNoSocioAceptar = new Button();
            labelFormaPago = new Label();
            comboBoxFormaPago = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panelPagoNoSocioHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelPagoNoSocioHeader
            // 
            panelPagoNoSocioHeader.BackColor = Color.FromArgb(0, 70, 160);
            panelPagoNoSocioHeader.Controls.Add(labelInicioHeader);
            panelPagoNoSocioHeader.Location = new Point(0, 1);
            panelPagoNoSocioHeader.Name = "panelPagoNoSocioHeader";
            panelPagoNoSocioHeader.Size = new Size(801, 42);
            panelPagoNoSocioHeader.TabIndex = 39;
            panelPagoNoSocioHeader.Paint += panelPagoNoSocioHeader_Paint;
            // 
            // labelInicioHeader
            // 
            labelInicioHeader.AutoSize = true;
            labelInicioHeader.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInicioHeader.ForeColor = Color.White;
            labelInicioHeader.Location = new Point(0, 10);
            labelInicioHeader.Name = "labelInicioHeader";
            labelInicioHeader.Padding = new Padding(10, 0, 0, 0);
            labelInicioHeader.Size = new Size(181, 25);
            labelInicioHeader.TabIndex = 0;
            labelInicioHeader.Text = "CLUB DEPORTIVO";
            labelInicioHeader.TextAlign = ContentAlignment.MiddleCenter;
            labelInicioHeader.Click += labelInicioHeader_Click;
            // 
            // labelPagoNoSocioTitulo
            // 
            labelPagoNoSocioTitulo.AutoSize = true;
            labelPagoNoSocioTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPagoNoSocioTitulo.ForeColor = Color.Black;
            labelPagoNoSocioTitulo.Location = new Point(291, 71);
            labelPagoNoSocioTitulo.Name = "labelPagoNoSocioTitulo";
            labelPagoNoSocioTitulo.Size = new Size(234, 25);
            labelPagoNoSocioTitulo.TabIndex = 46;
            labelPagoNoSocioTitulo.Text = "Registro de Pago No Socio";
            labelPagoNoSocioTitulo.Click += labelPagoNoSocioTitulo_Click;
            // 
            // labelIdClienteNoSocio
            // 
            labelIdClienteNoSocio.AutoSize = true;
            labelIdClienteNoSocio.Location = new Point(259, 134);
            labelIdClienteNoSocio.Name = "labelIdClienteNoSocio";
            labelIdClienteNoSocio.Size = new Size(58, 15);
            labelIdClienteNoSocio.TabIndex = 47;
            labelIdClienteNoSocio.Text = "ID Cliente";
            labelIdClienteNoSocio.Click += labelIdClienteNoSocio_Click;
            // 
            // textBoxIdClienteNoSocio
            // 
            textBoxIdClienteNoSocio.Location = new Point(394, 126);
            textBoxIdClienteNoSocio.Name = "textBoxIdClienteNoSocio";
            textBoxIdClienteNoSocio.Size = new Size(161, 23);
            textBoxIdClienteNoSocio.TabIndex = 48;
            textBoxIdClienteNoSocio.TextChanged += textBoxIdClienteNoSocio_TextChanged;
            // 
            // labelSeleccionarActividad
            // 
            labelSeleccionarActividad.AutoSize = true;
            labelSeleccionarActividad.Location = new Point(259, 184);
            labelSeleccionarActividad.Name = "labelSeleccionarActividad";
            labelSeleccionarActividad.Size = new Size(120, 15);
            labelSeleccionarActividad.TabIndex = 49;
            labelSeleccionarActividad.Text = "Seleccionar Actividad";
            labelSeleccionarActividad.Click += labelSeleccionarActividad_Click;
            // 
            // comboBoxSeleccionarActividad
            // 
            comboBoxSeleccionarActividad.FormattingEnabled = true;
            comboBoxSeleccionarActividad.Items.AddRange(new object[] { "Natación: Lunes 11hs", "Natación: Jueves 15hs", "Pilates: Lunes y Miércoles 18hs", "Tenis: Miércoles y Viernes 20hs", "Musculación: Martes y Jueves 19hs", "Yoga:  Lunes y Miércoles 16hs", "Aerobic: Martes y Jueves 12hs", "Danza: Lunes, Miércoles y Viernes 19hs", "Danza: Lunes, Miércoles y Viernes 11hs" });
            comboBoxSeleccionarActividad.Location = new Point(395, 176);
            comboBoxSeleccionarActividad.Name = "comboBoxSeleccionarActividad";
            comboBoxSeleccionarActividad.Size = new Size(160, 23);
            comboBoxSeleccionarActividad.TabIndex = 50;
            comboBoxSeleccionarActividad.SelectedIndexChanged += comboBoxSeleccionarActividad_SelectedIndexChanged;
            // 
            // labelMonto
            // 
            labelMonto.AutoSize = true;
            labelMonto.Location = new Point(259, 233);
            labelMonto.Name = "labelMonto";
            labelMonto.Size = new Size(43, 15);
            labelMonto.TabIndex = 51;
            labelMonto.Text = "Monto";
            labelMonto.Click += labelMonto_Click;
            // 
            // textBoxMonto
            // 
            textBoxMonto.Location = new Point(395, 225);
            textBoxMonto.Name = "textBoxMonto";
            textBoxMonto.Size = new Size(160, 23);
            textBoxMonto.TabIndex = 52;
            textBoxMonto.TextChanged += textBoxMonto_TextChanged;
            // 
            // labelHorarios
            // 
            labelHorarios.AutoSize = true;
            labelHorarios.Location = new Point(259, 287);
            labelHorarios.Name = "labelHorarios";
            labelHorarios.Size = new Size(52, 15);
            labelHorarios.TabIndex = 53;
            labelHorarios.Text = "Horarios";
            labelHorarios.Click += labelHorarios_Click;
            // 
            // textBoxHorarios
            // 
            textBoxHorarios.Location = new Point(395, 279);
            textBoxHorarios.Name = "textBoxHorarios";
            textBoxHorarios.Size = new Size(161, 23);
            textBoxHorarios.TabIndex = 54;
            textBoxHorarios.TextChanged += textBoxHorarios_TextChanged;
            // 
            // buttonPagoNoSocioCancelar
            // 
            buttonPagoNoSocioCancelar.BackColor = Color.FromArgb(128, 0, 70, 160);
            buttonPagoNoSocioCancelar.FlatStyle = FlatStyle.Flat;
            buttonPagoNoSocioCancelar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonPagoNoSocioCancelar.ForeColor = Color.White;
            buttonPagoNoSocioCancelar.Location = new Point(405, 399);
            buttonPagoNoSocioCancelar.Name = "buttonPagoNoSocioCancelar";
            buttonPagoNoSocioCancelar.Size = new Size(200, 28);
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
            buttonPagoNoSocioAceptar.Location = new Point(181, 399);
            buttonPagoNoSocioAceptar.Name = "buttonPagoNoSocioAceptar";
            buttonPagoNoSocioAceptar.Size = new Size(200, 28);
            buttonPagoNoSocioAceptar.TabIndex = 58;
            buttonPagoNoSocioAceptar.Text = "Aceptar";
            buttonPagoNoSocioAceptar.UseVisualStyleBackColor = false;
            buttonPagoNoSocioAceptar.Click += buttonPagoNoSocioAceptar_Click;
            // 
            // labelFormaPago
            // 
            labelFormaPago.AutoSize = true;
            labelFormaPago.Location = new Point(259, 335);
            labelFormaPago.Name = "labelFormaPago";
            labelFormaPago.Size = new Size(87, 15);
            labelFormaPago.TabIndex = 60;
            labelFormaPago.Text = "Forma de Pago";
            labelFormaPago.Click += labelFormaPago_Click_1;
            // 
            // comboBoxFormaPago
            // 
            comboBoxFormaPago.FormattingEnabled = true;
            comboBoxFormaPago.Items.AddRange(new object[] { "Efectivo", "Transferencia", "Tarjeta" });
            comboBoxFormaPago.Location = new Point(395, 327);
            comboBoxFormaPago.Name = "comboBoxFormaPago";
            comboBoxFormaPago.Size = new Size(160, 23);
            comboBoxFormaPago.TabIndex = 61;
            comboBoxFormaPago.SelectedIndexChanged += comboBoxFormaPago_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(561, 129);
            label1.Name = "label1";
            label1.Size = new Size(12, 15);
            label1.TabIndex = 62;
            label1.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(561, 179);
            label2.Name = "label2";
            label2.Size = new Size(12, 15);
            label2.TabIndex = 63;
            label2.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(561, 228);
            label3.Name = "label3";
            label3.Size = new Size(12, 15);
            label3.TabIndex = 64;
            label3.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(561, 282);
            label4.Name = "label4";
            label4.Size = new Size(12, 15);
            label4.TabIndex = 65;
            label4.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(561, 330);
            label5.Name = "label5";
            label5.Size = new Size(12, 15);
            label5.TabIndex = 66;
            label5.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(337, 372);
            label6.Name = "label6";
            label6.Size = new Size(127, 15);
            label6.TabIndex = 67;
            label6.Text = "* Campos Obligatorios";
            label6.Click += label6_Click;
            // 
            // FormPagoNoSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxFormaPago);
            Controls.Add(labelFormaPago);
            Controls.Add(buttonPagoNoSocioCancelar);
            Controls.Add(buttonPagoNoSocioAceptar);
            Controls.Add(textBoxHorarios);
            Controls.Add(labelHorarios);
            Controls.Add(textBoxMonto);
            Controls.Add(labelMonto);
            Controls.Add(comboBoxSeleccionarActividad);
            Controls.Add(labelSeleccionarActividad);
            Controls.Add(textBoxIdClienteNoSocio);
            Controls.Add(labelIdClienteNoSocio);
            Controls.Add(labelPagoNoSocioTitulo);
            Controls.Add(panelPagoNoSocioHeader);
            Name = "FormPagoNoSocio";
            Text = "FormPagoNoSocio";
            Load += FormPagoNoSocio_Load_1;
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
        private TextBox textBoxMonto;
        private Label labelFormaPago;
        private Label labelHorarios;
        private TextBox textBoxHorarios;
        private Button buttonPagoNoSocioCancelar;
        private Button buttonPagoNoSocioAceptar;
        private ComboBox comboBoxFormaPago;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}