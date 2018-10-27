namespace Formularios
{
    partial class frmVerCondicionesMedicasPorTratamiento
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
            this.dgvCondMedTratamiento = new System.Windows.Forms.DataGridView();
            this.NombreCondMedTrat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionCondMedTrat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCondMedTratamiento)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 70);
            this.panel1.TabIndex = 27;
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
            // dgvCondMedTratamiento
            // 
            this.dgvCondMedTratamiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCondMedTratamiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCondMedTrat,
            this.DescripcionCondMedTrat});
            this.dgvCondMedTratamiento.Location = new System.Drawing.Point(53, 130);
            this.dgvCondMedTratamiento.Name = "dgvCondMedTratamiento";
            this.dgvCondMedTratamiento.Size = new System.Drawing.Size(363, 211);
            this.dgvCondMedTratamiento.TabIndex = 28;
            // 
            // NombreCondMedTrat
            // 
            this.NombreCondMedTrat.DataPropertyName = "Nombre";
            this.NombreCondMedTrat.HeaderText = "Nombre";
            this.NombreCondMedTrat.Name = "NombreCondMedTrat";
            // 
            // DescripcionCondMedTrat
            // 
            this.DescripcionCondMedTrat.DataPropertyName = "Descripcion";
            this.DescripcionCondMedTrat.HeaderText = "Descripción";
            this.DescripcionCondMedTrat.Name = "DescripcionCondMedTrat";
            this.DescripcionCondMedTrat.Width = 220;
            // 
            // frmVerCondicionesMedicasPorTratamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 430);
            this.Controls.Add(this.dgvCondMedTratamiento);
            this.Controls.Add(this.panel1);
            this.Name = "frmVerCondicionesMedicasPorTratamiento";
            this.Text = "VerCondicionesMedicasPorTratamiento";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCondMedTratamiento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCondMedTratamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCondMedTrat;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionCondMedTrat;
    }
}