namespace Formularios
{
    partial class frmModificarDetalleSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarDetalleSesion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregarSesion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvDetalleServicio = new System.Windows.Forms.DataGridView();
            this.NumSesion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Terapista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnListarTerapistas = new System.Windows.Forms.Button();
            this.txtTerapista = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblHora = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTerapista = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboMinuto = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cboHora = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleServicio)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 86);
            this.panel1.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 36);
            this.label4.TabIndex = 22;
            this.label4.Text = "DETALLE SERVICIO";
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
            this.btnEliminar.Location = new System.Drawing.Point(426, 295);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 27);
            this.btnEliminar.TabIndex = 143;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregarSesion
            // 
            this.btnAgregarSesion.BackColor = System.Drawing.Color.Black;
            this.btnAgregarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarSesion.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAgregarSesion.FlatAppearance.BorderSize = 0;
            this.btnAgregarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarSesion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarSesion.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAgregarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarSesion.Location = new System.Drawing.Point(48, 295);
            this.btnAgregarSesion.Name = "btnAgregarSesion";
            this.btnAgregarSesion.Size = new System.Drawing.Size(165, 27);
            this.btnAgregarSesion.TabIndex = 142;
            this.btnAgregarSesion.Text = "Agregar Sesión";
            this.btnAgregarSesion.UseVisualStyleBackColor = false;
            this.btnAgregarSesion.Click += new System.EventHandler(this.btnAgregarSesion_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(135, 681);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 26);
            this.button1.TabIndex = 139;
            this.button1.Text = "CANCELAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(398, 681);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 26);
            this.button2.TabIndex = 138;
            this.button2.Text = "REGISTRAR";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // dgvDetalleServicio
            // 
            this.dgvDetalleServicio.AllowUserToAddRows = false;
            this.dgvDetalleServicio.AllowUserToDeleteRows = false;
            this.dgvDetalleServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleServicio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumSesion,
            this.Terapista,
            this.Fecha,
            this.Hora});
            this.dgvDetalleServicio.Location = new System.Drawing.Point(47, 340);
            this.dgvDetalleServicio.Name = "dgvDetalleServicio";
            this.dgvDetalleServicio.ReadOnly = true;
            this.dgvDetalleServicio.Size = new System.Drawing.Size(529, 150);
            this.dgvDetalleServicio.TabIndex = 137;
            // 
            // NumSesion
            // 
            this.NumSesion.DataPropertyName = "NumDeSesion";
            this.NumSesion.FillWeight = 80F;
            this.NumSesion.HeaderText = "N° Sesión";
            this.NumSesion.Name = "NumSesion";
            this.NumSesion.ReadOnly = true;
            // 
            // Terapista
            // 
            this.Terapista.DataPropertyName = "NombreTerapista";
            this.Terapista.HeaderText = "Terapista";
            this.Terapista.Name = "Terapista";
            this.Terapista.ReadOnly = true;
            this.Terapista.Width = 150;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 150;
            // 
            // Hora
            // 
            this.Hora.DataPropertyName = "Hora";
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
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
            this.btnCancelar.Location = new System.Drawing.Point(113, 520);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(124, 26);
            this.btnCancelar.TabIndex = 154;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Black;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.Location = new System.Drawing.Point(372, 520);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(136, 26);
            this.btnRegistrar.TabIndex = 153;
            this.btnRegistrar.Text = "MODIFICAR";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnListarTerapistas);
            this.groupBox1.Controls.Add(this.txtTerapista);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.lblHora);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblTerapista);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboMinuto);
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Controls.Add(this.cboHora);
            this.groupBox1.Location = new System.Drawing.Point(48, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 167);
            this.groupBox1.TabIndex = 155;
            this.groupBox1.TabStop = false;
            // 
            // btnListarTerapistas
            // 
            this.btnListarTerapistas.BackColor = System.Drawing.Color.Black;
            this.btnListarTerapistas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListarTerapistas.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnListarTerapistas.FlatAppearance.BorderSize = 0;
            this.btnListarTerapistas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarTerapistas.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarTerapistas.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnListarTerapistas.Image = ((System.Drawing.Image)(resources.GetObject("btnListarTerapistas.Image")));
            this.btnListarTerapistas.Location = new System.Drawing.Point(289, 132);
            this.btnListarTerapistas.Name = "btnListarTerapistas";
            this.btnListarTerapistas.Size = new System.Drawing.Size(52, 20);
            this.btnListarTerapistas.TabIndex = 60;
            this.btnListarTerapistas.UseVisualStyleBackColor = false;
            this.btnListarTerapistas.Click += new System.EventHandler(this.btnListarTerapistas_Click_1);
            // 
            // txtTerapista
            // 
            this.txtTerapista.Location = new System.Drawing.Point(133, 132);
            this.txtTerapista.Name = "txtTerapista";
            this.txtTerapista.Size = new System.Drawing.Size(146, 20);
            this.txtTerapista.TabIndex = 136;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(133, 91);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(273, 23);
            this.dtpFecha.TabIndex = 135;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(26, 51);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(47, 17);
            this.lblHora.TabIndex = 133;
            this.lblHora.Text = "Hora: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 21);
            this.label1.TabIndex = 132;
            this.label1.Text = "Detalle Sesion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(285, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 15);
            this.label5.TabIndex = 131;
            this.label5.Text = "m";
            // 
            // lblTerapista
            // 
            this.lblTerapista.AutoSize = true;
            this.lblTerapista.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerapista.Location = new System.Drawing.Point(26, 132);
            this.lblTerapista.Name = "lblTerapista";
            this.lblTerapista.Size = new System.Drawing.Size(73, 17);
            this.lblTerapista.TabIndex = 56;
            this.lblTerapista.Text = "Terapista: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(194, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 15);
            this.label6.TabIndex = 130;
            this.label6.Text = "h";
            // 
            // cboMinuto
            // 
            this.cboMinuto.FormattingEnabled = true;
            this.cboMinuto.Items.AddRange(new object[] {
            "00",
            "30"});
            this.cboMinuto.Location = new System.Drawing.Point(223, 51);
            this.cboMinuto.Name = "cboMinuto";
            this.cboMinuto.Size = new System.Drawing.Size(56, 21);
            this.cboMinuto.TabIndex = 129;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(26, 91);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(55, 17);
            this.lblFecha.TabIndex = 54;
            this.lblFecha.Text = "Fecha: ";
            // 
            // cboHora
            // 
            this.cboHora.FormattingEnabled = true;
            this.cboHora.Items.AddRange(new object[] {
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21"});
            this.cboHora.Location = new System.Drawing.Point(133, 51);
            this.cboHora.Name = "cboHora";
            this.cboHora.Size = new System.Drawing.Size(56, 21);
            this.cboHora.TabIndex = 128;
            // 
            // frmModificarDetalleSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 558);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregarSesion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvDetalleServicio);
            this.Controls.Add(this.panel1);
            this.Name = "frmModificarDetalleSesion";
            this.Text = "frmDetalleSesion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleServicio)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregarSesion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvDetalleServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumSesion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Terapista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnListarTerapistas;
        private System.Windows.Forms.TextBox txtTerapista;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTerapista;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboMinuto;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox cboHora;
    }
}