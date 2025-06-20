﻿namespace ClubDeportivo
{
    partial class ModalPagoSocioONoSocio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModalPagoSocioONoSocio));
            labelModalPagoPregunta = new Label();
            buttonModalPagoNo = new Button();
            buttonModalPagoSi = new Button();
            panelModalPagoHeader = new Panel();
            labelLoginHeader = new Label();
            labelModalPagoTitulo = new Label();
            panelModalPagoHeader.SuspendLayout();
            SuspendLayout();
            // 
            // labelModalPagoPregunta
            // 
            labelModalPagoPregunta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelModalPagoPregunta.AutoSize = true;
            labelModalPagoPregunta.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelModalPagoPregunta.ForeColor = Color.Black;
            labelModalPagoPregunta.Location = new Point(264, 129);
            labelModalPagoPregunta.Name = "labelModalPagoPregunta";
            labelModalPagoPregunta.Size = new Size(97, 25);
            labelModalPagoPregunta.TabIndex = 11;
            labelModalPagoPregunta.Text = "¿Es socio?";
            // 
            // buttonModalPagoNo
            // 
            buttonModalPagoNo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonModalPagoNo.BackColor = Color.FromArgb(0, 70, 160);
            buttonModalPagoNo.FlatStyle = FlatStyle.Flat;
            buttonModalPagoNo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            buttonModalPagoNo.ForeColor = Color.White;
            buttonModalPagoNo.Location = new Point(244, 253);
            buttonModalPagoNo.Name = "buttonModalPagoNo";
            buttonModalPagoNo.Size = new Size(150, 40);
            buttonModalPagoNo.TabIndex = 10;
            buttonModalPagoNo.Text = "No";
            buttonModalPagoNo.UseVisualStyleBackColor = false;
            buttonModalPagoNo.Click += buttonModalPagoNo_Click;
            // 
            // buttonModalPagoSi
            // 
            buttonModalPagoSi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonModalPagoSi.BackColor = Color.FromArgb(0, 70, 160);
            buttonModalPagoSi.FlatStyle = FlatStyle.Flat;
            buttonModalPagoSi.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            buttonModalPagoSi.ForeColor = Color.White;
            buttonModalPagoSi.Location = new Point(244, 171);
            buttonModalPagoSi.Name = "buttonModalPagoSi";
            buttonModalPagoSi.Size = new Size(150, 40);
            buttonModalPagoSi.TabIndex = 9;
            buttonModalPagoSi.Text = "Si";
            buttonModalPagoSi.UseVisualStyleBackColor = false;
            buttonModalPagoSi.Click += buttonModalPagoSi_Click;
            // 
            // panelModalPagoHeader
            // 
            panelModalPagoHeader.BackColor = Color.FromArgb(0, 70, 160);
            panelModalPagoHeader.Controls.Add(labelLoginHeader);
            panelModalPagoHeader.Location = new Point(-2, 0);
            panelModalPagoHeader.Name = "panelModalPagoHeader";
            panelModalPagoHeader.Size = new Size(801, 48);
            panelModalPagoHeader.TabIndex = 8;
            // 
            // labelLoginHeader
            // 
            labelLoginHeader.AutoSize = true;
            labelLoginHeader.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLoginHeader.ForeColor = Color.White;
            labelLoginHeader.Location = new Point(0, 11);
            labelLoginHeader.Name = "labelLoginHeader";
            labelLoginHeader.Padding = new Padding(10, 0, 0, 0);
            labelLoginHeader.Size = new Size(181, 25);
            labelLoginHeader.TabIndex = 0;
            labelLoginHeader.Text = "CLUB DEPORTIVO";
            labelLoginHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelModalPagoTitulo
            // 
            labelModalPagoTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelModalPagoTitulo.AutoSize = true;
            labelModalPagoTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelModalPagoTitulo.ForeColor = Color.Black;
            labelModalPagoTitulo.Location = new Point(251, 69);
            labelModalPagoTitulo.Name = "labelModalPagoTitulo";
            labelModalPagoTitulo.Size = new Size(134, 25);
            labelModalPagoTitulo.TabIndex = 12;
            labelModalPagoTitulo.Text = "Registrar pago";
            // 
            // ModalPagoSocioONoSocio
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(639, 358);
            Controls.Add(labelModalPagoTitulo);
            Controls.Add(labelModalPagoPregunta);
            Controls.Add(buttonModalPagoNo);
            Controls.Add(buttonModalPagoSi);
            Controls.Add(panelModalPagoHeader);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ModalPagoSocioONoSocio";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CLUB DEPORTIVO";
            Load += ModalPagoSocioONoSocio_Load;
            panelModalPagoHeader.ResumeLayout(false);
            panelModalPagoHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelModalPagoPregunta;
        private Button buttonModalPagoNo;
        private Button buttonModalPagoSi;
        private Panel panelModalPagoHeader;
        private Label labelLoginHeader;
        private Label labelModalPagoTitulo;
    }
}