namespace Formularios
{
    partial class frmModificarPaquetes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumSes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregarTratamiento = new System.Windows.Forms.Button();
            this.btnListarTratamientos = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvTratamientos = new System.Windows.Forms.DataGridView();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DURACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNomTratamiento = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTratamientos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 100);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "MODIFICAR PAQUETE";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(435, 487);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(161, 44);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificar.Location = new System.Drawing.Point(79, 487);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(161, 44);
            this.btnModificar.TabIndex = 18;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "S./";
            // 
            // txtNumSes
            // 
            this.txtNumSes.Location = new System.Drawing.Point(237, 428);
            this.txtNumSes.Name = "txtNumSes";
            this.txtNumSes.Size = new System.Drawing.Size(125, 20);
            this.txtNumSes.TabIndex = 16;
            this.txtNumSes.TextChanged += new System.EventHandler(this.txtNumSes_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "N° de Sesiones:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(237, 383);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(125, 20);
            this.txtPrecio.TabIndex = 14;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Precio:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(188, 135);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(417, 20);
            this.txtNombre.TabIndex = 23;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(67, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 21);
            this.label6.TabIndex = 22;
            this.label6.Text = "Nombre:";
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
            this.btnEliminar.Location = new System.Drawing.Point(222, 325);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 27);
            this.btnEliminar.TabIndex = 61;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
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
            this.btnAgregarTratamiento.Location = new System.Drawing.Point(43, 325);
            this.btnAgregarTratamiento.Name = "btnAgregarTratamiento";
            this.btnAgregarTratamiento.Size = new System.Drawing.Size(165, 27);
            this.btnAgregarTratamiento.TabIndex = 60;
            this.btnAgregarTratamiento.Text = "Agregar Tratamiento";
            this.btnAgregarTratamiento.UseVisualStyleBackColor = false;
            this.btnAgregarTratamiento.Click += new System.EventHandler(this.btnAgregarTratamiento_Click);
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
            this.btnListarTratamientos.Location = new System.Drawing.Point(53, 183);
            this.btnListarTratamientos.Name = "btnListarTratamientos";
            this.btnListarTratamientos.Size = new System.Drawing.Size(205, 32);
            this.btnListarTratamientos.TabIndex = 55;
            this.btnListarTratamientos.Text = "Ver Listar Tratamientos";
            this.btnListarTratamientos.UseVisualStyleBackColor = false;
            this.btnListarTratamientos.Click += new System.EventHandler(this.btnListarTratamientos_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(52, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 17);
            this.label11.TabIndex = 57;
            this.label11.Text = "Nombre:";
            // 
            // dgvTratamientos
            // 
            this.dgvTratamientos.AllowUserToAddRows = false;
            this.dgvTratamientos.AllowUserToDeleteRows = false;
            this.dgvTratamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTratamientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOMBRE,
            this.DURACION,
            this.PRECIO});
            this.dgvTratamientos.Location = new System.Drawing.Point(393, 201);
            this.dgvTratamientos.Name = "dgvTratamientos";
            this.dgvTratamientos.ReadOnly = true;
            this.dgvTratamientos.Size = new System.Drawing.Size(342, 177);
            this.dgvTratamientos.TabIndex = 54;
            // 
            // NOMBRE
            // 
            this.NOMBRE.DataPropertyName = "Nombre";
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
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
            this.PRECIO.DataPropertyName = "Precio";
            this.PRECIO.HeaderText = "PRECIO";
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNomTratamiento);
            this.groupBox1.Location = new System.Drawing.Point(28, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 116);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            // 
            // txtNomTratamiento
            // 
            this.txtNomTratamiento.Location = new System.Drawing.Point(95, 57);
            this.txtNomTratamiento.Name = "txtNomTratamiento";
            this.txtNomTratamiento.Size = new System.Drawing.Size(249, 20);
            this.txtNomTratamiento.TabIndex = 50;
            // 
            // frmModificarPaquetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 608);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregarTratamiento);
            this.Controls.Add(this.btnListarTratamientos);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvTratamientos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNumSes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrecio);
            this.Name = "frmModificarPaquetes";
            this.Load += new System.EventHandler(this.frmPaquetesModificar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTratamientos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumSes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregarTratamiento;
        private System.Windows.Forms.Button btnListarTratamientos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvTratamientos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNomTratamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DURACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
    }
}