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
            buttonImprimirCarnet = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            panel1 = new Panel();
            panel2 = new Panel();
            panelCarnetHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCarnet).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            label1.Location = new Point(8, 13);
            label1.Name = "label1";
            label1.Size = new Size(57, 17);
            label1.TabIndex = 40;
            label1.Text = "Nombre";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombre.Location = new Point(100, 13);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(43, 17);
            labelNombre.TabIndex = 41;
            labelNombre.Text = "label2";
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            labelApellido.Location = new Point(100, 54);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(43, 17);
            labelApellido.TabIndex = 43;
            labelApellido.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 54);
            label4.Name = "label4";
            label4.Size = new Size(56, 17);
            label4.TabIndex = 42;
            label4.Text = "Apellido";
            // 
            // labelFechaNacimiento
            // 
            labelFechaNacimiento.AutoSize = true;
            labelFechaNacimiento.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            labelFechaNacimiento.Location = new Point(100, 91);
            labelFechaNacimiento.Name = "labelFechaNacimiento";
            labelFechaNacimiento.Size = new Size(43, 17);
            labelFechaNacimiento.TabIndex = 45;
            labelFechaNacimiento.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 91);
            label6.Name = "label6";
            label6.Size = new Size(87, 17);
            label6.TabIndex = 44;
            label6.Text = "Fecha de nac.";
            // 
            // labelDNI
            // 
            labelDNI.AutoSize = true;
            labelDNI.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            labelDNI.Location = new Point(100, 130);
            labelDNI.Name = "labelDNI";
            labelDNI.Size = new Size(43, 17);
            labelDNI.TabIndex = 47;
            labelDNI.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(8, 130);
            label8.Name = "label8";
            label8.Size = new Size(30, 17);
            label8.TabIndex = 46;
            label8.Text = "DNI";
            // 
            // labelDireccion
            // 
            labelDireccion.AutoSize = true;
            labelDireccion.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            labelDireccion.Location = new Point(99, 167);
            labelDireccion.Name = "labelDireccion";
            labelDireccion.Size = new Size(43, 17);
            labelDireccion.TabIndex = 49;
            labelDireccion.Text = "label9";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(7, 167);
            label10.Name = "label10";
            label10.Size = new Size(62, 17);
            label10.TabIndex = 48;
            label10.Text = "Dirección";
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            labelTelefono.Location = new Point(356, 13);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(46, 17);
            labelTelefono.TabIndex = 51;
            labelTelefono.Text = "label11";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(264, 13);
            label12.Name = "label12";
            label12.Size = new Size(58, 17);
            label12.TabIndex = 50;
            label12.Text = "Teléfono";
            // 
            // labelFechaInscripcion
            // 
            labelFechaInscripcion.AutoSize = true;
            labelFechaInscripcion.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            labelFechaInscripcion.Location = new Point(356, 54);
            labelFechaInscripcion.Name = "labelFechaInscripcion";
            labelFechaInscripcion.Size = new Size(48, 17);
            labelFechaInscripcion.TabIndex = 53;
            labelFechaInscripcion.Text = "label13";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(264, 54);
            label14.Name = "label14";
            label14.Size = new Size(89, 17);
            label14.TabIndex = 52;
            label14.Text = "Fecha de insc.";
            // 
            // labelGenero
            // 
            labelGenero.AutoSize = true;
            labelGenero.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            labelGenero.Location = new Point(356, 91);
            labelGenero.Name = "labelGenero";
            labelGenero.Size = new Size(48, 17);
            labelGenero.TabIndex = 55;
            labelGenero.Text = "label15";
            // 
            // labelGeneroText
            // 
            labelGeneroText.AutoSize = true;
            labelGeneroText.Location = new Point(264, 91);
            labelGeneroText.Name = "labelGeneroText";
            labelGeneroText.Size = new Size(51, 17);
            labelGeneroText.TabIndex = 54;
            labelGeneroText.Text = "Género";
            // 
            // labelAptoFisico
            // 
            labelAptoFisico.AutoSize = true;
            labelAptoFisico.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            labelAptoFisico.Location = new Point(356, 130);
            labelAptoFisico.Name = "labelAptoFisico";
            labelAptoFisico.Size = new Size(48, 17);
            labelAptoFisico.TabIndex = 57;
            labelAptoFisico.Text = "label17";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(264, 130);
            label18.Name = "label18";
            label18.Size = new Size(72, 17);
            label18.TabIndex = 56;
            label18.Text = "Apto Físico";
            // 
            // labelSocio
            // 
            labelSocio.AutoSize = true;
            labelSocio.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            labelSocio.Location = new Point(356, 167);
            labelSocio.Name = "labelSocio";
            labelSocio.Size = new Size(48, 17);
            labelSocio.TabIndex = 59;
            labelSocio.Text = "label19";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(264, 167);
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
            buttonCarnetVolver.Location = new Point(517, 359);
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
            labelID.Location = new Point(121, 9);
            labelID.Name = "labelID";
            labelID.Size = new Size(45, 17);
            labelID.TabIndex = 63;
            labelID.Text = "label2";
            // 
            // labelIDText
            // 
            labelIDText.AutoSize = true;
            labelIDText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelIDText.Location = new Point(14, 9);
            labelIDText.Name = "labelIDText";
            labelIDText.Size = new Size(84, 17);
            labelIDText.TabIndex = 62;
            labelIDText.Text = "Id de cliente";
            // 
            // buttonImprimirCarnet
            // 
            buttonImprimirCarnet.BackColor = Color.FromArgb(0, 70, 160);
            buttonImprimirCarnet.FlatStyle = FlatStyle.Flat;
            buttonImprimirCarnet.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonImprimirCarnet.ForeColor = Color.White;
            buttonImprimirCarnet.Location = new Point(298, 359);
            buttonImprimirCarnet.Name = "buttonImprimirCarnet";
            buttonImprimirCarnet.Size = new Size(200, 32);
            buttonImprimirCarnet.TabIndex = 64;
            buttonImprimirCarnet.Text = "Imprimir";
            buttonImprimirCarnet.UseVisualStyleBackColor = false;
            buttonImprimirCarnet.Click += buttonImprimirCarnet_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(labelID);
            panel1.Controls.Add(labelIDText);
            panel1.Location = new Point(52, 354);
            panel1.Name = "panel1";
            panel1.Size = new Size(184, 37);
            panel1.TabIndex = 65;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(labelSocio);
            panel2.Controls.Add(label20);
            panel2.Controls.Add(labelAptoFisico);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(labelGenero);
            panel2.Controls.Add(labelGeneroText);
            panel2.Controls.Add(labelFechaInscripcion);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(labelTelefono);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(labelDireccion);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(labelDNI);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(labelFechaNacimiento);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(labelApellido);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(labelNombre);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(317, 128);
            panel2.Name = "panel2";
            panel2.Size = new Size(456, 203);
            panel2.TabIndex = 66;
            // 
            // FormCarnet
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(buttonImprimirCarnet);
            Controls.Add(buttonCarnetVolver);
            Controls.Add(pictureBoxCarnet);
            Controls.Add(labelCarnetTitulo);
            Controls.Add(panelCarnetHeader);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormCarnet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CLUB DEPORTIVO";
            panelCarnetHeader.ResumeLayout(false);
            panelCarnetHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCarnet).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Button buttonImprimirCarnet;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Panel panel1;
        private Panel panel2;
    }
}