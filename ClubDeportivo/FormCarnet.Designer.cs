namespace ClubDeportivo
{
    partial class FormCarnet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCarnet));
            panelCarnetHeader = new Panel();
            labelCarnetHeader = new Label();
            labelCarnetTitulo = new Label();
            pictureBoxCarnet = new PictureBox();
            label1 = new Label();
            labelNombre = new Label();
            labelApellido = new Label();
            label4 = new Label();
            labelFechaNacimiento = new Label();
            label6 = new Label();
            labelDNI = new Label();
            label8 = new Label();
            labelDireccion = new Label();
            label10 = new Label();
            labelTelefono = new Label();
            label12 = new Label();
            labelFechaInscripcion = new Label();
            label14 = new Label();
            labelGenero = new Label();
            labelGeneroText = new Label();
            labelAptoFisico = new Label();
            label18 = new Label();
            labelSocio = new Label();
            label20 = new Label();
            buttonCarnetVolver = new Button();
            labelID = new Label();
            labelIDText = new Label();
            panelCarnetHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCarnet).BeginInit();
            SuspendLayout();
            // 
            // panelCarnetHeader
            // 
            panelCarnetHeader.BackColor = Color.FromArgb(0, 70, 160);
            panelCarnetHeader.Controls.Add(labelCarnetHeader);
            panelCarnetHeader.Location = new Point(0, 0);
            panelCarnetHeader.Name = "panelCarnetHeader";
            panelCarnetHeader.Size = new Size(801, 48);
            panelCarnetHeader.TabIndex = 37;
            // 
            // labelCarnetHeader
            // 
            labelCarnetHeader.AutoSize = true;
            labelCarnetHeader.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCarnetHeader.ForeColor = Color.White;
            labelCarnetHeader.Location = new Point(0, 11);
            labelCarnetHeader.Name = "labelCarnetHeader";
            labelCarnetHeader.Padding = new Padding(10, 0, 0, 0);
            labelCarnetHeader.Size = new Size(181, 25);
            labelCarnetHeader.TabIndex = 0;
            labelCarnetHeader.Text = "CLUB DEPORTIVO";
            labelCarnetHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelCarnetTitulo
            // 
            labelCarnetTitulo.AutoSize = true;
            labelCarnetTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCarnetTitulo.ForeColor = Color.Black;
            labelCarnetTitulo.Location = new Point(482, 71);
            labelCarnetTitulo.Name = "labelCarnetTitulo";
            labelCarnetTitulo.Size = new Size(68, 25);
            labelCarnetTitulo.TabIndex = 38;
            labelCarnetTitulo.Text = "Carnet";
            // 
            // pictureBoxCarnet
            // 
            pictureBoxCarnet.Image = (Image)resources.GetObject("pictureBoxCarnet.Image");
            pictureBoxCarnet.Location = new Point(28, 117);
            pictureBoxCarnet.Name = "pictureBoxCarnet";
            pictureBoxCarnet.Size = new Size(258, 224);
            pictureBoxCarnet.TabIndex = 61;
            pictureBoxCarnet.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(325, 141);
            label1.Name = "label1";
            label1.Size = new Size(57, 17);
            label1.TabIndex = 40;
            label1.Text = "Nombre";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(417, 141);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(43, 17);
            labelNombre.TabIndex = 41;
            labelNombre.Text = "label2";
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Location = new Point(417, 182);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(43, 17);
            labelApellido.TabIndex = 43;
            labelApellido.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(325, 182);
            label4.Name = "label4";
            label4.Size = new Size(56, 17);
            label4.TabIndex = 42;
            label4.Text = "Apellido";
            // 
            // labelFechaNacimiento
            // 
            labelFechaNacimiento.AutoSize = true;
            labelFechaNacimiento.Location = new Point(417, 219);
            labelFechaNacimiento.Name = "labelFechaNacimiento";
            labelFechaNacimiento.Size = new Size(43, 17);
            labelFechaNacimiento.TabIndex = 45;
            labelFechaNacimiento.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(325, 219);
            label6.Name = "label6";
            label6.Size = new Size(87, 17);
            label6.TabIndex = 44;
            label6.Text = "Fecha de nac.";
            // 
            // labelDNI
            // 
            labelDNI.AutoSize = true;
            labelDNI.Location = new Point(417, 258);
            labelDNI.Name = "labelDNI";
            labelDNI.Size = new Size(43, 17);
            labelDNI.TabIndex = 47;
            labelDNI.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(325, 258);
            label8.Name = "label8";
            label8.Size = new Size(30, 17);
            label8.TabIndex = 46;
            label8.Text = "DNI";
            // 
            // labelDireccion
            // 
            labelDireccion.AutoSize = true;
            labelDireccion.Location = new Point(416, 295);
            labelDireccion.Name = "labelDireccion";
            labelDireccion.Size = new Size(43, 17);
            labelDireccion.TabIndex = 49;
            labelDireccion.Text = "label9";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(324, 295);
            label10.Name = "label10";
            label10.Size = new Size(62, 17);
            label10.TabIndex = 48;
            label10.Text = "Dirección";
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Location = new Point(673, 141);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(50, 17);
            labelTelefono.TabIndex = 51;
            labelTelefono.Text = "label11";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(581, 141);
            label12.Name = "label12";
            label12.Size = new Size(58, 17);
            label12.TabIndex = 50;
            label12.Text = "Teléfono";
            // 
            // labelFechaInscripcion
            // 
            labelFechaInscripcion.AutoSize = true;
            labelFechaInscripcion.Location = new Point(673, 182);
            labelFechaInscripcion.Name = "labelFechaInscripcion";
            labelFechaInscripcion.Size = new Size(50, 17);
            labelFechaInscripcion.TabIndex = 53;
            labelFechaInscripcion.Text = "label13";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(581, 182);
            label14.Name = "label14";
            label14.Size = new Size(89, 17);
            label14.TabIndex = 52;
            label14.Text = "Fecha de insc.";
            // 
            // labelGenero
            // 
            labelGenero.AutoSize = true;
            labelGenero.Location = new Point(673, 219);
            labelGenero.Name = "labelGenero";
            labelGenero.Size = new Size(50, 17);
            labelGenero.TabIndex = 55;
            labelGenero.Text = "label15";
            // 
            // labelGeneroText
            // 
            labelGeneroText.AutoSize = true;
            labelGeneroText.Location = new Point(581, 219);
            labelGeneroText.Name = "labelGeneroText";
            labelGeneroText.Size = new Size(51, 17);
            labelGeneroText.TabIndex = 54;
            labelGeneroText.Text = "Género";
            // 
            // labelAptoFisico
            // 
            labelAptoFisico.AutoSize = true;
            labelAptoFisico.Location = new Point(673, 258);
            labelAptoFisico.Name = "labelAptoFisico";
            labelAptoFisico.Size = new Size(50, 17);
            labelAptoFisico.TabIndex = 57;
            labelAptoFisico.Text = "label17";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(581, 258);
            label18.Name = "label18";
            label18.Size = new Size(72, 17);
            label18.TabIndex = 56;
            label18.Text = "Apto Físico";
            // 
            // labelSocio
            // 
            labelSocio.AutoSize = true;
            labelSocio.Location = new Point(673, 295);
            labelSocio.Name = "labelSocio";
            labelSocio.Size = new Size(50, 17);
            labelSocio.TabIndex = 59;
            labelSocio.Text = "label19";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(581, 295);
            label20.Name = "label20";
            label20.Size = new Size(52, 17);
            label20.TabIndex = 58;
            label20.Text = "¿Socio?";
            // 
            // buttonCarnetVolver
            // 
            buttonCarnetVolver.BackColor = Color.FromArgb(0, 70, 160);
            buttonCarnetVolver.FlatStyle = FlatStyle.Flat;
            buttonCarnetVolver.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCarnetVolver.ForeColor = Color.White;
            buttonCarnetVolver.Location = new Point(439, 359);
            buttonCarnetVolver.Name = "buttonCarnetVolver";
            buttonCarnetVolver.Size = new Size(200, 32);
            buttonCarnetVolver.TabIndex = 60;
            buttonCarnetVolver.Text = "Volver";
            buttonCarnetVolver.UseVisualStyleBackColor = false;
            buttonCarnetVolver.Click += buttonCarnetVolver_Click;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelID.Location = new Point(159, 359);
            labelID.Name = "labelID";
            labelID.Size = new Size(45, 17);
            labelID.TabIndex = 63;
            labelID.Text = "label2";
            // 
            // labelIDText
            // 
            labelIDText.AutoSize = true;
            labelIDText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelIDText.Location = new Point(67, 359);
            labelIDText.Name = "labelIDText";
            labelIDText.Size = new Size(20, 17);
            labelIDText.TabIndex = 62;
            labelIDText.Text = "Id";
            // 
            // FormCarnet
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelID);
            Controls.Add(labelIDText);
            Controls.Add(buttonCarnetVolver);
            Controls.Add(labelSocio);
            Controls.Add(label20);
            Controls.Add(labelAptoFisico);
            Controls.Add(label18);
            Controls.Add(labelGenero);
            Controls.Add(labelGeneroText);
            Controls.Add(labelFechaInscripcion);
            Controls.Add(label14);
            Controls.Add(labelTelefono);
            Controls.Add(label12);
            Controls.Add(labelDireccion);
            Controls.Add(label10);
            Controls.Add(labelDNI);
            Controls.Add(label8);
            Controls.Add(labelFechaNacimiento);
            Controls.Add(label6);
            Controls.Add(labelApellido);
            Controls.Add(label4);
            Controls.Add(labelNombre);
            Controls.Add(label1);
            Controls.Add(pictureBoxCarnet);
            Controls.Add(labelCarnetTitulo);
            Controls.Add(panelCarnetHeader);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormCarnet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CLUB DEPORTIVO";
            panelCarnetHeader.ResumeLayout(false);
            panelCarnetHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCarnet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelCarnetHeader;
        private Label labelCarnetHeader;
        private Label labelCarnetTitulo;
        private PictureBox pictureBoxCarnet;
        private Label label1;
        private Label labelNombre;
        private Label labelApellido;
        private Label label4;
        private Label labelFechaNacimiento;
        private Label label6;
        private Label labelDNI;
        private Label label8;
        private Label labelDireccion;
        private Label label10;
        private Label labelTelefono;
        private Label label12;
        private Label labelFechaInscripcion;
        private Label label14;
        private Label labelGenero;
        private Label labelGeneroText;
        private Label labelAptoFisico;
        private Label label18;
        private Label labelSocio;
        private Label label20;
        private Button buttonCarnetVolver;
        private Label labelID;
        private Label labelIDText;
    }
}