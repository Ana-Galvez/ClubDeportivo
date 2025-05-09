namespace ClubDeportivo
{
    partial class FormPantallaInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelHeader = new Panel();
            labelHeader = new Label();
            labelInicioBienvenida = new Label();
            buttonInicio = new Button();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 70, 160);
            panelHeader.Controls.Add(labelHeader);
            panelHeader.ForeColor = Color.FromArgb(0, 70, 160);
            panelHeader.Location = new Point(1, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(798, 53);
            panelHeader.TabIndex = 0;
            // 
            // labelHeader
            // 
            labelHeader.AutoSize = true;
            labelHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHeader.ForeColor = Color.White;
            labelHeader.Location = new Point(11, 18);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(144, 21);
            labelHeader.TabIndex = 0;
            labelHeader.Text = "CLUB DEPORTIVO";
            labelHeader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelInicioBienvenida
            // 
            labelInicioBienvenida.AutoSize = true;
            labelInicioBienvenida.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelInicioBienvenida.Location = new Point(327, 148);
            labelInicioBienvenida.Name = "labelInicioBienvenida";
            labelInicioBienvenida.Size = new Size(146, 30);
            labelInicioBienvenida.TabIndex = 1;
            labelInicioBienvenida.Text = "¡Bienvenido/a!";
            labelInicioBienvenida.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonInicio
            // 
            buttonInicio.BackColor = Color.FromArgb(0, 70, 160);
            buttonInicio.FlatStyle = FlatStyle.Flat;
            buttonInicio.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonInicio.ForeColor = Color.White;
            buttonInicio.Location = new Point(327, 224);
            buttonInicio.Name = "buttonInicio";
            buttonInicio.Size = new Size(150, 35);
            buttonInicio.TabIndex = 2;
            buttonInicio.Text = "Iniciar sesión";
            buttonInicio.UseVisualStyleBackColor = false;
            buttonInicio.Click += buttonInicio_Click;
            // 
            // FormPantallaInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(800, 397);
            Controls.Add(buttonInicio);
            Controls.Add(labelInicioBienvenida);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormPantallaInicio";
            Padding = new Padding(10, 0, 0, 0);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CLUB DEPORTIVO";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelHeader;
        private Label labelHeader;
        private Label labelInicioBienvenida;
        private Button buttonInicio;
    }
}
