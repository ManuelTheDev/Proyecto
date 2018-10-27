namespace Formularios
{
    partial class frmVerZonasATratarPorTratamiento
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
            this.dgvVerZonasATratarTratamiento = new System.Windows.Forms.DataGridView();
            this.NombreZonaPorTratamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionZonaPorTratamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerZonasATratarTratamiento)).BeginInit();
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
            this.panel1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zonas a Tratar";
            // 
            // dgvVerZonasATratarTratamiento
            // 
            this.dgvVerZonasATratarTratamiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerZonasATratarTratamiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreZonaPorTratamiento,
            this.DescripcionZonaPorTratamiento});
            this.dgvVerZonasATratarTratamiento.Location = new System.Drawing.Point(58, 135);
            this.dgvVerZonasATratarTratamiento.Name = "dgvVerZonasATratarTratamiento";
            this.dgvVerZonasATratarTratamiento.Size = new System.Drawing.Size(363, 211);
            this.dgvVerZonasATratarTratamiento.TabIndex = 29;
            // 
            // NombreZonaPorTratamiento
            // 
            this.NombreZonaPorTratamiento.DataPropertyName = "NombreZona";
            this.NombreZonaPorTratamiento.HeaderText = "Nombre";
            this.NombreZonaPorTratamiento.Name = "NombreZonaPorTratamiento";
            // 
            // DescripcionZonaPorTratamiento
            // 
            this.DescripcionZonaPorTratamiento.DataPropertyName = "DescripcionZona";
            this.DescripcionZonaPorTratamiento.HeaderText = "Descripcion";
            this.DescripcionZonaPorTratamiento.Name = "DescripcionZonaPorTratamiento";
            this.DescripcionZonaPorTratamiento.Width = 220;
            // 
            // frmVerZonasATratarPorTratamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 430);
            this.Controls.Add(this.dgvVerZonasATratarTratamiento);
            this.Controls.Add(this.panel1);
            this.Name = "frmVerZonasATratarPorTratamiento";
            this.Text = "frmVerZonasATratarPorTratamiento";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerZonasATratarTratamiento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvVerZonasATratarTratamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreZonaPorTratamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionZonaPorTratamiento;
    }
}