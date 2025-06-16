namespace ClubDeportivo
{
    partial class FormPagoSocio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPagoSocio));
            buttonPagoSocioCancelar = new Button();
            buttonPagoSocioAceptar = new Button();
            textBoxNumTarjeta = new TextBox();
            labelNumTarjeta = new Label();
            comboBoxNumCuota = new ComboBox();
            labelNumCuota = new Label();
            comboBoxModoPago = new ComboBox();
            labelModoPago = new Label();
            comboBoxSeleccionarCuota = new ComboBox();
            labelSelectCuota = new Label();
            labelPagoSocioTitulo = new Label();
            labelMontoSocio = new Label();
            textBoxIdClienteSocio = new TextBox();
            labelIdClienteSocio = new Label();
            panelPagoSocioHeader = new Panel();
            labelInicioHeader = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5Warning = new Label();
            label6Warning = new Label();
            label9 = new Label();
            textBoxMontoPagoSocio = new TextBox();
            labelMoneda = new Label();
            panelPagoSocioHeader.SuspendLayout();
            SuspendLayout();
            // 
            // buttonPagoSocioCancelar
            // 
            buttonPagoSocioCancelar.BackColor = Color.FromArgb(128, 0, 70, 160);
            buttonPagoSocioCancelar.FlatStyle = FlatStyle.Flat;
            buttonPagoSocioCancelar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonPagoSocioCancelar.ForeColor = Color.White;
            buttonPagoSocioCancelar.Location = new Point(430, 333);
            buttonPagoSocioCancelar.Name = "buttonPagoSocioCancelar";
            buttonPagoSocioCancelar.Size = new Size(200, 28);
            buttonPagoSocioCancelar.TabIndex = 57;
            buttonPagoSocioCancelar.Text = "Cancelar";
            buttonPagoSocioCancelar.UseVisualStyleBackColor = false;
            buttonPagoSocioCancelar.Click += buttonPagoSocioCancelar_Click;
            // 
            // buttonPagoSocioAceptar
            // 
            buttonPagoSocioAceptar.BackColor = Color.FromArgb(0, 70, 160);
            buttonPagoSocioAceptar.FlatStyle = FlatStyle.Flat;
            buttonPagoSocioAceptar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPagoSocioAceptar.ForeColor = Color.White;
            buttonPagoSocioAceptar.Location = new Point(206, 333);
            buttonPagoSocioAceptar.Name = "buttonPagoSocioAceptar";
            buttonPagoSocioAceptar.Size = new Size(200, 28);
            buttonPagoSocioAceptar.TabIndex = 56;
            buttonPagoSocioAceptar.Text = "Aceptar";
            buttonPagoSocioAceptar.UseVisualStyleBackColor = false;
            buttonPagoSocioAceptar.Click += buttonPagoSocioAceptar_Click;
            // 
            // textBoxNumTarjeta
            // 
            textBoxNumTarjeta.Enabled = false;
            textBoxNumTarjeta.Location = new Point(567, 221);
            textBoxNumTarjeta.Name = "textBoxNumTarjeta";
            textBoxNumTarjeta.Size = new Size(161, 23);
            textBoxNumTarjeta.TabIndex = 53;
            // 
            // labelNumTarjeta
            // 
            labelNumTarjeta.AutoSize = true;
            labelNumTarjeta.Enabled = false;
            labelNumTarjeta.Location = new Point(403, 223);
            labelNumTarjeta.Name = "labelNumTarjeta";
            labelNumTarjeta.Size = new Size(73, 15);
            labelNumTarjeta.TabIndex = 52;
            labelNumTarjeta.Text = "N° de tarjeta";
            // 
            // comboBoxNumCuota
            // 
            comboBoxNumCuota.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxNumCuota.Enabled = false;
            comboBoxNumCuota.FormattingEnabled = true;
            comboBoxNumCuota.Items.AddRange(new object[] { "3", "6" });
            comboBoxNumCuota.Location = new Point(567, 183);
            comboBoxNumCuota.Name = "comboBoxNumCuota";
            comboBoxNumCuota.Size = new Size(161, 23);
            comboBoxNumCuota.TabIndex = 51;
            // 
            // labelNumCuota
            // 
            labelNumCuota.AutoSize = true;
            labelNumCuota.Enabled = false;
            labelNumCuota.Location = new Point(403, 185);
            labelNumCuota.Name = "labelNumCuota";
            labelNumCuota.Size = new Size(59, 15);
            labelNumCuota.TabIndex = 50;
            labelNumCuota.Text = "N° cuotas";
            // 
            // comboBoxModoPago
            // 
            comboBoxModoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxModoPago.FormattingEnabled = true;
            comboBoxModoPago.Items.AddRange(new object[] { "Efectivo", "Tarjeta", "Transferencia" });
            comboBoxModoPago.Location = new Point(567, 136);
            comboBoxModoPago.Name = "comboBoxModoPago";
            comboBoxModoPago.Size = new Size(161, 23);
            comboBoxModoPago.TabIndex = 49;
            comboBoxModoPago.SelectedIndexChanged += comboBoxModoPago_SelectedIndexChanged;
            // 
            // labelModoPago
            // 
            labelModoPago.AutoSize = true;
            labelModoPago.Location = new Point(403, 143);
            labelModoPago.Name = "labelModoPago";
            labelModoPago.Size = new Size(69, 15);
            labelModoPago.TabIndex = 48;
            labelModoPago.Text = "Modo pago";
            // 
            // comboBoxSeleccionarCuota
            // 
            comboBoxSeleccionarCuota.BackColor = Color.White;
            comboBoxSeleccionarCuota.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSeleccionarCuota.Font = new Font("Segoe UI", 9.75F);
            comboBoxSeleccionarCuota.ForeColor = SystemColors.WindowText;
            comboBoxSeleccionarCuota.FormattingEnabled = true;
            comboBoxSeleccionarCuota.Location = new Point(188, 176);
            comboBoxSeleccionarCuota.Name = "comboBoxSeleccionarCuota";
            comboBoxSeleccionarCuota.Size = new Size(161, 25);
            comboBoxSeleccionarCuota.TabIndex = 47;
            comboBoxSeleccionarCuota.SelectedIndexChanged += comboBoxSeleccionarCuota_Monto;
            // 
            // labelSelectCuota
            // 
            labelSelectCuota.AutoSize = true;
            labelSelectCuota.Location = new Point(24, 183);
            labelSelectCuota.Name = "labelSelectCuota";
            labelSelectCuota.Size = new Size(100, 15);
            labelSelectCuota.TabIndex = 46;
            labelSelectCuota.Text = "Seleccionar cuota";
            // 
            // labelPagoSocioTitulo
            // 
            labelPagoSocioTitulo.AutoSize = true;
            labelPagoSocioTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPagoSocioTitulo.ForeColor = Color.Black;
            labelPagoSocioTitulo.Location = new Point(292, 75);
            labelPagoSocioTitulo.Name = "labelPagoSocioTitulo";
            labelPagoSocioTitulo.Size = new Size(184, 25);
            labelPagoSocioTitulo.TabIndex = 45;
            labelPagoSocioTitulo.Text = "Registrar Pago Socio";
            // 
            // labelMontoSocio
            // 
            labelMontoSocio.AutoSize = true;
            labelMontoSocio.Location = new Point(24, 222);
            labelMontoSocio.Name = "labelMontoSocio";
            labelMontoSocio.Size = new Size(43, 15);
            labelMontoSocio.TabIndex = 41;
            labelMontoSocio.Text = "Monto";
            // 
            // textBoxIdClienteSocio
            // 
            textBoxIdClienteSocio.Location = new Point(188, 135);
            textBoxIdClienteSocio.Name = "textBoxIdClienteSocio";
            textBoxIdClienteSocio.Size = new Size(161, 23);
            textBoxIdClienteSocio.TabIndex = 40;
            textBoxIdClienteSocio.KeyDown += textBoxIdClienteSocio_KeyDown;
            textBoxIdClienteSocio.Validating += textBoxIdClienteSocio_Validating;
            // 
            // labelIdClienteSocio
            // 
            labelIdClienteSocio.AutoSize = true;
            labelIdClienteSocio.Location = new Point(24, 147);
            labelIdClienteSocio.Name = "labelIdClienteSocio";
            labelIdClienteSocio.Size = new Size(58, 15);
            labelIdClienteSocio.TabIndex = 39;
            labelIdClienteSocio.Text = "ID Cliente";
            // 
            // panelPagoSocioHeader
            // 
            panelPagoSocioHeader.BackColor = Color.FromArgb(0, 70, 160);
            panelPagoSocioHeader.Controls.Add(labelInicioHeader);
            panelPagoSocioHeader.Location = new Point(0, 0);
            panelPagoSocioHeader.Name = "panelPagoSocioHeader";
            panelPagoSocioHeader.Size = new Size(801, 42);
            panelPagoSocioHeader.TabIndex = 38;
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
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(355, 140);
            label1.Name = "label1";
            label1.Size = new Size(17, 21);
            label1.TabIndex = 58;
            label1.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(355, 217);
            label2.Name = "label2";
            label2.Size = new Size(17, 21);
            label2.TabIndex = 59;
            label2.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(355, 178);
            label3.Name = "label3";
            label3.Size = new Size(17, 21);
            label3.TabIndex = 60;
            label3.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(734, 141);
            label4.Name = "label4";
            label4.Size = new Size(17, 21);
            label4.TabIndex = 61;
            label4.Text = "*";
            // 
            // label5Warning
            // 
            label5Warning.AutoSize = true;
            label5Warning.Enabled = false;
            label5Warning.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5Warning.ForeColor = Color.Red;
            label5Warning.Location = new Point(734, 185);
            label5Warning.Name = "label5Warning";
            label5Warning.Size = new Size(17, 21);
            label5Warning.TabIndex = 62;
            label5Warning.Text = "*";
            // 
            // label6Warning
            // 
            label6Warning.AutoSize = true;
            label6Warning.Enabled = false;
            label6Warning.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6Warning.ForeColor = Color.Red;
            label6Warning.Location = new Point(734, 223);
            label6Warning.Name = "label6Warning";
            label6Warning.Size = new Size(17, 21);
            label6Warning.TabIndex = 63;
            label6Warning.Text = "*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 8.25F);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(328, 302);
            label9.Name = "label9";
            label9.Size = new Size(122, 13);
            label9.TabIndex = 66;
            label9.Text = "* Campos obligatorios";
            // 
            // textBoxMontoPagoSocio
            // 
            textBoxMontoPagoSocio.BackColor = Color.White;
            textBoxMontoPagoSocio.Location = new Point(188, 215);
            textBoxMontoPagoSocio.Name = "textBoxMontoPagoSocio";
            textBoxMontoPagoSocio.ReadOnly = true;
            textBoxMontoPagoSocio.Size = new Size(161, 23);
            textBoxMontoPagoSocio.TabIndex = 67;
            // 
            // labelMoneda
            // 
            labelMoneda.AutoSize = true;
            labelMoneda.Location = new Point(167, 222);
            labelMoneda.Name = "labelMoneda";
            labelMoneda.Size = new Size(13, 15);
            labelMoneda.TabIndex = 68;
            labelMoneda.Text = "$";
            // 
            // FormPagoSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 397);
            Controls.Add(labelMoneda);
            Controls.Add(textBoxMontoPagoSocio);
            Controls.Add(label9);
            Controls.Add(label6Warning);
            Controls.Add(label5Warning);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonPagoSocioCancelar);
            Controls.Add(buttonPagoSocioAceptar);
            Controls.Add(textBoxNumTarjeta);
            Controls.Add(labelNumTarjeta);
            Controls.Add(comboBoxNumCuota);
            Controls.Add(labelNumCuota);
            Controls.Add(comboBoxModoPago);
            Controls.Add(labelModoPago);
            Controls.Add(comboBoxSeleccionarCuota);
            Controls.Add(labelSelectCuota);
            Controls.Add(labelPagoSocioTitulo);
            Controls.Add(labelMontoSocio);
            Controls.Add(textBoxIdClienteSocio);
            Controls.Add(labelIdClienteSocio);
            Controls.Add(panelPagoSocioHeader);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormPagoSocio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CLUB DEPORTIVO";
            panelPagoSocioHeader.ResumeLayout(false);
            panelPagoSocioHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonPagoSocioCancelar;
        private Button buttonPagoSocioAceptar;
        private TextBox textBoxNumTarjeta;
        private Label labelNumTarjeta;
        private ComboBox comboBoxNumCuota;
        private Label labelNumCuota;
        private ComboBox comboBoxModoPago;
        private Label labelModoPago;
        private ComboBox comboBoxSeleccionarCuota;
        private Label labelSelectCuota;
        private Label labelPagoSocioTitulo;
        private TextBox textBoxMontoSocio;
        private Label labelMontoSocio;
        private TextBox textBoxIdClienteSocio;
        private Label labelIdClienteSocio;
        private Panel panelPagoSocioHeader;
        private Label labelInicioHeader;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5Warning;
        private Label label6Warning;
        private Label label9;
        private TextBox textBoxMontoPagoSocio;
        private Label labelMoneda;
    }
}