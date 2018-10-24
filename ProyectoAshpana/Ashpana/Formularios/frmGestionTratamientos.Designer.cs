namespace Formularios
{
    partial class frmGestionTratamientos
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
            this.btnNuevoTratamiento = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtboxBuscarPaquetes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTratamientos = new System.Windows.Forms.DataGridView();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DURACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZONAS_A_TRATAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONDICIONES_MEDICAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTratamientos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevoTratamiento
            // 
            this.btnNuevoTratamiento.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNuevoTratamiento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevoTratamiento.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoTratamiento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoTratamiento.Location = new System.Drawing.Point(710, 156);
            this.btnNuevoTratamiento.Name = "btnNuevoTratamiento";
            this.btnNuevoTratamiento.Size = new System.Drawing.Size(243, 48);
            this.btnNuevoTratamiento.TabIndex = 0;
            this.btnNuevoTratamiento.Text = "+ NUEVO TRATAMIENTO";
            this.btnNuevoTratamiento.UseVisualStyleBackColor = false;
            this.btnNuevoTratamiento.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(805, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "MODIFICAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.YellowGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(-265, -2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(1275, 103);
            this.button3.TabIndex = 6;
            this.button3.Text = "TRATAMIENTOS";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // txtboxBuscarPaquetes
            // 
            this.txtboxBuscarPaquetes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxBuscarPaquetes.Location = new System.Drawing.Point(268, 168);
            this.txtboxBuscarPaquetes.Name = "txtboxBuscarPaquetes";
            this.txtboxBuscarPaquetes.Size = new System.Drawing.Size(410, 27);
            this.txtboxBuscarPaquetes.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Buscar:";
            // 
            // dgvTratamientos
            // 
            this.dgvTratamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTratamientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOMBRE,
            this.DURACION,
            this.PRECIO,
            this.TIPO,
            this.ZONAS_A_TRATAR,
            this.CONDICIONES_MEDICAS});
            this.dgvTratamientos.Location = new System.Drawing.Point(319, 247);
            this.dgvTratamientos.Name = "dgvTratamientos";
            this.dgvTratamientos.Size = new System.Drawing.Size(634, 150);
            this.dgvTratamientos.TabIndex = 9;
            // 
            // NOMBRE
            // 
            this.NOMBRE.DataPropertyName = "NombreTrat";
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            // 
            // DURACION
            // 
            this.DURACION.DataPropertyName = "DuracionTrat";
            this.DURACION.HeaderText = "DURACION";
            this.DURACION.Name = "DURACION";
            // 
            // PRECIO
            // 
            this.PRECIO.DataPropertyName = "PrecioTrat";
            this.PRECIO.HeaderText = "PRECIO";
            this.PRECIO.Name = "PRECIO";
            // 
            // TIPO
            // 
            this.TIPO.DataPropertyName = "TipoString";
            this.TIPO.HeaderText = "TIPO";
            this.TIPO.Name = "TIPO";
            // 
            // ZONAS_A_TRATAR
            // 
            this.ZONAS_A_TRATAR.DataPropertyName = "ZonasTratarString";
            this.ZONAS_A_TRATAR.HeaderText = "ZONAS A TRATAR";
            this.ZONAS_A_TRATAR.Name = "ZONAS_A_TRATAR";
            // 
            // CONDICIONES_MEDICAS
            // 
            this.CONDICIONES_MEDICAS.DataPropertyName = "CondicionesMedicasString";
            this.CONDICIONES_MEDICAS.HeaderText = "CONDICIONES MEDICAS";
            this.CONDICIONES_MEDICAS.Name = "CONDICIONES_MEDICAS";
            // 
            // frmGestionTratamientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 587);
            this.Controls.Add(this.dgvTratamientos);
            this.Controls.Add(this.txtboxBuscarPaquetes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNuevoTratamiento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionTratamientos";
            this.Text = "frmGestionTratamientos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTratamientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button btnNuevoTratamiento;
       // private System.Windows.Forms.BindingSource padecimientosBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
     
        private System.Windows.Forms.TextBox txtboxBuscarPaquetes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTratamientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DURACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZONAS_A_TRATAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONDICIONES_MEDICAS;
    }
}