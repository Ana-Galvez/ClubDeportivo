﻿namespace ClubDeportivo
{
    partial class FormIniciarSesion
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIniciarSesion));
            labelUsuario = new Label();
            labelContrasena = new Label();
            textBoxUsuario = new TextBox();
            textBoxContrasena = new TextBox();
            buttonIngresar = new Button();
            panelHeader = new Panel();
            labelHeader = new Label();
            buttonCancelar = new Button();
            labelInicioBienvenida = new Label();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Location = new Point(232, 169);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(50, 15);
            labelUsuario.TabIndex = 1;
            labelUsuario.Text = "Usuario:";
            // 
            // labelContrasena
            // 
            labelContrasena.AutoSize = true;
            labelContrasena.Location = new Point(232, 209);
            labelContrasena.Name = "labelContrasena";
            labelContrasena.Size = new Size(70, 15);
            labelContrasena.TabIndex = 3;
            labelContrasena.Text = "Contraseña:";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(314, 167);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(200, 23);
            textBoxUsuario.TabIndex = 2;
            // 
            // textBoxContrasena
            // 
            textBoxContrasena.Location = new Point(314, 206);
            textBoxContrasena.Name = "textBoxContrasena";
            textBoxContrasena.PasswordChar = '*';
            textBoxContrasena.Size = new Size(200, 23);
            textBoxContrasena.TabIndex = 4;
            // 
            // buttonIngresar
            // 
            buttonIngresar.BackColor = Color.FromArgb(0, 70, 160);
            buttonIngresar.FlatStyle = FlatStyle.Flat;
            buttonIngresar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            buttonIngresar.ForeColor = Color.White;
            buttonIngresar.Location = new Point(302, 275);
            buttonIngresar.Name = "buttonIngresar";
            buttonIngresar.Size = new Size(200, 31);
            buttonIngresar.TabIndex = 5;
            buttonIngresar.Text = "Ingresar";
            buttonIngresar.UseVisualStyleBackColor = false;
            buttonIngresar.Click += buttonIngresar_Click;
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
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.LightSlateGray;
            buttonCancelar.FlatStyle = FlatStyle.Flat;
            buttonCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            buttonCancelar.ForeColor = Color.White;
            buttonCancelar.Location = new Point(302, 322);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(200, 31);
            buttonCancelar.TabIndex = 6;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // labelInicioBienvenida
            // 
            labelInicioBienvenida.AutoSize = true;
            labelInicioBienvenida.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelInicioBienvenida.Location = new Point(328, 70);
            labelInicioBienvenida.Name = "labelInicioBienvenida";
            labelInicioBienvenida.Size = new Size(133, 30);
            labelInicioBienvenida.TabIndex = 7;
            labelInicioBienvenida.Text = "Iniciar sesión";
            labelInicioBienvenida.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormIniciarSesion
            // 
            AcceptButton = buttonIngresar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            CancelButton = buttonCancelar;
            ClientSize = new Size(800, 397);
            Controls.Add(labelInicioBienvenida);
            Controls.Add(buttonCancelar);
            Controls.Add(panelHeader);
            Controls.Add(buttonIngresar);
            Controls.Add(textBoxContrasena);
            Controls.Add(labelContrasena);
            Controls.Add(textBoxUsuario);
            Controls.Add(labelUsuario);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormIniciarSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CLUB DEPORTIVO";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUsuario;
        private Label labelContrasena;
        private TextBox textBoxUsuario;
        private TextBox textBoxContrasena;
        private Button buttonIngresar;
        private Panel panelHeader;
        private Label labelHeader;
        private Button buttonCancelar;
        private Label labelInicioBienvenida;
    }
}
