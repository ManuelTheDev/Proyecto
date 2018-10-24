namespace Formularios
{
    partial class frmGestionFichaMedidas
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevaFicha = new System.Windows.Forms.Button();
            this.lblFicha = new System.Windows.Forms.Label();
            this.CITAS = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.columnasCitas = new System.Windows.Forms.DataGridView();
            this.colServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTerapista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSesion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AbdomenAlto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AbdomenBajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cintura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrazoIzquierdo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrazoDerecho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gluteos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PiernaIzq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PiernaDer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CITAS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.columnasCitas)).BeginInit();
            this.SuspendLayout();
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
            this.btnModificar.Location = new System.Drawing.Point(773, 515);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(167, 45);
            this.btnModificar.TabIndex = 19;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnNuevaFicha
            // 
            this.btnNuevaFicha.BackColor = System.Drawing.Color.Black;
            this.btnNuevaFicha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaFicha.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnNuevaFicha.FlatAppearance.BorderSize = 0;
            this.btnNuevaFicha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaFicha.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaFicha.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnNuevaFicha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaFicha.Location = new System.Drawing.Point(773, 142);
            this.btnNuevaFicha.Name = "btnNuevaFicha";
            this.btnNuevaFicha.Size = new System.Drawing.Size(167, 45);
            this.btnNuevaFicha.TabIndex = 16;
            this.btnNuevaFicha.Text = "+ NUEVA FICHA";
            this.btnNuevaFicha.UseVisualStyleBackColor = false;
            this.btnNuevaFicha.Click += new System.EventHandler(this.btnNuevaFicha_Click);
            // 
            // lblFicha
            // 
            this.lblFicha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFicha.AutoSize = true;
            this.lblFicha.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFicha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFicha.Location = new System.Drawing.Point(657, 30);
            this.lblFicha.Name = "lblFicha";
            this.lblFicha.Size = new System.Drawing.Size(300, 44);
            this.lblFicha.TabIndex = 0;
            this.lblFicha.Text = "FICHA MEDIDAS";
            // 
            // CITAS
            // 
            this.CITAS.BackColor = System.Drawing.Color.YellowGreen;
            this.CITAS.Controls.Add(this.lblFicha);
            this.CITAS.Location = new System.Drawing.Point(-8, -3);
            this.CITAS.Name = "CITAS";
            this.CITAS.Size = new System.Drawing.Size(1201, 98);
            this.CITAS.TabIndex = 20;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(224, 158);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(523, 20);
            this.txtBuscar.TabIndex = 22;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(128, 155);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(65, 21);
            this.lblBuscar.TabIndex = 21;
            this.lblBuscar.Text = "Buscar:";
            // 
            // columnasCitas
            // 
            this.columnasCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.columnasCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colServicio,
            this.colFecha,
            this.colHora,
            this.colTerapista,
            this.colSesion,
            this.AbdomenAlto,
            this.AbdomenBajo,
            this.Cintura,
            this.BrazoIzquierdo,
            this.BrazoDerecho,
            this.Gluteos,
            this.PiernaIzq,
            this.PiernaDer});
            this.columnasCitas.Location = new System.Drawing.Point(129, 227);
            this.columnasCitas.Name = "columnasCitas";
            this.columnasCitas.Size = new System.Drawing.Size(811, 251);
            this.columnasCitas.TabIndex = 17;
            this.columnasCitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.columnasCitas_CellContentClick);
            // 
            // colServicio
            // 
            this.colServicio.FillWeight = 80F;
            this.colServicio.HeaderText = "Servicio";
            this.colServicio.Name = "colServicio";
            this.colServicio.Width = 80;
            // 
            // colFecha
            // 
            this.colFecha.FillWeight = 30F;
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.Width = 50;
            // 
            // colHora
            // 
            this.colHora.FillWeight = 30F;
            this.colHora.HeaderText = "Tipo Somatico";
            this.colHora.Name = "colHora";
            this.colHora.Width = 50;
            // 
            // colTerapista
            // 
            this.colTerapista.FillWeight = 15F;
            this.colTerapista.HeaderText = "Peso";
            this.colTerapista.Name = "colTerapista";
            this.colTerapista.Width = 50;
            // 
            // colSesion
            // 
            this.colSesion.HeaderText = "Espalda";
            this.colSesion.Name = "colSesion";
            this.colSesion.Width = 50;
            // 
            // AbdomenAlto
            // 
            this.AbdomenAlto.HeaderText = "Abdomen Alto";
            this.AbdomenAlto.Name = "AbdomenAlto";
            this.AbdomenAlto.Width = 70;
            // 
            // AbdomenBajo
            // 
            this.AbdomenBajo.HeaderText = "Abdomen Bajto";
            this.AbdomenBajo.Name = "AbdomenBajo";
            this.AbdomenBajo.Width = 70;
            // 
            // Cintura
            // 
            this.Cintura.HeaderText = "Cintura";
            this.Cintura.Name = "Cintura";
            this.Cintura.Width = 50;
            // 
            // BrazoIzquierdo
            // 
            this.BrazoIzquierdo.HeaderText = "Brazo Izquierdo";
            this.BrazoIzquierdo.Name = "BrazoIzquierdo";
            this.BrazoIzquierdo.Width = 60;
            // 
            // BrazoDerecho
            // 
            this.BrazoDerecho.HeaderText = "Brazo Derecho";
            this.BrazoDerecho.Name = "BrazoDerecho";
            this.BrazoDerecho.Width = 60;
            // 
            // Gluteos
            // 
            this.Gluteos.HeaderText = "Gluteos";
            this.Gluteos.Name = "Gluteos";
            this.Gluteos.Width = 55;
            // 
            // PiernaIzq
            // 
            this.PiernaIzq.HeaderText = "Pierna Izquierda";
            this.PiernaIzq.Name = "PiernaIzq";
            this.PiernaIzq.Width = 60;
            // 
            // PiernaDer
            // 
            this.PiernaDer.HeaderText = "Pierna Derecha";
            this.PiernaDer.Name = "PiernaDer";
            this.PiernaDer.Width = 60;
            // 
            // frmGestionFichaMedidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 600);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.columnasCitas);
            this.Controls.Add(this.btnNuevaFicha);
            this.Controls.Add(this.CITAS);
            this.Name = "frmGestionFichaMedidas";
            this.Text = "frmGestionFichaMedidas";
            this.CITAS.ResumeLayout(false);
            this.CITAS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.columnasCitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevaFicha;
        private System.Windows.Forms.Label lblFicha;
        private System.Windows.Forms.Panel CITAS;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.DataGridView columnasCitas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTerapista;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSesion;
        private System.Windows.Forms.DataGridViewTextBoxColumn AbdomenAlto;
        private System.Windows.Forms.DataGridViewTextBoxColumn AbdomenBajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cintura;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrazoIzquierdo;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrazoDerecho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gluteos;
        private System.Windows.Forms.DataGridViewTextBoxColumn PiernaIzq;
        private System.Windows.Forms.DataGridViewTextBoxColumn PiernaDer;
    }
}