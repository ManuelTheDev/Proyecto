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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblNombreServicio = new System.Windows.Forms.Label();
            this.txtNombreServicio = new System.Windows.Forms.TextBox();
            this.lblNumSesion = new System.Windows.Forms.Label();
            this.txtNumSesiones = new System.Windows.Forms.TextBox();
            this.lblNombreTerapista = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreTerapista = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnListarTerapistas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpSesion = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboMinuto = new System.Windows.Forms.ComboBox();
            this.cboHora = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 100);
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
            this.btnRegistrar.Location = new System.Drawing.Point(297, 384);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(136, 26);
            this.btnRegistrar.TabIndex = 31;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblNombreServicio
            // 
            this.lblNombreServicio.AutoSize = true;
            this.lblNombreServicio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreServicio.Location = new System.Drawing.Point(44, 131);
            this.lblNombreServicio.Name = "lblNombreServicio";
            this.lblNombreServicio.Size = new System.Drawing.Size(142, 17);
            this.lblNombreServicio.TabIndex = 33;
            this.lblNombreServicio.Text = "Nombre del Servicio:";
            // 
            // txtNombreServicio
            // 
            this.txtNombreServicio.Location = new System.Drawing.Point(192, 130);
            this.txtNombreServicio.Name = "txtNombreServicio";
            this.txtNombreServicio.Size = new System.Drawing.Size(231, 20);
            this.txtNombreServicio.TabIndex = 34;
            // 
            // lblNumSesion
            // 
            this.lblNumSesion.AutoSize = true;
            this.lblNumSesion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumSesion.Location = new System.Drawing.Point(44, 172);
            this.lblNumSesion.Name = "lblNumSesion";
            this.lblNumSesion.Size = new System.Drawing.Size(94, 17);
            this.lblNumSesion.TabIndex = 35;
            this.lblNumSesion.Text = "N° de sesión: ";
            // 
            // txtNumSesiones
            // 
            this.txtNumSesiones.Location = new System.Drawing.Point(192, 172);
            this.txtNumSesiones.Name = "txtNumSesiones";
            this.txtNumSesiones.Size = new System.Drawing.Size(231, 20);
            this.txtNumSesiones.TabIndex = 36;
            // 
            // lblNombreTerapista
            // 
            this.lblNombreTerapista.AutoSize = true;
            this.lblNombreTerapista.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTerapista.Location = new System.Drawing.Point(44, 212);
            this.lblNombreTerapista.Name = "lblNombreTerapista";
            this.lblNombreTerapista.Size = new System.Drawing.Size(69, 17);
            this.lblNombreTerapista.TabIndex = 37;
            this.lblNombreTerapista.Text = "Terapista:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Fecha: ";
            // 
            // txtNombreTerapista
            // 
            this.txtNombreTerapista.Location = new System.Drawing.Point(192, 212);
            this.txtNombreTerapista.Name = "txtNombreTerapista";
            this.txtNombreTerapista.Size = new System.Drawing.Size(231, 20);
            this.txtNombreTerapista.TabIndex = 39;
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
            this.btnCancelar.Location = new System.Drawing.Point(100, 384);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(124, 26);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnListarTerapistas
            // 
            this.btnListarTerapistas.BackColor = System.Drawing.Color.Black;
            this.btnListarTerapistas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListarTerapistas.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnListarTerapistas.FlatAppearance.BorderSize = 0;
            this.btnListarTerapistas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarTerapistas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarTerapistas.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnListarTerapistas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListarTerapistas.Location = new System.Drawing.Point(439, 212);
            this.btnListarTerapistas.Name = "btnListarTerapistas";
            this.btnListarTerapistas.Size = new System.Drawing.Size(43, 29);
            this.btnListarTerapistas.TabIndex = 40;
            this.btnListarTerapistas.Text = "...";
            this.btnListarTerapistas.UseVisualStyleBackColor = false;
            this.btnListarTerapistas.Click += new System.EventHandler(this.btnListarTerapistas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "Hora: ";
            // 
            // dtpSesion
            // 
            this.dtpSesion.Location = new System.Drawing.Point(192, 253);
            this.dtpSesion.Name = "dtpSesion";
            this.dtpSesion.Size = new System.Drawing.Size(231, 20);
            this.dtpSesion.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(341, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 15);
            this.label3.TabIndex = 130;
            this.label3.Text = "m";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(250, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 15);
            this.label7.TabIndex = 129;
            this.label7.Text = "h";
            // 
            // cboMinuto
            // 
            this.cboMinuto.FormattingEnabled = true;
            this.cboMinuto.Items.AddRange(new object[] {
            "00",
            "30"});
            this.cboMinuto.Location = new System.Drawing.Point(279, 295);
            this.cboMinuto.Name = "cboMinuto";
            this.cboMinuto.Size = new System.Drawing.Size(56, 21);
            this.cboMinuto.TabIndex = 128;
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
            "20"});
            this.cboHora.Location = new System.Drawing.Point(188, 295);
            this.cboHora.Name = "cboHora";
            this.cboHora.Size = new System.Drawing.Size(56, 21);
            this.cboHora.TabIndex = 127;
            // 
            // frmDetalleSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 436);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboMinuto);
            this.Controls.Add(this.cboHora);
            this.Controls.Add(this.dtpSesion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListarTerapistas);
            this.Controls.Add(this.txtNombreTerapista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNombreTerapista);
            this.Controls.Add(this.txtNumSesiones);
            this.Controls.Add(this.lblNumSesion);
            this.Controls.Add(this.txtNombreServicio);
            this.Controls.Add(this.lblNombreServicio);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Name = "frmDetalleSesion";
            this.Text = "frmDetalleSesion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblNombreServicio;
        private System.Windows.Forms.TextBox txtNombreServicio;
        private System.Windows.Forms.Label lblNumSesion;
        private System.Windows.Forms.TextBox txtNumSesiones;
        private System.Windows.Forms.Label lblNombreTerapista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreTerapista;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnListarTerapistas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpSesion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboMinuto;
        private System.Windows.Forms.ComboBox cboHora;
    }
}