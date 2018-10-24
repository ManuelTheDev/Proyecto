namespace Formularios
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
            this.lblCliente = new System.Windows.Forms.Label();
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
            this.cboDNI = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.idPaquete = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombrePaquete = new System.Windows.Forms.TextBox();
            this.txtPrecioPaquete = new System.Windows.Forms.TextBox();
            this.btnAgregarTratamiento = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbpTerapista = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtNombreTratamiento = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.idTratamiento = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrecioTratamiento = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCantSesiones = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAgregarPaquete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(70, 131);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(43, 21);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "DNI:";
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
            this.label2.Location = new System.Drawing.Point(461, 163);
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
            this.btnListarTratamientos.Location = new System.Drawing.Point(65, 179);
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
            this.btnListarPaquete.Location = new System.Drawing.Point(436, 179);
            this.btnListarPaquete.Name = "btnListarPaquete";
            this.btnListarPaquete.Size = new System.Drawing.Size(167, 32);
            this.btnListarPaquete.TabIndex = 14;
            this.btnListarPaquete.Text = "Ver Listar Paquetes";
            this.btnListarPaquete.UseVisualStyleBackColor = false;
            this.btnListarPaquete.Click += new System.EventHandler(this.btnAgregarPaquete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(354, 631);
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
            this.btnGuardar.Location = new System.Drawing.Point(475, 668);
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
            this.btnCancelar.Location = new System.Drawing.Point(104, 668);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(167, 26);
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
            this.dataGridView1.Location = new System.Drawing.Point(65, 467);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(550, 149);
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
            this.textBox1.Location = new System.Drawing.Point(489, 631);
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
            this.panel1.Size = new System.Drawing.Size(739, 100);
            this.panel1.TabIndex = 23;
            // 
            // cboDNI
            // 
            this.cboDNI.FormattingEnabled = true;
            this.cboDNI.Location = new System.Drawing.Point(139, 131);
            this.cboDNI.Name = "cboDNI";
            this.cboDNI.Size = new System.Drawing.Size(478, 21);
            this.cboDNI.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(436, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "IdPaquete:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // idPaquete
            // 
            this.idPaquete.Location = new System.Drawing.Point(516, 236);
            this.idPaquete.Name = "idPaquete";
            this.idPaquete.Size = new System.Drawing.Size(64, 20);
            this.idPaquete.TabIndex = 26;
            this.idPaquete.TextChanged += new System.EventHandler(this.idPaquete_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(433, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Nombre:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtNombrePaquete
            // 
            this.txtNombrePaquete.Location = new System.Drawing.Point(516, 269);
            this.txtNombrePaquete.Name = "txtNombrePaquete";
            this.txtNombrePaquete.Size = new System.Drawing.Size(169, 20);
            this.txtNombrePaquete.TabIndex = 28;
            this.txtNombrePaquete.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtPrecioPaquete
            // 
            this.txtPrecioPaquete.Location = new System.Drawing.Point(106, 113);
            this.txtPrecioPaquete.Name = "txtPrecioPaquete";
            this.txtPrecioPaquete.Size = new System.Drawing.Size(64, 20);
            this.txtPrecioPaquete.TabIndex = 30;
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
            this.btnAgregarTratamiento.Location = new System.Drawing.Point(103, 420);
            this.btnAgregarTratamiento.Name = "btnAgregarTratamiento";
            this.btnAgregarTratamiento.Size = new System.Drawing.Size(193, 30);
            this.btnAgregarTratamiento.TabIndex = 31;
            this.btnAgregarTratamiento.Text = "Agregar Tratamiento";
            this.btnAgregarTratamiento.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 32;
            this.label8.Text = "Terapista:";
            // 
            // cbpTerapista
            // 
            this.cbpTerapista.FormattingEnabled = true;
            this.cbpTerapista.Location = new System.Drawing.Point(105, 152);
            this.cbpTerapista.Name = "cbpTerapista";
            this.cbpTerapista.Size = new System.Drawing.Size(174, 21);
            this.cbpTerapista.TabIndex = 33;
            this.cbpTerapista.SelectedIndexChanged += new System.EventHandler(this.cbpTerapista_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 17);
            this.label9.TabIndex = 34;
            this.label9.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(105, 190);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(253, 20);
            this.dtpFecha.TabIndex = 35;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtNombreTratamiento
            // 
            this.txtNombreTratamiento.Location = new System.Drawing.Point(133, 266);
            this.txtNombreTratamiento.Name = "txtNombreTratamiento";
            this.txtNombreTratamiento.Size = new System.Drawing.Size(195, 20);
            this.txtNombreTratamiento.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(53, 269);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 17);
            this.label11.TabIndex = 38;
            this.label11.Text = "Nombre:";
            // 
            // idTratamiento
            // 
            this.idTratamiento.Location = new System.Drawing.Point(133, 46);
            this.idTratamiento.Name = "idTratamiento";
            this.idTratamiento.Size = new System.Drawing.Size(64, 20);
            this.idTratamiento.TabIndex = 37;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(53, 236);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 17);
            this.label12.TabIndex = 36;
            this.label12.Text = "IdTratamiento:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 17);
            this.label10.TabIndex = 40;
            this.label10.Text = "Precio:";
            // 
            // txtPrecioTratamiento
            // 
            this.txtPrecioTratamiento.Location = new System.Drawing.Point(133, 304);
            this.txtPrecioTratamiento.Name = "txtPrecioTratamiento";
            this.txtPrecioTratamiento.Size = new System.Drawing.Size(64, 20);
            this.txtPrecioTratamiento.TabIndex = 43;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(53, 304);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 17);
            this.label13.TabIndex = 42;
            this.label13.Text = "Precio:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCantSesiones);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtPrecioPaquete);
            this.groupBox1.Location = new System.Drawing.Point(422, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 182);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 17);
            this.label7.TabIndex = 42;
            this.label7.Text = "Cantidad Sesiones:";
            // 
            // txtCantSesiones
            // 
            this.txtCantSesiones.Location = new System.Drawing.Point(160, 151);
            this.txtCantSesiones.Name = "txtCantSesiones";
            this.txtCantSesiones.Size = new System.Drawing.Size(64, 20);
            this.txtCantSesiones.TabIndex = 41;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.idTratamiento);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbpTerapista);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dtpFecha);
            this.groupBox2.Location = new System.Drawing.Point(28, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 224);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
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
            this.btnAgregarPaquete.Location = new System.Drawing.Point(464, 420);
            this.btnAgregarPaquete.Name = "btnAgregarPaquete";
            this.btnAgregarPaquete.Size = new System.Drawing.Size(193, 29);
            this.btnAgregarPaquete.TabIndex = 47;
            this.btnAgregarPaquete.Text = "Agregar Paquete";
            this.btnAgregarPaquete.UseVisualStyleBackColor = false;
            // 
            // frmNuevaCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 706);
            this.Controls.Add(this.btnAgregarPaquete);
            this.Controls.Add(this.txtPrecioTratamiento);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtNombreTratamiento);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnAgregarTratamiento);
            this.Controls.Add(this.txtNombrePaquete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.idPaquete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboDNI);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnListarPaquete);
            this.Controls.Add(this.btnListarTratamientos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblNuevaCita);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmNuevaCita";
            this.Text = "formularioNuevaCita";
            this.Load += new System.EventHandler(this.frmNuevaCita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNuevaCita;
        private System.Windows.Forms.Label lblCliente;
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
        private System.Windows.Forms.ComboBox cboDNI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idPaquete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombrePaquete;
        private System.Windows.Forms.TextBox txtPrecioPaquete;
        private System.Windows.Forms.Button btnAgregarTratamiento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbpTerapista;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtNombreTratamiento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox idTratamiento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPrecioTratamiento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAgregarPaquete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCantSesiones;
    }
}