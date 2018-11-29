namespace Formularios
{
    partial class frmGestionPacientes
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apPaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apMaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnModificar = new System.Windows.Forms.Button();
            this.CITAS = new System.Windows.Forms.Panel();
            this.lblClientes = new System.Windows.Forms.Label();
            this.btnVerFichaMedidas = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnVerCondicionMed = new System.Windows.Forms.Button();
            this.personaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnVerServicios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.CITAS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNuevoCliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnNuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoCliente.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNuevoCliente.Location = new System.Drawing.Point(734, 138);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(206, 53);
            this.btnNuevoCliente.TabIndex = 1;
            this.btnNuevoCliente.Text = "+ NUEVO PACIENTE";
            this.btnNuevoCliente.UseVisualStyleBackColor = false;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(205, 157);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(523, 20);
            this.txtBuscar.TabIndex = 3;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AutoGenerateColumns = false;
            this.dgvClientes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.nombresDataGridViewTextBoxColumn,
            this.apPaternoDataGridViewTextBoxColumn,
            this.apMaternoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.fechaNacDataGridViewTextBoxColumn});
            this.dgvClientes.DataSource = this.clienteBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientes.EnableHeadersVisualStyles = false;
            this.dgvClientes.Location = new System.Drawing.Point(104, 203);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(836, 236);
            this.dgvClientes.TabIndex = 4;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Dni";
            this.Column2.HeaderText = "DNI";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // nombresDataGridViewTextBoxColumn
            // 
            this.nombresDataGridViewTextBoxColumn.DataPropertyName = "Nombres";
            this.nombresDataGridViewTextBoxColumn.HeaderText = "NOMBRES";
            this.nombresDataGridViewTextBoxColumn.Name = "nombresDataGridViewTextBoxColumn";
            this.nombresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apPaternoDataGridViewTextBoxColumn
            // 
            this.apPaternoDataGridViewTextBoxColumn.DataPropertyName = "ApPaterno";
            this.apPaternoDataGridViewTextBoxColumn.HeaderText = "APELLIDO PATERNO";
            this.apPaternoDataGridViewTextBoxColumn.Name = "apPaternoDataGridViewTextBoxColumn";
            this.apPaternoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apMaternoDataGridViewTextBoxColumn
            // 
            this.apMaternoDataGridViewTextBoxColumn.DataPropertyName = "ApMaterno";
            this.apMaternoDataGridViewTextBoxColumn.HeaderText = "APELLIDO MATERNO";
            this.apMaternoDataGridViewTextBoxColumn.Name = "apMaternoDataGridViewTextBoxColumn";
            this.apMaternoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "DIRECCIÓN";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "TELÉFONO";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "SEXO";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            this.sexoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "CORREO";
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            this.correoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaNacDataGridViewTextBoxColumn
            // 
            this.fechaNacDataGridViewTextBoxColumn.DataPropertyName = "FechaNac";
            this.fechaNacDataGridViewTextBoxColumn.HeaderText = "FECHA NACIMIENTO";
            this.fechaNacDataGridViewTextBoxColumn.Name = "fechaNacDataGridViewTextBoxColumn";
            this.fechaNacDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(Modelo.Cliente);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModificar.Location = new System.Drawing.Point(783, 499);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(157, 58);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // CITAS
            // 
            this.CITAS.BackColor = System.Drawing.Color.YellowGreen;
            this.CITAS.Controls.Add(this.lblClientes);
            this.CITAS.Location = new System.Drawing.Point(0, 0);
            this.CITAS.Name = "CITAS";
            this.CITAS.Size = new System.Drawing.Size(1271, 102);
            this.CITAS.TabIndex = 21;
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblClientes.Location = new System.Drawing.Point(745, 33);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(207, 44);
            this.lblClientes.TabIndex = 9;
            this.lblClientes.Text = "PACIENTES";
            // 
            // btnVerFichaMedidas
            // 
            this.btnVerFichaMedidas.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVerFichaMedidas.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnVerFichaMedidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerFichaMedidas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerFichaMedidas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVerFichaMedidas.Location = new System.Drawing.Point(567, 499);
            this.btnVerFichaMedidas.Name = "btnVerFichaMedidas";
            this.btnVerFichaMedidas.Size = new System.Drawing.Size(196, 58);
            this.btnVerFichaMedidas.TabIndex = 22;
            this.btnVerFichaMedidas.Text = "VER FICHAS MEDIDAS";
            this.btnVerFichaMedidas.UseVisualStyleBackColor = false;
            this.btnVerFichaMedidas.Click += new System.EventHandler(this.btnVerFichaMedidas_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(121, 154);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(78, 21);
            this.lblBuscar.TabIndex = 23;
            this.lblBuscar.Text = "BUSCAR:";
            // 
            // btnVerCondicionMed
            // 
            this.btnVerCondicionMed.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVerCondicionMed.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnVerCondicionMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerCondicionMed.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerCondicionMed.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVerCondicionMed.Location = new System.Drawing.Point(312, 499);
            this.btnVerCondicionMed.Name = "btnVerCondicionMed";
            this.btnVerCondicionMed.Size = new System.Drawing.Size(231, 58);
            this.btnVerCondicionMed.TabIndex = 24;
            this.btnVerCondicionMed.Text = "VER CONDICIONES MÉDICAS";
            this.btnVerCondicionMed.UseVisualStyleBackColor = false;
            this.btnVerCondicionMed.Click += new System.EventHandler(this.btnVerCondicionMed_Click);
            // 
            // personaBindingSource
            // 
            this.personaBindingSource.DataSource = typeof(Modelo.Persona);
            // 
            // btnVerServicios
            // 
            this.btnVerServicios.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVerServicios.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnVerServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerServicios.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerServicios.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVerServicios.Location = new System.Drawing.Point(104, 499);
            this.btnVerServicios.Name = "btnVerServicios";
            this.btnVerServicios.Size = new System.Drawing.Size(180, 58);
            this.btnVerServicios.TabIndex = 25;
            this.btnVerServicios.Text = "VER SERVICIOS";
            this.btnVerServicios.UseVisualStyleBackColor = false;
            this.btnVerServicios.Click += new System.EventHandler(this.btnVerServicios_Click);
            // 
            // frmGestionPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 758);
            this.Controls.Add(this.btnVerServicios);
            this.Controls.Add(this.btnVerCondicionMed);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnVerFichaMedidas);
            this.Controls.Add(this.CITAS);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnNuevoCliente);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionPacientes";
            this.Text = "frmGestionPacientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.CITAS.ResumeLayout(false);
            this.CITAS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.BindingSource personaBindingSource;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.Panel CITAS;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Button btnVerFichaMedidas;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apPaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apMaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnVerCondicionMed;
        private System.Windows.Forms.Button btnVerServicios;
    }
}