namespace Formularios
{
    partial class frmCitasDelDia
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
            this.CITAS = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.colPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTerapista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSesion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CITAS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // CITAS
            // 
            this.CITAS.BackColor = System.Drawing.Color.YellowGreen;
            this.CITAS.Controls.Add(this.label1);
            this.CITAS.Dock = System.Windows.Forms.DockStyle.Top;
            this.CITAS.Location = new System.Drawing.Point(0, 0);
            this.CITAS.Name = "CITAS";
            this.CITAS.Size = new System.Drawing.Size(1000, 98);
            this.CITAS.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(670, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "CITAS DEL DÍA";
            // 
            // dgvCitas
            // 
            this.dgvCitas.AllowUserToAddRows = false;
            this.dgvCitas.AllowUserToDeleteRows = false;
            this.dgvCitas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCitas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCitas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCitas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPaciente,
            this.colServicio,
            this.colFecha,
            this.colHora,
            this.colTerapista,
            this.colSesion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCitas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCitas.EnableHeadersVisualStyles = false;
            this.dgvCitas.Location = new System.Drawing.Point(168, 187);
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.ReadOnly = true;
            this.dgvCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCitas.Size = new System.Drawing.Size(768, 181);
            this.dgvCitas.TabIndex = 17;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(266, 132);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(670, 20);
            this.txtBuscar.TabIndex = 19;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(164, 132);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(78, 21);
            this.lblBuscar.TabIndex = 18;
            this.lblBuscar.Text = "BUSCAR:";
            // 
            // colPaciente
            // 
            this.colPaciente.DataPropertyName = "NomCliente";
            this.colPaciente.HeaderText = "PACIENTE";
            this.colPaciente.Name = "colPaciente";
            this.colPaciente.ReadOnly = true;
            this.colPaciente.Width = 150;
            // 
            // colServicio
            // 
            this.colServicio.DataPropertyName = "NomServicio";
            this.colServicio.HeaderText = "SERVICIO";
            this.colServicio.Name = "colServicio";
            this.colServicio.ReadOnly = true;
            this.colServicio.Width = 150;
            // 
            // colFecha
            // 
            this.colFecha.DataPropertyName = "fecha";
            this.colFecha.HeaderText = "FECHA";
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            // 
            // colHora
            // 
            this.colHora.DataPropertyName = "Hora";
            this.colHora.HeaderText = "HORA";
            this.colHora.Name = "colHora";
            this.colHora.ReadOnly = true;
            // 
            // colTerapista
            // 
            this.colTerapista.DataPropertyName = "NomTerapista";
            this.colTerapista.HeaderText = "TERAPISTA";
            this.colTerapista.Name = "colTerapista";
            this.colTerapista.ReadOnly = true;
            this.colTerapista.Width = 150;
            // 
            // colSesion
            // 
            this.colSesion.DataPropertyName = "NumDeSesion";
            this.colSesion.HeaderText = "SESION";
            this.colSesion.Name = "colSesion";
            this.colSesion.ReadOnly = true;
            this.colSesion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.colSesion.Width = 80;
            // 
            // frmCitasDelDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.dgvCitas);
            this.Controls.Add(this.CITAS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCitasDelDia";
            this.Text = "frmCitasDelDia";
            this.CITAS.ResumeLayout(false);
            this.CITAS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel CITAS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCitas;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTerapista;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSesion;
    }
}