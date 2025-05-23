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
            panelPagoSocioHeader = new Panel();
            labelInicioHeader = new Label();
            labelPagoSocioTitulo = new Label();
            labelIdClienteSocio = new Label();
            textBoxIdClienteSocio = new TextBox();
            labelSeleccionarActividad = new Label();
            comboBoxSeleccionarActividad = new ComboBox();
            labelMonto = new Label();
            textBoxMonto = new TextBox();
            labelHorarios = new Label();
            textBoxHorarios = new TextBox();
            buttonPagoSocioCancelar = new Button();
            buttonPagoSocioAceptar = new Button();
            panelPagoSocioHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelPagoSocioHeader
            // 
            panelPagoSocioHeader.BackColor = Color.FromArgb(0, 70, 160);
            panelPagoSocioHeader.Controls.Add(labelInicioHeader);
            panelPagoSocioHeader.Location = new Point(0, 1);
            panelPagoSocioHeader.Name = "panelPagoSocioHeader";
            panelPagoSocioHeader.Size = new Size(801, 42);
            panelPagoSocioHeader.TabIndex = 39;
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
            // labelPagoSocioTitulo
            // 
            labelPagoSocioTitulo.AutoSize = true;
            labelPagoSocioTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPagoSocioTitulo.ForeColor = Color.Black;
            labelPagoSocioTitulo.Location = new Point(300, 110);
            labelPagoSocioTitulo.Name = "labelPagoSocioTitulo";
            labelPagoSocioTitulo.Size = new Size(234, 25);
            labelPagoSocioTitulo.TabIndex = 46;
            labelPagoSocioTitulo.Text = "Registro de Pago No Socio";
            labelPagoSocioTitulo.Click += labelPagoSocioTitulo_Click;
            // 
            // labelIdClienteSocio
            // 
            labelIdClienteSocio.AutoSize = true;
            labelIdClienteSocio.Location = new Point(270, 179);
            labelIdClienteSocio.Name = "labelIdClienteSocio";
            labelIdClienteSocio.Size = new Size(58, 15);
            labelIdClienteSocio.TabIndex = 47;
            labelIdClienteSocio.Text = "ID Cliente";
            labelIdClienteSocio.Click += labelIdClienteSocio_Click;
            // 
            // textBoxIdClienteSocio
            // 
            textBoxIdClienteSocio.Location = new Point(405, 171);
            textBoxIdClienteSocio.Name = "textBoxIdClienteSocio";
            textBoxIdClienteSocio.Size = new Size(161, 23);
            textBoxIdClienteSocio.TabIndex = 48;
            textBoxIdClienteSocio.TextChanged += textBoxIdClienteSocio_TextChanged;
            // 
            // labelSeleccionarActividad
            // 
            labelSeleccionarActividad.AutoSize = true;
            labelSeleccionarActividad.Location = new Point(270, 230);
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
            comboBoxSeleccionarActividad.Location = new Point(406, 229);
            comboBoxSeleccionarActividad.Name = "comboBoxSeleccionarActividad";
            comboBoxSeleccionarActividad.Size = new Size(160, 23);
            comboBoxSeleccionarActividad.TabIndex = 50;
            comboBoxSeleccionarActividad.SelectedIndexChanged += comboBoxSeleccionarActividad_SelectedIndexChanged;
            // 
            // labelMonto
            // 
            labelMonto.AutoSize = true;
            labelMonto.Location = new Point(270, 287);
            labelMonto.Name = "labelMonto";
            labelMonto.Size = new Size(43, 15);
            labelMonto.TabIndex = 51;
            labelMonto.Text = "Monto";
            // 
            // textBoxMonto
            // 
            textBoxMonto.Location = new Point(406, 288);
            textBoxMonto.Name = "textBoxMonto";
            textBoxMonto.Size = new Size(160, 23);
            textBoxMonto.TabIndex = 52;
            textBoxMonto.TextChanged += textBoxMonto_TextChanged;
            // 
            // labelHorarios
            // 
            labelHorarios.AutoSize = true;
            labelHorarios.Location = new Point(270, 344);
            labelHorarios.Name = "labelHorarios";
            labelHorarios.Size = new Size(52, 15);
            labelHorarios.TabIndex = 53;
            labelHorarios.Text = "Horarios";
            labelHorarios.Click += labelHorarios_Click;
            // 
            // textBoxHorarios
            // 
            textBoxHorarios.Location = new Point(405, 336);
            textBoxHorarios.Name = "textBoxHorarios";
            textBoxHorarios.Size = new Size(161, 23);
            textBoxHorarios.TabIndex = 54;
            textBoxHorarios.TextChanged += textBoxHorarios_TextChanged;
            // 
            // buttonPagoSocioCancelar
            // 
            buttonPagoSocioCancelar.BackColor = Color.FromArgb(128, 0, 70, 160);
            buttonPagoSocioCancelar.FlatStyle = FlatStyle.Flat;
            buttonPagoSocioCancelar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonPagoSocioCancelar.ForeColor = Color.White;
            buttonPagoSocioCancelar.Location = new Point(405, 399);
            buttonPagoSocioCancelar.Name = "buttonPagoSocioCancelar";
            buttonPagoSocioCancelar.Size = new Size(200, 28);
            buttonPagoSocioCancelar.TabIndex = 59;
            buttonPagoSocioCancelar.Text = "Cancelar";
            buttonPagoSocioCancelar.UseVisualStyleBackColor = false;
            // 
            // buttonPagoSocioAceptar
            // 
            buttonPagoSocioAceptar.BackColor = Color.FromArgb(0, 70, 160);
            buttonPagoSocioAceptar.FlatStyle = FlatStyle.Flat;
            buttonPagoSocioAceptar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPagoSocioAceptar.ForeColor = Color.White;
            buttonPagoSocioAceptar.Location = new Point(181, 399);
            buttonPagoSocioAceptar.Name = "buttonPagoSocioAceptar";
            buttonPagoSocioAceptar.Size = new Size(200, 28);
            buttonPagoSocioAceptar.TabIndex = 58;
            buttonPagoSocioAceptar.Text = "Aceptar";
            buttonPagoSocioAceptar.UseVisualStyleBackColor = false;
            // 
            // FormPagoNoSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonPagoSocioCancelar);
            Controls.Add(buttonPagoSocioAceptar);
            Controls.Add(textBoxHorarios);
            Controls.Add(labelHorarios);
            Controls.Add(textBoxMonto);
            Controls.Add(labelMonto);
            Controls.Add(comboBoxSeleccionarActividad);
            Controls.Add(labelSeleccionarActividad);
            Controls.Add(textBoxIdClienteSocio);
            Controls.Add(labelIdClienteSocio);
            Controls.Add(labelPagoSocioTitulo);
            Controls.Add(panelPagoSocioHeader);
            Name = "FormPagoNoSocio";
            Text = "FormPagoNoSocio";
            panelPagoSocioHeader.ResumeLayout(false);
            panelPagoSocioHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelPagoSocioHeader;
        private Label labelInicioHeader;
        private Label labelPagoSocioTitulo;
        private Label labelIdClienteSocio;
        private TextBox textBoxIdClienteSocio;
        private Label labelSeleccionarActividad;
        private ComboBox comboBoxSeleccionarActividad;
        private Label labelMonto;
        private TextBox textBoxMonto;
        private Label label1;
        private Label labelHorarios;
        private TextBox textBoxHorarios;
        private Button buttonPagoSocioCancelar;
        private Button buttonPagoSocioAceptar;
    }
}