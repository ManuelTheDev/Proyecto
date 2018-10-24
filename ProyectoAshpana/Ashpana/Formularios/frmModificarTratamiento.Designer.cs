namespace Formularios
{
    partial class frmModificarTratamiento
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
            this.lblTratamientos = new System.Windows.Forms.Label();
            this.lblPadecimientos = new System.Windows.Forms.Label();
            this.lblNombreTrat = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.lblZonaTratar = new System.Windows.Forms.Label();
            this.lblTipoTratamiento = new System.Windows.Forms.Label();
            this.txtNombreTrat = new System.Windows.Forms.TextBox();
            this.rbtnCorporal = new System.Windows.Forms.RadioButton();
            this.rbtnFacial = new System.Windows.Forms.RadioButton();
            this.chlZonas = new System.Windows.Forms.CheckedListBox();
            this.chlCondMedicas = new System.Windows.Forms.CheckedListBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.lblSoles = new System.Windows.Forms.Label();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 21;
            // 
            // lblTratamientos
            // 
            this.lblTratamientos.AutoSize = true;
            this.lblTratamientos.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTratamientos.Location = new System.Drawing.Point(44, 36);
            this.lblTratamientos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTratamientos.Name = "lblTratamientos";
            this.lblTratamientos.Size = new System.Drawing.Size(373, 36);
            this.lblTratamientos.TabIndex = 19;
            this.lblTratamientos.Text = "MODIFICAR TRATAMIENTO";
            // 
            // lblPadecimientos
            // 
            this.lblPadecimientos.AutoSize = true;
            this.lblPadecimientos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPadecimientos.Location = new System.Drawing.Point(36, 356);
            this.lblPadecimientos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPadecimientos.Name = "lblPadecimientos";
            this.lblPadecimientos.Size = new System.Drawing.Size(180, 21);
            this.lblPadecimientos.TabIndex = 29;
            this.lblPadecimientos.Text = "Condiciones Médicas:";
            // 
            // lblNombreTrat
            // 
            this.lblNombreTrat.AutoSize = true;
            this.lblNombreTrat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTrat.Location = new System.Drawing.Point(36, 145);
            this.lblNombreTrat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreTrat.Name = "lblNombreTrat";
            this.lblNombreTrat.Size = new System.Drawing.Size(206, 21);
            this.lblNombreTrat.TabIndex = 28;
            this.lblNombreTrat.Text = "Nombre del Tratamiento:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(40, 516);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(61, 21);
            this.lblPrecio.TabIndex = 27;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuracion.Location = new System.Drawing.Point(40, 459);
            this.lblDuracion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(85, 21);
            this.lblDuracion.TabIndex = 26;
            this.lblDuracion.Text = "Duración:";
            // 
            // lblZonaTratar
            // 
            this.lblZonaTratar.AutoSize = true;
            this.lblZonaTratar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZonaTratar.Location = new System.Drawing.Point(36, 269);
            this.lblZonaTratar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZonaTratar.Name = "lblZonaTratar";
            this.lblZonaTratar.Size = new System.Drawing.Size(125, 21);
            this.lblZonaTratar.TabIndex = 25;
            this.lblZonaTratar.Text = "Zonas a Tratar:";
            // 
            // lblTipoTratamiento
            // 
            this.lblTipoTratamiento.AutoSize = true;
            this.lblTipoTratamiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoTratamiento.Location = new System.Drawing.Point(36, 211);
            this.lblTipoTratamiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoTratamiento.Name = "lblTipoTratamiento";
            this.lblTipoTratamiento.Size = new System.Drawing.Size(172, 21);
            this.lblTipoTratamiento.TabIndex = 24;
            this.lblTipoTratamiento.Text = "Tipo de Tratamiento:";
            // 
            // txtNombreTrat
            // 
            this.txtNombreTrat.Location = new System.Drawing.Point(271, 148);
            this.txtNombreTrat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreTrat.Name = "txtNombreTrat";
            this.txtNombreTrat.Size = new System.Drawing.Size(387, 20);
            this.txtNombreTrat.TabIndex = 30;
            // 
            // rbtnCorporal
            // 
            this.rbtnCorporal.AutoSize = true;
            this.rbtnCorporal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCorporal.Location = new System.Drawing.Point(401, 215);
            this.rbtnCorporal.Name = "rbtnCorporal";
            this.rbtnCorporal.Size = new System.Drawing.Size(92, 24);
            this.rbtnCorporal.TabIndex = 32;
            this.rbtnCorporal.TabStop = true;
            this.rbtnCorporal.Text = "Corporal";
            this.rbtnCorporal.UseVisualStyleBackColor = true;
            // 
            // rbtnFacial
            // 
            this.rbtnFacial.AutoSize = true;
            this.rbtnFacial.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFacial.Location = new System.Drawing.Point(271, 215);
            this.rbtnFacial.Name = "rbtnFacial";
            this.rbtnFacial.Size = new System.Drawing.Size(70, 24);
            this.rbtnFacial.TabIndex = 31;
            this.rbtnFacial.TabStop = true;
            this.rbtnFacial.Text = "Facial";
            this.rbtnFacial.UseVisualStyleBackColor = true;
            // 
            // chlZonas
            // 
            this.chlZonas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chlZonas.FormattingEnabled = true;
            this.chlZonas.Items.AddRange(new object[] {
            "Abdomen",
            "Cintura",
            "Espalda"});
            this.chlZonas.Location = new System.Drawing.Point(271, 268);
            this.chlZonas.Name = "chlZonas";
            this.chlZonas.Size = new System.Drawing.Size(281, 67);
            this.chlZonas.TabIndex = 33;
            // 
            // chlCondMedicas
            // 
            this.chlCondMedicas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chlCondMedicas.FormattingEnabled = true;
            this.chlCondMedicas.Items.AddRange(new object[] {
            "Gastritis",
            "Rosácea",
            "Obesidad",
            "Embarazo"});
            this.chlCondMedicas.Location = new System.Drawing.Point(271, 370);
            this.chlCondMedicas.Name = "chlCondMedicas";
            this.chlCondMedicas.Size = new System.Drawing.Size(281, 67);
            this.chlCondMedicas.TabIndex = 34;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(324, 517);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(174, 20);
            this.txtPrecio.TabIndex = 36;
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(273, 460);
            this.txtDuracion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(164, 20);
            this.txtDuracion.TabIndex = 35;
            // 
            // lblSoles
            // 
            this.lblSoles.AutoSize = true;
            this.lblSoles.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoles.Location = new System.Drawing.Point(289, 517);
            this.lblSoles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoles.Name = "lblSoles";
            this.lblSoles.Size = new System.Drawing.Size(27, 20);
            this.lblSoles.TabIndex = 38;
            this.lblSoles.Text = "S/.";
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutos.Location = new System.Drawing.Point(472, 463);
            this.lblMinutos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(38, 20);
            this.lblMinutos.TabIndex = 37;
            this.lblMinutos.Text = "min.";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Location = new System.Drawing.Point(413, 634);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(182, 50);
            this.btnCancelar.TabIndex = 40;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegistrar.Location = new System.Drawing.Point(101, 634);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(185, 50);
            this.btnRegistrar.TabIndex = 39;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // frmModificarTratamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 749);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblSoles);
            this.Controls.Add(this.lblMinutos);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.chlCondMedicas);
            this.Controls.Add(this.chlZonas);
            this.Controls.Add(this.rbtnCorporal);
            this.Controls.Add(this.rbtnFacial);
            this.Controls.Add(this.txtNombreTrat);
            this.Controls.Add(this.lblPadecimientos);
            this.Controls.Add(this.lblNombreTrat);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.lblZonaTratar);
            this.Controls.Add(this.lblTipoTratamiento);
            this.Controls.Add(this.panel1);
            this.Name = "frmModificarTratamiento";
            this.Text = "frmModificarTratamiento";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTratamientos;
        private System.Windows.Forms.Label lblPadecimientos;
        private System.Windows.Forms.Label lblNombreTrat;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label lblZonaTratar;
        private System.Windows.Forms.Label lblTipoTratamiento;
        private System.Windows.Forms.TextBox txtNombreTrat;
        private System.Windows.Forms.RadioButton rbtnCorporal;
        private System.Windows.Forms.RadioButton rbtnFacial;
        private System.Windows.Forms.CheckedListBox chlZonas;
        private System.Windows.Forms.CheckedListBox chlCondMedicas;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Label lblSoles;
        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
    }
}