namespace Formularios
{
    partial class frmGestionCitas
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
            this.btnNuevaCita = new System.Windows.Forms.Button();
            this.columnasCitas = new System.Windows.Forms.DataGridView();
            this.colPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTerapista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSesion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModificar = new System.Windows.Forms.Button();
            this.CITAS = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.columnasCitas)).BeginInit();
            this.CITAS.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNuevaCita
            // 
            this.btnNuevaCita.BackColor = System.Drawing.Color.Black;
            this.btnNuevaCita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaCita.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnNuevaCita.FlatAppearance.BorderSize = 0;
            this.btnNuevaCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaCita.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaCita.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnNuevaCita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaCita.Location = new System.Drawing.Point(769, 144);
            this.btnNuevaCita.Name = "btnNuevaCita";
            this.btnNuevaCita.Size = new System.Drawing.Size(167, 45);
            this.btnNuevaCita.TabIndex = 11;
            this.btnNuevaCita.Text = "+ NUEVA CITA";
            this.btnNuevaCita.UseVisualStyleBackColor = false;
            this.btnNuevaCita.Click += new System.EventHandler(this.btnNuevaCita_Click);
            // 
            // columnasCitas
            // 
            this.columnasCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.columnasCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPaciente,
            this.colServicio,
            this.colFecha,
            this.colHora,
            this.colTerapista,
            this.colSesion});
            this.columnasCitas.Location = new System.Drawing.Point(293, 215);
            this.columnasCitas.Name = "columnasCitas";
            this.columnasCitas.Size = new System.Drawing.Size(643, 181);
            this.columnasCitas.TabIndex = 12;
            this.columnasCitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colPaciente
            // 
            this.colPaciente.HeaderText = "Paciente";
            this.colPaciente.Name = "colPaciente";
            // 
            // colServicio
            // 
            this.colServicio.HeaderText = "Servicio";
            this.colServicio.Name = "colServicio";
            // 
            // colFecha
            // 
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name = "colFecha";
            // 
            // colHora
            // 
            this.colHora.HeaderText = "Hora";
            this.colHora.Name = "colHora";
            // 
            // colTerapista
            // 
            this.colTerapista.HeaderText = "Terapista";
            this.colTerapista.Name = "colTerapista";
            // 
            // colSesion
            // 
            this.colSesion.HeaderText = "Sesion";
            this.colSesion.Name = "colSesion";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Black;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(769, 447);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(167, 45);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.button3_Click);
            // 
            // CITAS
            // 
            this.CITAS.BackColor = System.Drawing.Color.YellowGreen;
            this.CITAS.Controls.Add(this.label1);
            this.CITAS.Location = new System.Drawing.Point(0, 0);
            this.CITAS.Name = "CITAS";
            this.CITAS.Size = new System.Drawing.Size(1013, 98);
            this.CITAS.TabIndex = 15;
            this.CITAS.Paint += new System.Windows.Forms.PaintEventHandler(this.CITAS_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(818, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "CITAS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(230, 160);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(523, 20);
            this.txtBuscar.TabIndex = 17;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(146, 160);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(78, 21);
            this.lblBuscar.TabIndex = 16;
            this.lblBuscar.Text = "BUSCAR:";
            // 
            // frmGestionCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 600);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.CITAS);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.columnasCitas);
            this.Controls.Add(this.btnNuevaCita);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionCitas";
            this.Text = "frmGestionCitas";
            this.Load += new System.EventHandler(this.frmGestionCitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.columnasCitas)).EndInit();
            this.CITAS.ResumeLayout(false);
            this.CITAS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNuevaCita;
        private System.Windows.Forms.DataGridView columnasCitas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTerapista;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSesion;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Panel CITAS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
    }
}