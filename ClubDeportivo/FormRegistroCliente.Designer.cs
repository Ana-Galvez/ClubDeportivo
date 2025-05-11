namespace ClubDeportivo
{
    partial class FormRegistroCliente
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
            labelRegistroTitulo = new Label();
            labelNombre = new Label();
            textBoxNombre = new TextBox();
            textBoxApellido = new TextBox();
            labelApellido = new Label();
            labelFechNac = new Label();
            dateTimePickerFechNac = new DateTimePicker();
            textBoxDNI = new TextBox();
            labelDNI = new Label();
            radioButtonPrefNoDecir = new RadioButton();
            dateTimePickerFechIns = new DateTimePicker();
            labelFechInsc = new Label();
            textBoxTelefono = new TextBox();
            labelTelefono = new Label();
            textBoxDireccion = new TextBox();
            labelDireccion = new Label();
            radioButtonAptoFisicoNo = new RadioButton();
            radioButtonAptoFisicoSi = new RadioButton();
            radioButtonSocioNo = new RadioButton();
            radioButtonSocioSi = new RadioButton();
            buttonRegistroClienteAceptar = new Button();
            buttonRegistroClienteCancelar = new Button();
            panelRegistroHeader = new Panel();
            labelRegistroHeader = new Label();
            radioButtonFemenino = new RadioButton();
            radioButtonMasculino = new RadioButton();
            groupBoxGenero = new GroupBox();
            groupBoxAptoFisico = new GroupBox();
            groupBoxSocio = new GroupBox();
            labelAsterisco = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            labelWarning = new Label();
            panelRegistroHeader.SuspendLayout();
            groupBoxGenero.SuspendLayout();
            groupBoxAptoFisico.SuspendLayout();
            groupBoxSocio.SuspendLayout();
            SuspendLayout();
            // 
            // labelRegistroTitulo
            // 
            labelRegistroTitulo.AutoSize = true;
            labelRegistroTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRegistroTitulo.ForeColor = Color.Black;
            labelRegistroTitulo.Location = new Point(307, 81);
            labelRegistroTitulo.Name = "labelRegistroTitulo";
            labelRegistroTitulo.Size = new Size(167, 25);
            labelRegistroTitulo.TabIndex = 8;
            labelRegistroTitulo.Text = "Registro de cliente";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(27, 128);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(57, 17);
            labelNombre.TabIndex = 9;
            labelNombre.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(191, 125);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(161, 25);
            textBoxNombre.TabIndex = 10;
            textBoxNombre.Tag = "required";
            textBoxNombre.TextChanged += textBoxNombre_TextChanged;
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(191, 165);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(161, 25);
            textBoxApellido.TabIndex = 12;
            textBoxApellido.Tag = "required";
            textBoxApellido.TextChanged += textBoxApellido_TextChanged;
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Location = new Point(27, 168);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(56, 17);
            labelApellido.TabIndex = 11;
            labelApellido.Text = "Apellido";
            // 
            // labelFechNac
            // 
            labelFechNac.AutoSize = true;
            labelFechNac.Location = new Point(27, 212);
            labelFechNac.Name = "labelFechNac";
            labelFechNac.Size = new Size(127, 17);
            labelFechNac.TabIndex = 13;
            labelFechNac.Text = "Fecha de nacimiento";
            // 
            // dateTimePickerFechNac
            // 
            dateTimePickerFechNac.Format = DateTimePickerFormat.Short;
            dateTimePickerFechNac.Location = new Point(191, 206);
            dateTimePickerFechNac.Margin = new Padding(0);
            dateTimePickerFechNac.Name = "dateTimePickerFechNac";
            dateTimePickerFechNac.Size = new Size(161, 25);
            dateTimePickerFechNac.TabIndex = 14;
            dateTimePickerFechNac.Tag = "\"required\"";
            dateTimePickerFechNac.ValueChanged += dateTimePickerFechNac_ValueChanged;
            // 
            // textBoxDNI
            // 
            textBoxDNI.Location = new Point(191, 247);
            textBoxDNI.Name = "textBoxDNI";
            textBoxDNI.Size = new Size(161, 25);
            textBoxDNI.TabIndex = 16;
            textBoxDNI.Tag = "required";
            textBoxDNI.TextChanged += textBoxDNI_TextChanged;
            // 
            // labelDNI
            // 
            labelDNI.AutoSize = true;
            labelDNI.Location = new Point(27, 250);
            labelDNI.Name = "labelDNI";
            labelDNI.Size = new Size(30, 17);
            labelDNI.TabIndex = 15;
            labelDNI.Text = "DNI";
            // 
            // radioButtonPrefNoDecir
            // 
            radioButtonPrefNoDecir.AutoSize = true;
            radioButtonPrefNoDecir.Location = new Point(101, 14);
            radioButtonPrefNoDecir.Name = "radioButtonPrefNoDecir";
            radioButtonPrefNoDecir.Size = new Size(124, 21);
            radioButtonPrefNoDecir.TabIndex = 20;
            radioButtonPrefNoDecir.TabStop = true;
            radioButtonPrefNoDecir.Text = "Prefiero no decir";
            radioButtonPrefNoDecir.UseVisualStyleBackColor = true;
            radioButtonPrefNoDecir.CheckedChanged += radioButtonPrefNoDecir_CheckedChanged;
            // 
            // dateTimePickerFechIns
            // 
            dateTimePickerFechIns.Format = DateTimePickerFormat.Short;
            dateTimePickerFechIns.Location = new Point(603, 120);
            dateTimePickerFechIns.Name = "dateTimePickerFechIns";
            dateTimePickerFechIns.Size = new Size(161, 25);
            dateTimePickerFechIns.TabIndex = 26;
            dateTimePickerFechIns.Tag = "";
            dateTimePickerFechIns.ValueChanged += dateTimePickerFechIns_ValueChanged;
            // 
            // labelFechInsc
            // 
            labelFechInsc.AutoSize = true;
            labelFechInsc.Location = new Point(439, 126);
            labelFechInsc.Name = "labelFechInsc";
            labelFechInsc.Size = new Size(126, 17);
            labelFechInsc.TabIndex = 25;
            labelFechInsc.Text = "Fecha de inscripción";
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Location = new Point(190, 330);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(161, 25);
            textBoxTelefono.TabIndex = 24;
            textBoxTelefono.Tag = "required";
            textBoxTelefono.TextChanged += textBoxTelefono_TextChanged;
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Location = new Point(26, 333);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(58, 17);
            labelTelefono.TabIndex = 23;
            labelTelefono.Text = "Teléfono";
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.Location = new Point(191, 288);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(161, 25);
            textBoxDireccion.TabIndex = 22;
            textBoxDireccion.Tag = "required";
            textBoxDireccion.TextChanged += textBoxDireccion_TextChanged;
            // 
            // labelDireccion
            // 
            labelDireccion.AutoSize = true;
            labelDireccion.Location = new Point(27, 291);
            labelDireccion.Name = "labelDireccion";
            labelDireccion.Size = new Size(62, 17);
            labelDireccion.TabIndex = 21;
            labelDireccion.Text = "Dirección";
            // 
            // radioButtonAptoFisicoNo
            // 
            radioButtonAptoFisicoNo.AutoSize = true;
            radioButtonAptoFisicoNo.Location = new Point(150, 31);
            radioButtonAptoFisicoNo.Name = "radioButtonAptoFisicoNo";
            radioButtonAptoFisicoNo.Size = new Size(46, 21);
            radioButtonAptoFisicoNo.TabIndex = 29;
            radioButtonAptoFisicoNo.TabStop = true;
            radioButtonAptoFisicoNo.Text = "NO";
            radioButtonAptoFisicoNo.UseVisualStyleBackColor = true;
            radioButtonAptoFisicoNo.CheckedChanged += radioButtonAptoFisicoNo_CheckedChanged;
            // 
            // radioButtonAptoFisicoSi
            // 
            radioButtonAptoFisicoSi.AutoSize = true;
            radioButtonAptoFisicoSi.Location = new Point(92, 31);
            radioButtonAptoFisicoSi.Name = "radioButtonAptoFisicoSi";
            radioButtonAptoFisicoSi.Size = new Size(36, 21);
            radioButtonAptoFisicoSi.TabIndex = 28;
            radioButtonAptoFisicoSi.TabStop = true;
            radioButtonAptoFisicoSi.Text = "SI";
            radioButtonAptoFisicoSi.UseVisualStyleBackColor = true;
            radioButtonAptoFisicoSi.CheckedChanged += radioButtonAptoFisicoSi_CheckedChanged;
            // 
            // radioButtonSocioNo
            // 
            radioButtonSocioNo.AutoSize = true;
            radioButtonSocioNo.Location = new Point(136, 35);
            radioButtonSocioNo.Name = "radioButtonSocioNo";
            radioButtonSocioNo.Size = new Size(46, 21);
            radioButtonSocioNo.TabIndex = 33;
            radioButtonSocioNo.TabStop = true;
            radioButtonSocioNo.Text = "NO";
            radioButtonSocioNo.UseVisualStyleBackColor = true;
            radioButtonSocioNo.CheckedChanged += radioButtonSocioNo_CheckedChanged;
            // 
            // radioButtonSocioSi
            // 
            radioButtonSocioSi.AutoSize = true;
            radioButtonSocioSi.Location = new Point(78, 35);
            radioButtonSocioSi.Name = "radioButtonSocioSi";
            radioButtonSocioSi.Size = new Size(36, 21);
            radioButtonSocioSi.TabIndex = 32;
            radioButtonSocioSi.TabStop = true;
            radioButtonSocioSi.Text = "SI";
            radioButtonSocioSi.UseVisualStyleBackColor = true;
            radioButtonSocioSi.CheckedChanged += radioButtonSocioSi_CheckedChanged;
            // 
            // buttonRegistroClienteAceptar
            // 
            buttonRegistroClienteAceptar.BackColor = Color.FromArgb(0, 70, 160);
            buttonRegistroClienteAceptar.FlatStyle = FlatStyle.Flat;
            buttonRegistroClienteAceptar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRegistroClienteAceptar.ForeColor = Color.White;
            buttonRegistroClienteAceptar.Location = new Point(222, 395);
            buttonRegistroClienteAceptar.Name = "buttonRegistroClienteAceptar";
            buttonRegistroClienteAceptar.Size = new Size(200, 32);
            buttonRegistroClienteAceptar.TabIndex = 34;
            buttonRegistroClienteAceptar.Text = "Aceptar y emitir carnet";
            buttonRegistroClienteAceptar.UseVisualStyleBackColor = false;
            buttonRegistroClienteAceptar.Click += buttonRegistroClienteAceptar_Click;
            // 
            // buttonRegistroClienteCancelar
            // 
            buttonRegistroClienteCancelar.BackColor = Color.FromArgb(128, 0, 70, 160);
            buttonRegistroClienteCancelar.FlatStyle = FlatStyle.Flat;
            buttonRegistroClienteCancelar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonRegistroClienteCancelar.ForeColor = Color.White;
            buttonRegistroClienteCancelar.Location = new Point(466, 395);
            buttonRegistroClienteCancelar.Name = "buttonRegistroClienteCancelar";
            buttonRegistroClienteCancelar.Size = new Size(200, 32);
            buttonRegistroClienteCancelar.TabIndex = 35;
            buttonRegistroClienteCancelar.Text = "Cancelar";
            buttonRegistroClienteCancelar.UseVisualStyleBackColor = false;
            buttonRegistroClienteCancelar.Click += buttonRegistroClienteCancelar_Click;
            // 
            // panelRegistroHeader
            // 
            panelRegistroHeader.BackColor = Color.FromArgb(0, 70, 160);
            panelRegistroHeader.Controls.Add(labelRegistroHeader);
            panelRegistroHeader.Location = new Point(1, 0);
            panelRegistroHeader.Name = "panelRegistroHeader";
            panelRegistroHeader.Size = new Size(801, 48);
            panelRegistroHeader.TabIndex = 36;
            // 
            // labelRegistroHeader
            // 
            labelRegistroHeader.AutoSize = true;
            labelRegistroHeader.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRegistroHeader.ForeColor = Color.White;
            labelRegistroHeader.Location = new Point(0, 11);
            labelRegistroHeader.Name = "labelRegistroHeader";
            labelRegistroHeader.Padding = new Padding(10, 0, 0, 0);
            labelRegistroHeader.Size = new Size(181, 25);
            labelRegistroHeader.TabIndex = 0;
            labelRegistroHeader.Text = "CLUB DEPORTIVO";
            labelRegistroHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // radioButtonFemenino
            // 
            radioButtonFemenino.AutoSize = true;
            radioButtonFemenino.Location = new Point(19, 14);
            radioButtonFemenino.Name = "radioButtonFemenino";
            radioButtonFemenino.Size = new Size(32, 21);
            radioButtonFemenino.TabIndex = 18;
            radioButtonFemenino.TabStop = true;
            radioButtonFemenino.Text = "F";
            radioButtonFemenino.UseVisualStyleBackColor = true;
            radioButtonFemenino.CheckedChanged += radioButtonFemenino_CheckedChanged;
            // 
            // radioButtonMasculino
            // 
            radioButtonMasculino.AutoSize = true;
            radioButtonMasculino.Location = new Point(57, 14);
            radioButtonMasculino.Name = "radioButtonMasculino";
            radioButtonMasculino.Size = new Size(38, 21);
            radioButtonMasculino.TabIndex = 19;
            radioButtonMasculino.TabStop = true;
            radioButtonMasculino.Text = "M";
            radioButtonMasculino.UseVisualStyleBackColor = true;
            radioButtonMasculino.CheckedChanged += radioButtonMasculino_CheckedChanged;
            // 
            // groupBoxGenero
            // 
            groupBoxGenero.Controls.Add(radioButtonPrefNoDecir);
            groupBoxGenero.Controls.Add(radioButtonMasculino);
            groupBoxGenero.Controls.Add(radioButtonFemenino);
            groupBoxGenero.Location = new Point(439, 166);
            groupBoxGenero.Name = "groupBoxGenero";
            groupBoxGenero.Size = new Size(325, 45);
            groupBoxGenero.TabIndex = 37;
            groupBoxGenero.TabStop = false;
            groupBoxGenero.Tag = "\"required\"";
            groupBoxGenero.Text = "Género";
            // 
            // groupBoxAptoFisico
            // 
            groupBoxAptoFisico.Controls.Add(radioButtonAptoFisicoNo);
            groupBoxAptoFisico.Controls.Add(radioButtonAptoFisicoSi);
            groupBoxAptoFisico.Location = new Point(439, 225);
            groupBoxAptoFisico.Name = "groupBoxAptoFisico";
            groupBoxAptoFisico.Size = new Size(325, 61);
            groupBoxAptoFisico.TabIndex = 38;
            groupBoxAptoFisico.TabStop = false;
            groupBoxAptoFisico.Tag = "\"required\"";
            groupBoxAptoFisico.Text = "¿Apto físico?";
            // 
            // groupBoxSocio
            // 
            groupBoxSocio.Controls.Add(radioButtonSocioNo);
            groupBoxSocio.Controls.Add(radioButtonSocioSi);
            groupBoxSocio.Location = new Point(439, 292);
            groupBoxSocio.Name = "groupBoxSocio";
            groupBoxSocio.Size = new Size(325, 70);
            groupBoxSocio.TabIndex = 39;
            groupBoxSocio.TabStop = false;
            groupBoxSocio.Tag = "\"required\"";
            groupBoxSocio.Text = "¿Socio?";
            // 
            // labelAsterisco
            // 
            labelAsterisco.AutoSize = true;
            labelAsterisco.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAsterisco.ForeColor = Color.Red;
            labelAsterisco.Location = new Point(358, 129);
            labelAsterisco.Name = "labelAsterisco";
            labelAsterisco.Size = new Size(17, 21);
            labelAsterisco.TabIndex = 40;
            labelAsterisco.Text = "*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(358, 168);
            label1.Name = "label1";
            label1.Size = new Size(17, 21);
            label1.TabIndex = 41;
            label1.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(358, 206);
            label2.Name = "label2";
            label2.Size = new Size(17, 21);
            label2.TabIndex = 42;
            label2.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(358, 246);
            label3.Name = "label3";
            label3.Size = new Size(17, 21);
            label3.TabIndex = 43;
            label3.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(358, 292);
            label4.Name = "label4";
            label4.Size = new Size(17, 21);
            label4.TabIndex = 44;
            label4.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(357, 333);
            label5.Name = "label5";
            label5.Size = new Size(17, 21);
            label5.TabIndex = 45;
            label5.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(770, 180);
            label6.Name = "label6";
            label6.Size = new Size(17, 21);
            label6.TabIndex = 46;
            label6.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(770, 248);
            label7.Name = "label7";
            label7.Size = new Size(17, 21);
            label7.TabIndex = 47;
            label7.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(770, 314);
            label8.Name = "label8";
            label8.Size = new Size(17, 21);
            label8.TabIndex = 48;
            label8.Text = "*";
            // 
            // labelWarning
            // 
            labelWarning.AutoSize = true;
            labelWarning.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelWarning.ForeColor = Color.Red;
            labelWarning.Location = new Point(357, 375);
            labelWarning.Name = "labelWarning";
            labelWarning.Size = new Size(125, 13);
            labelWarning.TabIndex = 49;
            labelWarning.Text = "* Campos  obligatorios";
            // 
            // FormRegistroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelWarning);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelAsterisco);
            Controls.Add(groupBoxSocio);
            Controls.Add(groupBoxAptoFisico);
            Controls.Add(groupBoxGenero);
            Controls.Add(panelRegistroHeader);
            Controls.Add(buttonRegistroClienteCancelar);
            Controls.Add(buttonRegistroClienteAceptar);
            Controls.Add(dateTimePickerFechIns);
            Controls.Add(labelFechInsc);
            Controls.Add(textBoxTelefono);
            Controls.Add(labelTelefono);
            Controls.Add(textBoxDireccion);
            Controls.Add(labelDireccion);
            Controls.Add(textBoxDNI);
            Controls.Add(labelDNI);
            Controls.Add(dateTimePickerFechNac);
            Controls.Add(labelFechNac);
            Controls.Add(textBoxApellido);
            Controls.Add(labelApellido);
            Controls.Add(textBoxNombre);
            Controls.Add(labelNombre);
            Controls.Add(labelRegistroTitulo);
            Name = "FormRegistroCliente";
            Text = "Registrar Cliente";
            Load += FormRegistroCliente_Load;
            panelRegistroHeader.ResumeLayout(false);
            panelRegistroHeader.PerformLayout();
            groupBoxGenero.ResumeLayout(false);
            groupBoxGenero.PerformLayout();
            groupBoxAptoFisico.ResumeLayout(false);
            groupBoxAptoFisico.PerformLayout();
            groupBoxSocio.ResumeLayout(false);
            groupBoxSocio.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelRegistroTitulo;
        private Label labelNombre;
        private TextBox textBoxNombre;
        private TextBox textBoxApellido;
        private Label labelApellido;
        private Label labelFechNac;
        private DateTimePicker dateTimePickerFechNac;
        private TextBox textBoxDNI;
        private Label labelDNI;
        private RadioButton radioButtonPrefNoDecir;
        private DateTimePicker dateTimePickerFechIns;
        private Label labelFechInsc;
        private TextBox textBoxTelefono;
        private Label labelTelefono;
        private TextBox textBoxDireccion;
        private Label labelDireccion;
        private RadioButton radioButtonAptoFisicoNo;
        private RadioButton radioButtonAptoFisicoSi;
        private RadioButton radioButtonSocioNo;
        private RadioButton radioButtonSocioSi;
        private Button buttonRegistroClienteAceptar;
        private Button buttonRegistroClienteCancelar;
        private Panel panelRegistroHeader;
        private Label labelRegistroHeader;
        private RadioButton radioButtonFemenino;
        private RadioButton radioButtonMasculino;
        private GroupBox groupBoxGenero;
        private GroupBox groupBoxAptoFisico;
        private GroupBox groupBoxSocio;
        private Label labelAsterisco;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label labelWarning;
    }
}