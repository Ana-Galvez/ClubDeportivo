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
            SuspendLayout();
            // 
            // labelBienvenida
            // 
            labelBienvenida.AutoSize = true;
            labelBienvenida.BackColor = Color.Transparent;
            labelBienvenida.Font = new Font("Segoe UI", 15.75F);
            labelBienvenida.Location = new Point(288, 76);
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
            buttonRegistrarCliente.Location = new Point(276, 153);
            buttonRegistrarCliente.Name = "buttonRegistrarCliente";
            buttonRegistrarCliente.Size = new Size(163, 33);
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
            buttonRegistrarPago.Location = new Point(276, 226);
            buttonRegistrarPago.Name = "buttonRegistrarPago";
            buttonRegistrarPago.Size = new Size(163, 33);
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
            buttonListadoSociosMorosos.Location = new Point(276, 299);
            buttonListadoSociosMorosos.Name = "buttonListadoSociosMorosos";
            buttonListadoSociosMorosos.Size = new Size(163, 33);
            buttonListadoSociosMorosos.TabIndex = 3;
            buttonListadoSociosMorosos.Text = "Listado Socios Morosos";
            buttonListadoSociosMorosos.UseVisualStyleBackColor = false;
            buttonListadoSociosMorosos.Click += buttonListadoSociosMorosos_Click_1;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(733, 450);
            Controls.Add(buttonListadoSociosMorosos);
            Controls.Add(buttonRegistrarPago);
            Controls.Add(buttonRegistrarCliente);
            Controls.Add(labelBienvenida);
            Name = "FormHome";
            Text = "FormHome";
            Load += FormHome_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelBienvenida;
        private Button buttonRegistrarCliente;
        private Button buttonRegistrarPago;
        private Button buttonListadoSociosMorosos;
    }
}