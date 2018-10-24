using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Formularios
{
    public partial class Form1 : Form
    {
        private static frmGestionTratamientos fgt;
        private static frmGestionCitas fgcitas;
        private static frmGestionFichaMedidas fgf;
        private static frmGestionPacientes fgpacientes;
        private static frmGestionPaquetes fgpaquetes;
        private static frmGestionTerapistas frterapista;
        private static frmGestionUsuarios fgu;

        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void slideMenu_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 271)
            {
                MenuVertical.Width = 68;
            }
            else
                MenuVertical.Width = 271;
        }

        private void imagenCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void imagenMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            imagenRestaurar.Visible = true;
            imagenMaximizar.Visible = false;
        }

        private void imagenMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void imagenRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            imagenRestaurar.Visible = false;
            imagenMaximizar.Visible = true;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

       
      
        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AbrirFormInPanel(object FormHijo)
        {
            if (this.panelContedor.Controls.Count > 0)
                this.panelContedor.Controls.RemoveAt(0);
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContedor.Controls.Add(fh);
            this.panelContedor.Tag = fh;
            fh.Show();
        }
        private void CLIENTES_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmGestionPacientes());
        }

        private void INICIO_Click(object sender, EventArgs e)
        {
            foreach(Form f in panelContedor.Controls)
            {
                f.Dispose();

            }
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, -3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1271, 750);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            panelContedor.Controls.Add(pictureBox2);

        }

        private void TRATAMIENTOS_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmGestionTratamientos());
        }


        private void CITAS_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmGestionCitas());
        }

        private void PAQUETES_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmGestionPaquetes());
        }

        private void FichaMedidas_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmGestionFichaMedidas());
        }

        private void TERAPISTAS_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmGestionTerapistas());
        }

        private void USUARIOS_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmGestionUsuarios());
        }
    }
}
