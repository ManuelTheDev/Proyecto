﻿namespace Formularios
{
    partial class frmNuevaCita
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
            this.lblNuevaCita = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnListarTratamientos = new System.Windows.Forms.Button();
            this.btnListarPaquete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTerapista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregarTratamiento = new System.Windows.Forms.Button();
            this.btnEliminarServicio = new System.Windows.Forms.Button();
            this.btnListarPacientes = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.btnAgregarPaquete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNuevaCita
            // 
            this.lblNuevaCita.AutoSize = true;
            this.lblNuevaCita.Location = new System.Drawing.Point(45, 23);
            this.lblNuevaCita.Name = "lblNuevaCita";
            this.lblNuevaCita.Size = new System.Drawing.Size(0, 13);
            this.lblNuevaCita.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(460, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.btnListarTratamientos.Location = new System.Drawing.Point(74, 202);
            this.btnListarTratamientos.Name = "btnListarTratamientos";
            this.btnListarTratamientos.Size = new System.Drawing.Size(205, 32);
            this.btnListarTratamientos.TabIndex = 13;
            this.btnListarTratamientos.Text = "Ver Listar Tratamientos";
            this.btnListarTratamientos.UseVisualStyleBackColor = false;
            this.btnListarTratamientos.Click += new System.EventHandler(this.btnAgregarTratamiento_Click);
            // 
            // btnListarPaquete
            // 
            this.btnListarPaquete.BackColor = System.Drawing.Color.Black;
            this.btnListarPaquete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListarPaquete.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnListarPaquete.FlatAppearance.BorderSize = 0;
            this.btnListarPaquete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarPaquete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarPaquete.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnListarPaquete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListarPaquete.Location = new System.Drawing.Point(73, 252);
            this.btnListarPaquete.Name = "btnListarPaquete";
            this.btnListarPaquete.Size = new System.Drawing.Size(207, 32);
            this.btnListarPaquete.TabIndex = 14;
            this.btnListarPaquete.Text = "Ver Listar Paquetes";
            this.btnListarPaquete.UseVisualStyleBackColor = false;
            this.btnListarPaquete.Click += new System.EventHandler(this.btnAgregarPaquete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(367, 574);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "MONTO TOTAL:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Black;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(447, 626);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(167, 26);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Black;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(74, 626);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(193, 26);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colPrecio,
            this.colTerapista,
            this.colFecha,
            this.colHora});
            this.dataGridView1.Location = new System.Drawing.Point(74, 306);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(540, 228);
            this.dataGridView1.TabIndex = 18;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.Name = "colPrecio";
            // 
            // colTerapista
            // 
            this.colTerapista.HeaderText = "Terapista";
            this.colTerapista.Name = "colTerapista";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(488, 574);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 20);
            this.textBox1.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 36);
            this.label4.TabIndex = 22;
            this.label4.Text = "NUEVA CITA";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 100);
            this.panel1.TabIndex = 23;
            // 
            // btnAgregarTratamiento
            // 
            this.btnAgregarTratamiento.BackColor = System.Drawing.Color.Black;
            this.btnAgregarTratamiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarTratamiento.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAgregarTratamiento.FlatAppearance.BorderSize = 0;
            this.btnAgregarTratamiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTratamiento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTratamiento.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAgregarTratamiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarTratamiento.Location = new System.Drawing.Point(421, 202);
            this.btnAgregarTratamiento.Name = "btnAgregarTratamiento";
            this.btnAgregarTratamiento.Size = new System.Drawing.Size(193, 30);
            this.btnAgregarTratamiento.TabIndex = 31;
            this.btnAgregarTratamiento.Text = "Agregar Tratamiento";
            this.btnAgregarTratamiento.UseVisualStyleBackColor = false;
            this.btnAgregarTratamiento.Click += new System.EventHandler(this.btnAgregarTratamiento_Click_1);
            // 
            // btnEliminarServicio
            // 
            this.btnEliminarServicio.BackColor = System.Drawing.Color.Black;
            this.btnEliminarServicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarServicio.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnEliminarServicio.FlatAppearance.BorderSize = 0;
            this.btnEliminarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarServicio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarServicio.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnEliminarServicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarServicio.Location = new System.Drawing.Point(74, 569);
            this.btnEliminarServicio.Name = "btnEliminarServicio";
            this.btnEliminarServicio.Size = new System.Drawing.Size(193, 30);
            this.btnEliminarServicio.TabIndex = 46;
            this.btnEliminarServicio.Text = "Eliminar Servicio";
            this.btnEliminarServicio.UseVisualStyleBackColor = false;
            // 
            // btnListarPacientes
            // 
            this.btnListarPacientes.BackColor = System.Drawing.Color.Black;
            this.btnListarPacientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListarPacientes.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnListarPacientes.FlatAppearance.BorderSize = 0;
            this.btnListarPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarPacientes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarPacientes.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnListarPacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListarPacientes.Location = new System.Drawing.Point(463, 119);
            this.btnListarPacientes.Name = "btnListarPacientes";
            this.btnListarPacientes.Size = new System.Drawing.Size(151, 52);
            this.btnListarPacientes.TabIndex = 47;
            this.btnListarPacientes.Text = "Ver Listar Pacientes";
            this.btnListarPacientes.UseVisualStyleBackColor = false;
            this.btnListarPacientes.Click += new System.EventHandler(this.btnListarPacientes_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(160, 135);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(296, 20);
            this.textBox2.TabIndex = 48;
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaciente.Location = new System.Drawing.Point(70, 134);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(84, 21);
            this.lblPaciente.TabIndex = 49;
            this.lblPaciente.Text = "Paciente:";
            // 
            // btnAgregarPaquete
            // 
            this.btnAgregarPaquete.BackColor = System.Drawing.Color.Black;
            this.btnAgregarPaquete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarPaquete.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAgregarPaquete.FlatAppearance.BorderSize = 0;
            this.btnAgregarPaquete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPaquete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPaquete.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAgregarPaquete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarPaquete.Location = new System.Drawing.Point(421, 254);
            this.btnAgregarPaquete.Name = "btnAgregarPaquete";
            this.btnAgregarPaquete.Size = new System.Drawing.Size(193, 30);
            this.btnAgregarPaquete.TabIndex = 50;
            this.btnAgregarPaquete.Text = "Agregar Paquete";
            this.btnAgregarPaquete.UseVisualStyleBackColor = false;
            // 
            // frmNuevaCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 688);
            this.Controls.Add(this.btnAgregarPaquete);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnListarPacientes);
            this.Controls.Add(this.btnEliminarServicio);
            this.Controls.Add(this.btnAgregarTratamiento);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnListarPaquete);
            this.Controls.Add(this.btnListarTratamientos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNuevaCita);
            this.Controls.Add(this.panel1);
            this.Name = "frmNuevaCita";
            this.Text = "formularioNuevaCita";
            this.Load += new System.EventHandler(this.frmNuevaCita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNuevaCita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnListarTratamientos;
        private System.Windows.Forms.Button btnListarPaquete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTerapista;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHora;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAgregarTratamiento;
        private System.Windows.Forms.Button btnEliminarServicio;
        private System.Windows.Forms.Button btnListarPacientes;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Button btnAgregarPaquete;
    }
}