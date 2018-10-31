namespace Formularios
{
    partial class frmGestionFichaMedidas
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevaFicha = new System.Windows.Forms.Button();
            this.lblFicha = new System.Windows.Forms.Label();
            this.CITAS = new System.Windows.Forms.Panel();
            this.columnasCitas = new System.Windows.Forms.DataGridView();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.espaldaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abdomenAltoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abdomenBajoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brazoDerechoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brazoIzquierdoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gluteosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piernaIzqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piernaDerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fichaMedidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblNomCliente = new System.Windows.Forms.Label();
            this.fichaMedidaBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fichaMedidaBLBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblNombreCli = new System.Windows.Forms.Label();
            this.CITAS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.columnasCitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fichaMedidaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fichaMedidaBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fichaMedidaBLBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Black;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(773, 515);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(167, 45);
            this.btnModificar.TabIndex = 19;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevaFicha
            // 
            this.btnNuevaFicha.BackColor = System.Drawing.Color.Black;
            this.btnNuevaFicha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaFicha.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnNuevaFicha.FlatAppearance.BorderSize = 0;
            this.btnNuevaFicha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaFicha.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaFicha.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnNuevaFicha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaFicha.Location = new System.Drawing.Point(773, 142);
            this.btnNuevaFicha.Name = "btnNuevaFicha";
            this.btnNuevaFicha.Size = new System.Drawing.Size(167, 45);
            this.btnNuevaFicha.TabIndex = 16;
            this.btnNuevaFicha.Text = "+ NUEVA FICHA";
            this.btnNuevaFicha.UseVisualStyleBackColor = false;
            this.btnNuevaFicha.Click += new System.EventHandler(this.btnNuevaFicha_Click);
            // 
            // lblFicha
            // 
            this.lblFicha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFicha.AutoSize = true;
            this.lblFicha.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFicha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFicha.Location = new System.Drawing.Point(657, 30);
            this.lblFicha.Name = "lblFicha";
            this.lblFicha.Size = new System.Drawing.Size(300, 44);
            this.lblFicha.TabIndex = 0;
            this.lblFicha.Text = "FICHA MEDIDAS";
            // 
            // CITAS
            // 
            this.CITAS.BackColor = System.Drawing.Color.YellowGreen;
            this.CITAS.Controls.Add(this.lblFicha);
            this.CITAS.Location = new System.Drawing.Point(-8, -3);
            this.CITAS.Name = "CITAS";
            this.CITAS.Size = new System.Drawing.Size(1201, 98);
            this.CITAS.TabIndex = 20;
            // 
            // columnasCitas
            // 
            this.columnasCitas.AutoGenerateColumns = false;
            this.columnasCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.columnasCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.pesoDataGridViewTextBoxColumn,
            this.espaldaDataGridViewTextBoxColumn,
            this.abdomenAltoDataGridViewTextBoxColumn,
            this.abdomenBajoDataGridViewTextBoxColumn,
            this.cinturaDataGridViewTextBoxColumn,
            this.brazoDerechoDataGridViewTextBoxColumn,
            this.brazoIzquierdoDataGridViewTextBoxColumn,
            this.gluteosDataGridViewTextBoxColumn,
            this.piernaIzqDataGridViewTextBoxColumn,
            this.piernaDerDataGridViewTextBoxColumn});
            this.columnasCitas.DataSource = this.fichaMedidaBindingSource;
            this.columnasCitas.Location = new System.Drawing.Point(129, 227);
            this.columnasCitas.Name = "columnasCitas";
            this.columnasCitas.Size = new System.Drawing.Size(811, 251);
            this.columnasCitas.TabIndex = 17;
            this.columnasCitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.columnasCitas_CellContentClick);
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            // 
            // pesoDataGridViewTextBoxColumn
            // 
            this.pesoDataGridViewTextBoxColumn.DataPropertyName = "Peso";
            this.pesoDataGridViewTextBoxColumn.HeaderText = "Peso";
            this.pesoDataGridViewTextBoxColumn.Name = "pesoDataGridViewTextBoxColumn";
            // 
            // espaldaDataGridViewTextBoxColumn
            // 
            this.espaldaDataGridViewTextBoxColumn.DataPropertyName = "Espalda";
            this.espaldaDataGridViewTextBoxColumn.HeaderText = "Espalda";
            this.espaldaDataGridViewTextBoxColumn.Name = "espaldaDataGridViewTextBoxColumn";
            // 
            // abdomenAltoDataGridViewTextBoxColumn
            // 
            this.abdomenAltoDataGridViewTextBoxColumn.DataPropertyName = "AbdomenAlto";
            this.abdomenAltoDataGridViewTextBoxColumn.HeaderText = "AbdomenAlto";
            this.abdomenAltoDataGridViewTextBoxColumn.Name = "abdomenAltoDataGridViewTextBoxColumn";
            // 
            // abdomenBajoDataGridViewTextBoxColumn
            // 
            this.abdomenBajoDataGridViewTextBoxColumn.DataPropertyName = "AbdomenBajo";
            this.abdomenBajoDataGridViewTextBoxColumn.HeaderText = "AbdomenBajo";
            this.abdomenBajoDataGridViewTextBoxColumn.Name = "abdomenBajoDataGridViewTextBoxColumn";
            // 
            // cinturaDataGridViewTextBoxColumn
            // 
            this.cinturaDataGridViewTextBoxColumn.DataPropertyName = "Cintura";
            this.cinturaDataGridViewTextBoxColumn.HeaderText = "Cintura";
            this.cinturaDataGridViewTextBoxColumn.Name = "cinturaDataGridViewTextBoxColumn";
            // 
            // brazoDerechoDataGridViewTextBoxColumn
            // 
            this.brazoDerechoDataGridViewTextBoxColumn.DataPropertyName = "BrazoDerecho";
            this.brazoDerechoDataGridViewTextBoxColumn.HeaderText = "BrazoDerecho";
            this.brazoDerechoDataGridViewTextBoxColumn.Name = "brazoDerechoDataGridViewTextBoxColumn";
            // 
            // brazoIzquierdoDataGridViewTextBoxColumn
            // 
            this.brazoIzquierdoDataGridViewTextBoxColumn.DataPropertyName = "BrazoIzquierdo";
            this.brazoIzquierdoDataGridViewTextBoxColumn.HeaderText = "BrazoIzquierdo";
            this.brazoIzquierdoDataGridViewTextBoxColumn.Name = "brazoIzquierdoDataGridViewTextBoxColumn";
            // 
            // gluteosDataGridViewTextBoxColumn
            // 
            this.gluteosDataGridViewTextBoxColumn.DataPropertyName = "Gluteos";
            this.gluteosDataGridViewTextBoxColumn.HeaderText = "Gluteos";
            this.gluteosDataGridViewTextBoxColumn.Name = "gluteosDataGridViewTextBoxColumn";
            // 
            // piernaIzqDataGridViewTextBoxColumn
            // 
            this.piernaIzqDataGridViewTextBoxColumn.DataPropertyName = "PiernaIzq";
            this.piernaIzqDataGridViewTextBoxColumn.HeaderText = "PiernaIzq";
            this.piernaIzqDataGridViewTextBoxColumn.Name = "piernaIzqDataGridViewTextBoxColumn";
            // 
            // piernaDerDataGridViewTextBoxColumn
            // 
            this.piernaDerDataGridViewTextBoxColumn.DataPropertyName = "PiernaDer";
            this.piernaDerDataGridViewTextBoxColumn.HeaderText = "PiernaDer";
            this.piernaDerDataGridViewTextBoxColumn.Name = "piernaDerDataGridViewTextBoxColumn";
            // 
            // fichaMedidaBindingSource
            // 
            this.fichaMedidaBindingSource.DataSource = typeof(Modelo.FichaMedida);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Black;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(132, 515);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(167, 45);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblNomCliente
            // 
            this.lblNomCliente.AutoSize = true;
            this.lblNomCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomCliente.Location = new System.Drawing.Point(128, 155);
            this.lblNomCliente.Name = "lblNomCliente";
            this.lblNomCliente.Size = new System.Drawing.Size(162, 21);
            this.lblNomCliente.TabIndex = 24;
            this.lblNomCliente.Text = "Nombre del cliente:";
            // 
            // fichaMedidaBLBindingSource
            // 
            this.fichaMedidaBLBindingSource.DataSource = typeof(LogicaNegocio.FichaMedidaBL);
            // 
            // fichaMedidaBLBindingSource1
            // 
            this.fichaMedidaBLBindingSource1.DataSource = typeof(LogicaNegocio.FichaMedidaBL);
            // 
            // lblNombreCli
            // 
            this.lblNombreCli.AutoSize = true;
            this.lblNombreCli.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCli.Location = new System.Drawing.Point(296, 155);
            this.lblNombreCli.Name = "lblNombreCli";
            this.lblNombreCli.Size = new System.Drawing.Size(0, 21);
            this.lblNombreCli.TabIndex = 25;
            // 
            // frmGestionFichaMedidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 600);
            this.Controls.Add(this.lblNombreCli);
            this.Controls.Add(this.lblNomCliente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.columnasCitas);
            this.Controls.Add(this.btnNuevaFicha);
            this.Controls.Add(this.CITAS);
            this.Name = "frmGestionFichaMedidas";
            this.Text = "frmGestionFichaMedidas";
            this.CITAS.ResumeLayout(false);
            this.CITAS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.columnasCitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fichaMedidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fichaMedidaBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fichaMedidaBLBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevaFicha;
        private System.Windows.Forms.Label lblFicha;
        private System.Windows.Forms.Panel CITAS;
        private System.Windows.Forms.DataGridView columnasCitas;
        private System.Windows.Forms.BindingSource fichaMedidaBLBindingSource;
        private System.Windows.Forms.BindingSource fichaMedidaBLBindingSource1;
        private System.Windows.Forms.BindingSource fichaMedidaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn espaldaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn abdomenAltoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn abdomenBajoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brazoDerechoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brazoIzquierdoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gluteosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn piernaIzqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn piernaDerDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblNomCliente;
        private System.Windows.Forms.Label lblNombreCli;
    }
}