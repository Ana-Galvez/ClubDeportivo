namespace ClubDeportivo
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            labelBienvenida = new Label();
            buttonRegistrarCliente = new Button();
            buttonRegistrarPago = new Button();
            buttonListadoSociosMorosos = new Button();
            panelHeader = new Panel();
            buttonSalir = new Button();
            labelHeader = new Label();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // labelBienvenida
            // 
            labelBienvenida.AutoSize = true;
            labelBienvenida.BackColor = Color.Transparent;
            labelBienvenida.Font = new Font("Segoe UI", 15.75F);
            labelBienvenida.Location = new Point(319, 109);
            labelBienvenida.Name = "labelBienvenida";
            labelBienvenida.Size = new Size(146, 30);
            labelBienvenida.TabIndex = 0;
            labelBienvenida.Text = "¡Bienvenido/a!";
            labelBienvenida.Click += labelBienvenida_Click;
            // 
            // buttonRegistrarCliente
            // 
            buttonRegistrarCliente.BackColor = Color.FromArgb(0, 70, 160);
            buttonRegistrarCliente.FlatStyle = FlatStyle.Flat;
            buttonRegistrarCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            buttonRegistrarCliente.ForeColor = Color.White;
            buttonRegistrarCliente.Location = new Point(319, 197);
            buttonRegistrarCliente.Name = "buttonRegistrarCliente";
            buttonRegistrarCliente.Size = new Size(163, 37);
            buttonRegistrarCliente.TabIndex = 1;
            buttonRegistrarCliente.Text = "Registrar Cliente";
            buttonRegistrarCliente.UseVisualStyleBackColor = false;
            buttonRegistrarCliente.Click += buttonRegistrarCliente_Click;
            // 
            // buttonRegistrarPago
            // 
            buttonRegistrarPago.BackColor = Color.FromArgb(0, 70, 160);
            buttonRegistrarPago.FlatStyle = FlatStyle.Flat;
            buttonRegistrarPago.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            buttonRegistrarPago.ForeColor = Color.White;
            buttonRegistrarPago.Location = new Point(319, 280);
            buttonRegistrarPago.Name = "buttonRegistrarPago";
            buttonRegistrarPago.Size = new Size(163, 37);
            buttonRegistrarPago.TabIndex = 2;
            buttonRegistrarPago.Text = "Registrar Pago";
            buttonRegistrarPago.UseVisualStyleBackColor = false;
            buttonRegistrarPago.Click += buttonRegistrarPago_Click;
            // 
            // buttonListadoSociosMorosos
            // 
            buttonListadoSociosMorosos.BackColor = Color.FromArgb(0, 70, 160);
            buttonListadoSociosMorosos.FlatStyle = FlatStyle.Flat;
            buttonListadoSociosMorosos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            buttonListadoSociosMorosos.ForeColor = Color.White;
            buttonListadoSociosMorosos.Location = new Point(319, 363);
            buttonListadoSociosMorosos.Name = "buttonListadoSociosMorosos";
            buttonListadoSociosMorosos.Size = new Size(163, 37);
            buttonListadoSociosMorosos.TabIndex = 3;
            buttonListadoSociosMorosos.Text = "Listado Vencimientos";
            buttonListadoSociosMorosos.UseVisualStyleBackColor = false;
            buttonListadoSociosMorosos.Click += buttonListadoSociosMorosos_Click_1;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 70, 160);
            panelHeader.Controls.Add(buttonSalir);
            panelHeader.Controls.Add(labelHeader);
            panelHeader.ForeColor = Color.FromArgb(0, 70, 160);
            panelHeader.Location = new Point(1, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(798, 60);
            panelHeader.TabIndex = 4;
            // 
            // buttonSalir
            // 
            buttonSalir.Location = new Point(692, 18);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(95, 26);
            buttonSalir.TabIndex = 1;
            buttonSalir.Text = "Cerrar Sesión";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // labelHeader
            // 
            labelHeader.AutoSize = true;
            labelHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHeader.ForeColor = Color.White;
            labelHeader.Location = new Point(11, 20);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(144, 21);
            labelHeader.TabIndex = 0;
            labelHeader.Text = "CLUB DEPORTIVO";
            labelHeader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(panelHeader);
            Controls.Add(buttonListadoSociosMorosos);
            Controls.Add(buttonRegistrarPago);
            Controls.Add(buttonRegistrarCliente);
            Controls.Add(labelBienvenida);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CLUB DEPORTIVO";
            Load += FormHome_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelBienvenida;
        private Button buttonRegistrarCliente;
        private Button buttonRegistrarPago;
        private Button buttonListadoSociosMorosos;
        private Panel panelHeader;
        private Label labelHeader;
        private Button buttonSalir;
    }
}