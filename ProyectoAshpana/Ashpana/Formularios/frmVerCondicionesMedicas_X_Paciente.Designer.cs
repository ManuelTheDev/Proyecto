namespace Formularios
{
    partial class frmVerCondicionesMedicas_X_Paciente
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
            this.dgvCondMedTratamiento = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.NombreCondMedTrat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionCondMedTrat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCondMedTratamiento)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCondMedTratamiento
            // 
            this.dgvCondMedTratamiento.AllowUserToAddRows = false;
            this.dgvCondMedTratamiento.AllowUserToDeleteRows = false;
            this.dgvCondMedTratamiento.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCondMedTratamiento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCondMedTratamiento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCondMedTratamiento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCondMedTratamiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCondMedTratamiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCondMedTrat,
            this.DescripcionCondMedTrat});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCondMedTratamiento.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCondMedTratamiento.EnableHeadersVisualStyles = false;
            this.dgvCondMedTratamiento.Location = new System.Drawing.Point(70, 144);
            this.dgvCondMedTratamiento.Name = "dgvCondMedTratamiento";
            this.dgvCondMedTratamiento.ReadOnly = true;
            this.dgvCondMedTratamiento.Size = new System.Drawing.Size(363, 211);
            this.dgvCondMedTratamiento.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 70);
            this.panel1.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONDICIONES MÉDICAS";
            // 
            // NombreCondMedTrat
            // 
            this.NombreCondMedTrat.DataPropertyName = "Nombre";
            this.NombreCondMedTrat.HeaderText = "NOMBRE";
            this.NombreCondMedTrat.Name = "NombreCondMedTrat";
            this.NombreCondMedTrat.ReadOnly = true;
            // 
            // DescripcionCondMedTrat
            // 
            this.DescripcionCondMedTrat.DataPropertyName = "Descripcion";
            this.DescripcionCondMedTrat.HeaderText = "DESCRIPCIÓN";
            this.DescripcionCondMedTrat.Name = "DescripcionCondMedTrat";
            this.DescripcionCondMedTrat.ReadOnly = true;
            this.DescripcionCondMedTrat.Width = 220;
            // 
            // frmVerCondicionesMedicas_X_Paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 450);
            this.Controls.Add(this.dgvCondMedTratamiento);
            this.Controls.Add(this.panel1);
            this.Name = "frmVerCondicionesMedicas_X_Paciente";
            this.Text = "frmCondicionesMedicas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCondMedTratamiento)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCondMedTratamiento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCondMedTrat;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionCondMedTrat;
    }
}