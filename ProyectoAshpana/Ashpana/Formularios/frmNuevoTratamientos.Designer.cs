namespace Formularios
{
    partial class frmNuevoTratamientos
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
            this.lblDuracion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.lblSoles = new System.Windows.Forms.Label();
            this.txtNombreTrat = new System.Windows.Forms.TextBox();
            this.lblNombreTrat = new System.Windows.Forms.Label();
            this.lblTratamientos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clbCondMedicas = new System.Windows.Forms.CheckedListBox();
            this.clblZonas = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnCorporal = new System.Windows.Forms.RadioButton();
            this.rbtnFacial = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuracion.Location = new System.Drawing.Point(35, 480);
            this.lblDuracion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(85, 21);
            this.lblDuracion.TabIndex = 5;
            this.lblDuracion.Text = "Duración:";
            this.lblDuracion.Click += new System.EventHandler(this.lblDuracion_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(35, 532);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(61, 21);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio:";
            this.lblPrecio.Click += new System.EventHandler(this.lblPrecio_Click);
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(286, 474);
            this.txtDuracion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(164, 27);
            this.txtDuracion.TabIndex = 11;
            this.txtDuracion.TextChanged += new System.EventHandler(this.txtDuracion_TextChanged);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(337, 529);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(174, 27);
            this.txtPrecio.TabIndex = 12;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegistrar.Location = new System.Drawing.Point(104, 602);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(185, 50);
            this.btnRegistrar.TabIndex = 13;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Location = new System.Drawing.Point(416, 602);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(182, 50);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Location = new System.Drawing.Point(469, 474);
            this.lblMinutos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(42, 21);
            this.lblMinutos.TabIndex = 15;
            this.lblMinutos.Text = "min.";
            this.lblMinutos.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSoles
            // 
            this.lblSoles.AutoSize = true;
            this.lblSoles.Location = new System.Drawing.Point(282, 532);
            this.lblSoles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoles.Name = "lblSoles";
            this.lblSoles.Size = new System.Drawing.Size(29, 21);
            this.lblSoles.TabIndex = 16;
            this.lblSoles.Text = "S/.";
            this.lblSoles.Click += new System.EventHandler(this.lblSoles_Click);
            // 
            // txtNombreTrat
            // 
            this.txtNombreTrat.Location = new System.Drawing.Point(286, 142);
            this.txtNombreTrat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreTrat.Name = "txtNombreTrat";
            this.txtNombreTrat.Size = new System.Drawing.Size(387, 27);
            this.txtNombreTrat.TabIndex = 18;
            this.txtNombreTrat.TextChanged += new System.EventHandler(this.txtNombreTrat_TextChanged);
            // 
            // lblNombreTrat
            // 
            this.lblNombreTrat.AutoSize = true;
            this.lblNombreTrat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTrat.Location = new System.Drawing.Point(31, 145);
            this.lblNombreTrat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreTrat.Name = "lblNombreTrat";
            this.lblNombreTrat.Size = new System.Drawing.Size(206, 21);
            this.lblNombreTrat.TabIndex = 17;
            this.lblNombreTrat.Text = "Nombre del Tratamiento:";
            this.lblNombreTrat.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblTratamientos
            // 
            this.lblTratamientos.AutoSize = true;
            this.lblTratamientos.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTratamientos.Location = new System.Drawing.Point(44, 36);
            this.lblTratamientos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTratamientos.Name = "lblTratamientos";
            this.lblTratamientos.Size = new System.Drawing.Size(311, 36);
            this.lblTratamientos.TabIndex = 19;
            this.lblTratamientos.Text = "NUEVO TRATAMIENTO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Controls.Add(this.lblTratamientos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 100);
            this.panel1.TabIndex = 20;
            // 
            // clbCondMedicas
            // 
            this.clbCondMedicas.CheckOnClick = true;
            this.clbCondMedicas.FormattingEnabled = true;
            this.clbCondMedicas.Location = new System.Drawing.Point(286, 373);
            this.clbCondMedicas.Name = "clbCondMedicas";
            this.clbCondMedicas.Size = new System.Drawing.Size(281, 70);
            this.clbCondMedicas.TabIndex = 32;
            // 
            // clblZonas
            // 
            this.clblZonas.CheckOnClick = true;
            this.clblZonas.FormattingEnabled = true;
            this.clblZonas.Location = new System.Drawing.Point(286, 287);
            this.clblZonas.Name = "clblZonas";
            this.clblZonas.Size = new System.Drawing.Size(281, 70);
            this.clblZonas.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 287);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 21);
            this.label1.TabIndex = 29;
            this.label1.Text = "Zonas a Tratar:";
            // 
            // rbtnCorporal
            // 
            this.rbtnCorporal.AutoSize = true;
            this.rbtnCorporal.Location = new System.Drawing.Point(416, 222);
            this.rbtnCorporal.Name = "rbtnCorporal";
            this.rbtnCorporal.Size = new System.Drawing.Size(96, 25);
            this.rbtnCorporal.TabIndex = 35;
            this.rbtnCorporal.TabStop = true;
            this.rbtnCorporal.Text = "Corporal";
            this.rbtnCorporal.UseVisualStyleBackColor = true;
            this.rbtnCorporal.CheckedChanged += new System.EventHandler(this.rbtnCorporal_CheckedChanged);
            // 
            // rbtnFacial
            // 
            this.rbtnFacial.AutoSize = true;
            this.rbtnFacial.Location = new System.Drawing.Point(286, 222);
            this.rbtnFacial.Name = "rbtnFacial";
            this.rbtnFacial.Size = new System.Drawing.Size(74, 25);
            this.rbtnFacial.TabIndex = 34;
            this.rbtnFacial.TabStop = true;
            this.rbtnFacial.Text = "Facial";
            this.rbtnFacial.UseVisualStyleBackColor = true;
            this.rbtnFacial.CheckedChanged += new System.EventHandler(this.rbtnFacial_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 222);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 21);
            this.label2.TabIndex = 33;
            this.label2.Text = "Tipo de Tratamiento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 373);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 21);
            this.label3.TabIndex = 36;
            this.label3.Text = "Condiciones Médicas:";
            // 
            // frmNuevoTratamientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 727);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbtnCorporal);
            this.Controls.Add(this.rbtnFacial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clbCondMedicas);
            this.Controls.Add(this.clblZonas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtNombreTrat);
            this.Controls.Add(this.lblNombreTrat);
            this.Controls.Add(this.lblSoles);
            this.Controls.Add(this.lblMinutos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblDuracion);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmNuevoTratamientos";
            this.Text = "frmRegistroTratamientos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.Label lblSoles;
        #endregion

        private System.Windows.Forms.TextBox txtNombreTrat;
        private System.Windows.Forms.Label lblNombreTrat;
        private System.Windows.Forms.Label lblTratamientos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox clbCondMedicas;
        private System.Windows.Forms.CheckedListBox clblZonas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnCorporal;
        private System.Windows.Forms.RadioButton rbtnFacial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}