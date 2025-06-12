namespace ClubDeportivo
{
    partial class FormVencimiento
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
            labelTitulo = new Label();
            panelRegistroHeader = new Panel();
            labelRegistroHeader = new Label();
            dgvCuotas = new DataGridView();
            colIDCliente = new DataGridViewTextBoxColumn();
            colApellido = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colDNI = new DataGridViewTextBoxColumn();
            colTelefono = new DataGridViewTextBoxColumn();
            colMonto = new DataGridViewTextBoxColumn();
            colFechaVenc = new DataGridViewTextBoxColumn();
            buttonVencimientosCancelar = new Button();
            panelRegistroHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCuotas).BeginInit();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitulo.ForeColor = Color.Black;
            labelTitulo.Location = new Point(307, 71);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(190, 25);
            labelTitulo.TabIndex = 8;
            labelTitulo.Text = "Listado Vencimientos";
            // 
            // panelRegistroHeader
            // 
            panelRegistroHeader.BackColor = Color.FromArgb(0, 70, 160);
            panelRegistroHeader.Controls.Add(labelRegistroHeader);
            panelRegistroHeader.Location = new Point(1, 0);
            panelRegistroHeader.Name = "panelRegistroHeader";
            panelRegistroHeader.Size = new Size(801, 42);
            panelRegistroHeader.TabIndex = 36;
            // 
            // labelRegistroHeader
            // 
            labelRegistroHeader.AutoSize = true;
            labelRegistroHeader.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRegistroHeader.ForeColor = Color.White;
            labelRegistroHeader.Location = new Point(0, 10);
            labelRegistroHeader.Name = "labelRegistroHeader";
            labelRegistroHeader.Padding = new Padding(10, 0, 0, 0);
            labelRegistroHeader.Size = new Size(181, 25);
            labelRegistroHeader.TabIndex = 0;
            labelRegistroHeader.Text = "CLUB DEPORTIVO";
            labelRegistroHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvCuotas
            // 
            dgvCuotas.AllowUserToAddRows = false;
            dgvCuotas.AllowUserToDeleteRows = false;
            dgvCuotas.BackgroundColor = Color.White;
            dgvCuotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCuotas.Columns.AddRange(new DataGridViewColumn[] { colIDCliente, colApellido, colNombre, colDNI, colTelefono, colMonto, colFechaVenc });
            dgvCuotas.GridColor = Color.Black;
            dgvCuotas.Location = new Point(28, 108);
            dgvCuotas.Name = "dgvCuotas";
            dgvCuotas.ReadOnly = true;
            dgvCuotas.RightToLeft = RightToLeft.No;
            dgvCuotas.Size = new Size(743, 242);
            dgvCuotas.TabIndex = 37;
            // 
            // colIDCliente
            // 
            colIDCliente.HeaderText = "ID Cliente";
            colIDCliente.Name = "colIDCliente";
            colIDCliente.ReadOnly = true;
            // 
            // colApellido
            // 
            colApellido.HeaderText = "Apellido";
            colApellido.Name = "colApellido";
            colApellido.ReadOnly = true;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // colDNI
            // 
            colDNI.HeaderText = "DNI";
            colDNI.Name = "colDNI";
            colDNI.ReadOnly = true;
            // 
            // colTelefono
            // 
            colTelefono.HeaderText = "Teléfono";
            colTelefono.Name = "colTelefono";
            colTelefono.ReadOnly = true;
            // 
            // colMonto
            // 
            colMonto.HeaderText = "Monto";
            colMonto.Name = "colMonto";
            colMonto.ReadOnly = true;
            // 
            // colFechaVenc
            // 
            colFechaVenc.HeaderText = "Vence";
            colFechaVenc.Name = "colFechaVenc";
            colFechaVenc.ReadOnly = true;
            // 
            // buttonVencimientosCancelar
            // 
            buttonVencimientosCancelar.BackColor = Color.FromArgb(128, 0, 70, 160);
            buttonVencimientosCancelar.FlatStyle = FlatStyle.Flat;
            buttonVencimientosCancelar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonVencimientosCancelar.ForeColor = Color.White;
            buttonVencimientosCancelar.Location = new Point(297, 357);
            buttonVencimientosCancelar.Name = "buttonVencimientosCancelar";
            buttonVencimientosCancelar.Size = new Size(200, 28);
            buttonVencimientosCancelar.TabIndex = 38;
            buttonVencimientosCancelar.Text = "Cancelar";
            buttonVencimientosCancelar.UseVisualStyleBackColor = false;
            buttonVencimientosCancelar.Click += buttonVencimientosCancelar_Click;
            // 
            // FormVencimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 397);
            Controls.Add(buttonVencimientosCancelar);
            Controls.Add(dgvCuotas);
            Controls.Add(panelRegistroHeader);
            Controls.Add(labelTitulo);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormVencimiento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CLUB DEPORTIVO";
            Load += FormVencimiento_Load;
            panelRegistroHeader.ResumeLayout(false);
            panelRegistroHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCuotas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private Button buttonVencimientosCancelar;
        private Panel panelRegistroHeader;
        private Label labelRegistroHeader;
        private DataGridView dgvCuotas;
        private DataGridViewTextBoxColumn colIDCliente;
        private DataGridViewTextBoxColumn colApellido;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colDNI;
        private DataGridViewTextBoxColumn colTelefono;
        private DataGridViewTextBoxColumn colMonto;
        private DataGridViewTextBoxColumn colFechaVenc;
    }
}