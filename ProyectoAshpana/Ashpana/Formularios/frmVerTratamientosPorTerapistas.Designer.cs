namespace Formularios
{
    partial class frmVerTratamientosPorTerapistas
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
            this.txtNombreTerapista = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CITAS = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.btnListarTratamientos = new System.Windows.Forms.Button();
            this.txtIdTratamiento = new System.Windows.Forms.TextBox();
            this.dgvTratamientos = new System.Windows.Forms.DataGridView();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DURACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNomTratamiento = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregarTratamiento = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CITAS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTratamientos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombreTerapista
            // 
            this.txtNombreTerapista.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombreTerapista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreTerapista.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreTerapista.Location = new System.Drawing.Point(178, 170);
            this.txtNombreTerapista.Name = "txtNombreTerapista";
            this.txtNombreTerapista.Size = new System.Drawing.Size(264, 16);
            this.txtNombreTerapista.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(398, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tratamientos Habilitados";
            // 
            // CITAS
            // 
            this.CITAS.BackColor = System.Drawing.Color.YellowGreen;
            this.CITAS.Controls.Add(this.label1);
            this.CITAS.Dock = System.Windows.Forms.DockStyle.Top;
            this.CITAS.Location = new System.Drawing.Point(0, 0);
            this.CITAS.Name = "CITAS";
            this.CITAS.Size = new System.Drawing.Size(867, 87);
            this.CITAS.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(107, 285);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 17);
            this.label12.TabIndex = 58;
            this.label12.Text = "IdTratamiento:";
            // 
            // btnListarTratamientos
            // 
            this.btnListarTratamientos.BackColor = System.Drawing.Color.Black;
            this.btnListarTratamientos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListarTratamientos.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnListarTratamientos.FlatAppearance.BorderSize = 0;
            this.btnListarTratamientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarTratamientos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarTratamientos.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnListarTratamientos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListarTratamientos.Location = new System.Drawing.Point(108, 226);
            this.btnListarTratamientos.Name = "btnListarTratamientos";
            this.btnListarTratamientos.Size = new System.Drawing.Size(205, 32);
            this.btnListarTratamientos.TabIndex = 57;
            this.btnListarTratamientos.Text = "Ver Listar Tratamientos";
            this.btnListarTratamientos.UseVisualStyleBackColor = false;
            this.btnListarTratamientos.Click += new System.EventHandler(this.btnListarTratamientos_Click);
            // 
            // txtIdTratamiento
            // 
            this.txtIdTratamiento.Location = new System.Drawing.Point(232, 282);
            this.txtIdTratamiento.Name = "txtIdTratamiento";
            this.txtIdTratamiento.Size = new System.Drawing.Size(46, 20);
            this.txtIdTratamiento.TabIndex = 60;
            // 
            // dgvTratamientos
            // 
            this.dgvTratamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTratamientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOMBRE,
            this.DURACION,
            this.PRECIO});
            this.dgvTratamientos.Location = new System.Drawing.Point(473, 236);
            this.dgvTratamientos.Name = "dgvTratamientos";
            this.dgvTratamientos.Size = new System.Drawing.Size(342, 177);
            this.dgvTratamientos.TabIndex = 56;
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
            // txtNomTratamiento
            // 
            this.txtNomTratamiento.Location = new System.Drawing.Point(95, 79);
            this.txtNomTratamiento.Name = "txtNomTratamiento";
            this.txtNomTratamiento.Size = new System.Drawing.Size(249, 20);
            this.txtNomTratamiento.TabIndex = 50;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Black;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(277, 368);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 27);
            this.btnEliminar.TabIndex = 63;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregarTratamiento
            // 
            this.btnAgregarTratamiento.BackColor = System.Drawing.Color.Black;
            this.btnAgregarTratamiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarTratamiento.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAgregarTratamiento.FlatAppearance.BorderSize = 0;
            this.btnAgregarTratamiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTratamiento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTratamiento.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAgregarTratamiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarTratamiento.Location = new System.Drawing.Point(98, 368);
            this.btnAgregarTratamiento.Name = "btnAgregarTratamiento";
            this.btnAgregarTratamiento.Size = new System.Drawing.Size(165, 27);
            this.btnAgregarTratamiento.TabIndex = 62;
            this.btnAgregarTratamiento.Text = "Agregar Tratamiento";
            this.btnAgregarTratamiento.UseVisualStyleBackColor = false;
            this.btnAgregarTratamiento.Click += new System.EventHandler(this.btnAgregarTratamiento_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(107, 316);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 17);
            this.label11.TabIndex = 59;
            this.label11.Text = "Nombre:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Location = new System.Drawing.Point(473, 511);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(161, 44);
            this.btnCancelar.TabIndex = 55;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegistrar.Location = new System.Drawing.Point(166, 511);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(161, 44);
            this.btnRegistrar.TabIndex = 54;
            this.btnRegistrar.Text = "GUARDAR";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNomTratamiento);
            this.groupBox1.Location = new System.Drawing.Point(83, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 116);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 64;
            this.label2.Text = "Nombre: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 65;
            this.label3.Text = "Terapista: ";
            // 
            // frmVerTratamientosPorTerapistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 634);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CITAS);
            this.Controls.Add(this.btnListarTratamientos);
            this.Controls.Add(this.txtNombreTerapista);
            this.Controls.Add(this.txtIdTratamiento);
            this.Controls.Add(this.dgvTratamientos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnAgregarTratamiento);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label11);
            this.Name = "frmVerTratamientosPorTerapistas";
            this.Text = "frmVerTratamientosPorTerapistascs";
            this.CITAS.ResumeLayout(false);
            this.CITAS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTratamientos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombreTerapista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel CITAS;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnListarTratamientos;
        private System.Windows.Forms.TextBox txtIdTratamiento;
        private System.Windows.Forms.DataGridView dgvTratamientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DURACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.TextBox txtNomTratamiento;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregarTratamiento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}