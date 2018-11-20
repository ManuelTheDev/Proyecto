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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dgvVerZonasATratarTratamiento.AllowUserToAddRows = false;
            this.dgvVerZonasATratarTratamiento.AllowUserToDeleteRows = false;
            this.dgvVerZonasATratarTratamiento.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvVerZonasATratarTratamiento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVerZonasATratarTratamiento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVerZonasATratarTratamiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerZonasATratarTratamiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreZonaPorTratamiento,
            this.DescripcionZonaPorTratamiento});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVerZonasATratarTratamiento.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVerZonasATratarTratamiento.EnableHeadersVisualStyles = false;
            this.dgvVerZonasATratarTratamiento.Location = new System.Drawing.Point(58, 135);
            this.dgvVerZonasATratarTratamiento.Name = "dgvVerZonasATratarTratamiento";
            this.dgvVerZonasATratarTratamiento.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVerZonasATratarTratamiento.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVerZonasATratarTratamiento.Size = new System.Drawing.Size(363, 211);
            this.dgvVerZonasATratarTratamiento.TabIndex = 29;
            // 
            // NombreZonaPorTratamiento
            // 
            this.NombreZonaPorTratamiento.DataPropertyName = "NombreZona";
            this.NombreZonaPorTratamiento.HeaderText = "Nombre";
            this.NombreZonaPorTratamiento.Name = "NombreZonaPorTratamiento";
            this.NombreZonaPorTratamiento.ReadOnly = true;
            // 
            // DescripcionZonaPorTratamiento
            // 
            this.DescripcionZonaPorTratamiento.DataPropertyName = "DescripicionZona";
            this.DescripcionZonaPorTratamiento.HeaderText = "Descripcion";
            this.DescripcionZonaPorTratamiento.Name = "DescripcionZonaPorTratamiento";
            this.DescripcionZonaPorTratamiento.ReadOnly = true;
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