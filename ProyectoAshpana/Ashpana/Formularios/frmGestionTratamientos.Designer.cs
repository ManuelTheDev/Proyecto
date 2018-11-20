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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnNuevoTratamiento = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtboxBuscarPaquetes = new System.Windows.Forms.TextBox();
            this.dgvTratamientos = new System.Windows.Forms.DataGridView();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DURACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVerCondMed = new System.Windows.Forms.Button();
            this.btnVerZonas = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.button1.Location = new System.Drawing.Point(805, 427);
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
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // txtboxBuscarPaquetes
            // 
            this.txtboxBuscarPaquetes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxBuscarPaquetes.Location = new System.Drawing.Point(285, 165);
            this.txtboxBuscarPaquetes.Name = "txtboxBuscarPaquetes";
            this.txtboxBuscarPaquetes.Size = new System.Drawing.Size(410, 27);
            this.txtboxBuscarPaquetes.TabIndex = 8;
            this.txtboxBuscarPaquetes.TextChanged += new System.EventHandler(this.txtboxBuscarPaquetes_TextChanged);
            // 
            // dgvTratamientos
            // 
            this.dgvTratamientos.AllowUserToAddRows = false;
            this.dgvTratamientos.AllowUserToDeleteRows = false;
            this.dgvTratamientos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTratamientos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTratamientos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTratamientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTratamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTratamientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOMBRE,
            this.DURACION,
            this.PRECIO,
            this.TIPO});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTratamientos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTratamientos.EnableHeadersVisualStyles = false;
            this.dgvTratamientos.GridColor = System.Drawing.SystemColors.Control;
            this.dgvTratamientos.Location = new System.Drawing.Point(188, 247);
            this.dgvTratamientos.Name = "dgvTratamientos";
            this.dgvTratamientos.ReadOnly = true;
            this.dgvTratamientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTratamientos.Size = new System.Drawing.Size(765, 150);
            this.dgvTratamientos.TabIndex = 9;
            // 
            // NOMBRE
            // 
            this.NOMBRE.DataPropertyName = "NombreServicio";
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            this.NOMBRE.Width = 400;
            // 
            // DURACION
            // 
            this.DURACION.DataPropertyName = "DuracionTrat";
            this.DURACION.HeaderText = "DURACION";
            this.DURACION.Name = "DURACION";
            this.DURACION.ReadOnly = true;
            // 
            // PRECIO
            // 
            this.PRECIO.DataPropertyName = "PrecioServicio";
            this.PRECIO.HeaderText = "PRECIO";
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.ReadOnly = true;
            // 
            // TIPO
            // 
            this.TIPO.DataPropertyName = "TipoString";
            this.TIPO.HeaderText = "TIPO";
            this.TIPO.Name = "TIPO";
            this.TIPO.ReadOnly = true;
            this.TIPO.Width = 130;
            // 
            // btnVerCondMed
            // 
            this.btnVerCondMed.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVerCondMed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerCondMed.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerCondMed.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVerCondMed.Location = new System.Drawing.Point(188, 431);
            this.btnVerCondMed.Name = "btnVerCondMed";
            this.btnVerCondMed.Size = new System.Drawing.Size(187, 35);
            this.btnVerCondMed.TabIndex = 10;
            this.btnVerCondMed.Text = "Ver Condiciones Médicas";
            this.btnVerCondMed.UseVisualStyleBackColor = false;
            this.btnVerCondMed.Click += new System.EventHandler(this.btnVerCondMed_Click);
            // 
            // btnVerZonas
            // 
            this.btnVerZonas.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVerZonas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerZonas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerZonas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVerZonas.Location = new System.Drawing.Point(467, 431);
            this.btnVerZonas.Name = "btnVerZonas";
            this.btnVerZonas.Size = new System.Drawing.Size(148, 36);
            this.btnVerZonas.TabIndex = 11;
            this.btnVerZonas.Text = "Ver Zonas a Tratar";
            this.btnVerZonas.UseVisualStyleBackColor = false;
            this.btnVerZonas.Click += new System.EventHandler(this.btnVerZonas_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(184, 168);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(78, 21);
            this.lblBuscar.TabIndex = 22;
            this.lblBuscar.Text = "BUSCAR:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.YellowGreen;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(688, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 42);
            this.label1.TabIndex = 28;
            this.label1.Text = "TRATAMIENTOS";
            // 
            // frmGestionTratamientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 587);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnVerZonas);
            this.Controls.Add(this.btnVerCondMed);
            this.Controls.Add(this.dgvTratamientos);
            this.Controls.Add(this.txtboxBuscarPaquetes);
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
        private System.Windows.Forms.DataGridView dgvTratamientos;
        private System.Windows.Forms.Button btnVerCondMed;
        private System.Windows.Forms.Button btnVerZonas;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DURACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
    }
}