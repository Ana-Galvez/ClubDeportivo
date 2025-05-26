namespace ClubDeportivo
{
    partial class ModalReciboNoSocio
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
            panelReciboPagoNoSocio = new Panel();
            labelReciboPagoNoSocio = new Label();
            panel1 = new Panel();
            labelReciboNoSocioTitulo = new Label();
            label1 = new Label();
            labelReciboSocioMontoDb = new Label();
            label3 = new Label();
            labelIdPagoSocioDb = new Label();
            label2 = new Label();
            buttonReciboSocioImprimir = new Button();
            labelReciboSocioModoPagoDb = new Label();
            labelModoPagoReciboNoSocio = new Label();
            labelReciboSocioCuotaDb = new Label();
            labelActCont = new Label();
            labelNombreYApellidoSocioDb = new Label();
            labelNombreReciboSocio = new Label();
            panelReciboPagoNoSocio.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelReciboPagoNoSocio
            // 
            panelReciboPagoNoSocio.BackColor = Color.FromArgb(0, 70, 160);
            panelReciboPagoNoSocio.Controls.Add(labelReciboPagoNoSocio);
            panelReciboPagoNoSocio.Location = new Point(2, 2);
            panelReciboPagoNoSocio.Name = "panelReciboPagoNoSocio";
            panelReciboPagoNoSocio.Size = new Size(404, 42);
            panelReciboPagoNoSocio.TabIndex = 70;
            // 
            // labelReciboPagoNoSocio
            // 
            labelReciboPagoNoSocio.AutoSize = true;
            labelReciboPagoNoSocio.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelReciboPagoNoSocio.ForeColor = Color.White;
            labelReciboPagoNoSocio.Location = new Point(0, 8);
            labelReciboPagoNoSocio.Name = "labelReciboPagoNoSocio";
            labelReciboPagoNoSocio.Padding = new Padding(10, 0, 0, 0);
            labelReciboPagoNoSocio.Size = new Size(181, 25);
            labelReciboPagoNoSocio.TabIndex = 0;
            labelReciboPagoNoSocio.Text = "CLUB DEPORTIVO";
            labelReciboPagoNoSocio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(labelReciboNoSocioTitulo);
            panel1.Location = new Point(69, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(287, 28);
            panel1.TabIndex = 84;
            // 
            // labelReciboNoSocioTitulo
            // 
            labelReciboNoSocioTitulo.AutoSize = true;
            labelReciboNoSocioTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelReciboNoSocioTitulo.ForeColor = Color.Black;
            labelReciboNoSocioTitulo.Location = new Point(3, 0);
            labelReciboNoSocioTitulo.Name = "labelReciboNoSocioTitulo";
            labelReciboNoSocioTitulo.Size = new Size(282, 25);
            labelReciboNoSocioTitulo.TabIndex = 60;
            labelReciboNoSocioTitulo.Text = "Comprobante de Pago No Socio";
            labelReciboNoSocioTitulo.Click += labelReciboNoSocioTitulo_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(259, 222);
            label1.Name = "label1";
            label1.Size = new Size(13, 15);
            label1.TabIndex = 100;
            label1.Text = "$";
            // 
            // labelReciboSocioMontoDb
            // 
            labelReciboSocioMontoDb.AutoSize = true;
            labelReciboSocioMontoDb.Location = new Point(271, 222);
            labelReciboSocioMontoDb.Name = "labelReciboSocioMontoDb";
            labelReciboSocioMontoDb.Size = new Size(38, 15);
            labelReciboSocioMontoDb.TabIndex = 99;
            labelReciboSocioMontoDb.Text = "label3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 222);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 98;
            label3.Text = "Monto";
            label3.Click += label3_Click_1;
            // 
            // labelIdPagoSocioDb
            // 
            labelIdPagoSocioDb.AutoSize = true;
            labelIdPagoSocioDb.Location = new Point(259, 137);
            labelIdPagoSocioDb.Name = "labelIdPagoSocioDb";
            labelIdPagoSocioDb.Size = new Size(38, 15);
            labelIdPagoSocioDb.TabIndex = 97;
            labelIdPagoSocioDb.Text = "label2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 137);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 96;
            label2.Text = "ID Cliente";
            label2.Click += label2_Click;
            // 
            // buttonReciboSocioImprimir
            // 
            buttonReciboSocioImprimir.BackColor = Color.FromArgb(0, 70, 160);
            buttonReciboSocioImprimir.FlatStyle = FlatStyle.Flat;
            buttonReciboSocioImprimir.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonReciboSocioImprimir.ForeColor = Color.White;
            buttonReciboSocioImprimir.Location = new Point(101, 301);
            buttonReciboSocioImprimir.Name = "buttonReciboSocioImprimir";
            buttonReciboSocioImprimir.Size = new Size(200, 28);
            buttonReciboSocioImprimir.TabIndex = 93;
            buttonReciboSocioImprimir.Text = "Imprimir";
            buttonReciboSocioImprimir.UseVisualStyleBackColor = false;
            // 
            // labelReciboSocioModoPagoDb
            // 
            labelReciboSocioModoPagoDb.AutoSize = true;
            labelReciboSocioModoPagoDb.Location = new Point(259, 247);
            labelReciboSocioModoPagoDb.Name = "labelReciboSocioModoPagoDb";
            labelReciboSocioModoPagoDb.Size = new Size(38, 15);
            labelReciboSocioModoPagoDb.TabIndex = 90;
            labelReciboSocioModoPagoDb.Text = "label5";
            // 
            // labelModoPagoReciboNoSocio
            // 
            labelModoPagoReciboNoSocio.AutoSize = true;
            labelModoPagoReciboNoSocio.Location = new Point(101, 247);
            labelModoPagoReciboNoSocio.Name = "labelModoPagoReciboNoSocio";
            labelModoPagoReciboNoSocio.Size = new Size(85, 15);
            labelModoPagoReciboNoSocio.TabIndex = 89;
            labelModoPagoReciboNoSocio.Text = "Modo de pago";
            labelModoPagoReciboNoSocio.Click += labelModoPagoReciboNoSocio_Click;
            // 
            // labelReciboSocioCuotaDb
            // 
            labelReciboSocioCuotaDb.AutoSize = true;
            labelReciboSocioCuotaDb.Location = new Point(259, 196);
            labelReciboSocioCuotaDb.Name = "labelReciboSocioCuotaDb";
            labelReciboSocioCuotaDb.Size = new Size(38, 15);
            labelReciboSocioCuotaDb.TabIndex = 88;
            labelReciboSocioCuotaDb.Text = "label3";
            // 
            // labelActCont
            // 
            labelActCont.AutoSize = true;
            labelActCont.Location = new Point(101, 196);
            labelActCont.Name = "labelActCont";
            labelActCont.Size = new Size(119, 15);
            labelActCont.TabIndex = 87;
            labelActCont.Text = "Actividad Contratada";
            labelActCont.Click += labelActCont_Click;
            // 
            // labelNombreYApellidoSocioDb
            // 
            labelNombreYApellidoSocioDb.AutoSize = true;
            labelNombreYApellidoSocioDb.Location = new Point(259, 166);
            labelNombreYApellidoSocioDb.Name = "labelNombreYApellidoSocioDb";
            labelNombreYApellidoSocioDb.Size = new Size(38, 15);
            labelNombreYApellidoSocioDb.TabIndex = 86;
            labelNombreYApellidoSocioDb.Text = "label2";
            // 
            // labelNombreReciboSocio
            // 
            labelNombreReciboSocio.AutoSize = true;
            labelNombreReciboSocio.Location = new Point(101, 166);
            labelNombreReciboSocio.Name = "labelNombreReciboSocio";
            labelNombreReciboSocio.Size = new Size(105, 15);
            labelNombreReciboSocio.TabIndex = 85;
            labelNombreReciboSocio.Text = "Nombre y apellido";
            labelNombreReciboSocio.Click += labelNombreReciboSocio_Click;
            // 
            // ModalReciboNoSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 341);
            Controls.Add(label1);
            Controls.Add(labelReciboSocioMontoDb);
            Controls.Add(label3);
            Controls.Add(labelIdPagoSocioDb);
            Controls.Add(label2);
            Controls.Add(buttonReciboSocioImprimir);
            Controls.Add(labelReciboSocioModoPagoDb);
            Controls.Add(labelModoPagoReciboNoSocio);
            Controls.Add(labelReciboSocioCuotaDb);
            Controls.Add(labelActCont);
            Controls.Add(labelNombreYApellidoSocioDb);
            Controls.Add(labelNombreReciboSocio);
            Controls.Add(panel1);
            Controls.Add(panelReciboPagoNoSocio);
            Name = "ModalReciboNoSocio";
            Text = "ModalReciboNoSocio";
            Load += ModalReciboNoSocio_Load;
            panelReciboPagoNoSocio.ResumeLayout(false);
            panelReciboPagoNoSocio.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelReciboPagoNoSocio;
        private Label labelReciboPagoNoSocio;
        private Panel panel1;
        private Label labelReciboNoSocioTitulo;
        private Label label1;
        private Label labelReciboSocioMontoDb;
        private Label label3;
        private Label labelIdPagoSocioDb;
        private Label label2;
        private Button buttonReciboSocioImprimir;
        private Label labelReciboSocioModoPagoDb;
        private Label labelModoPagoReciboNoSocio;
        private Label labelReciboSocioCuotaDb;
        private Label labelActCont;
        private Label labelNombreYApellidoSocioDb;
        private Label labelNombreReciboSocio;
    }
}