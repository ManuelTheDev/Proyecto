using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            

            LoginBL usuario = new LoginBL();

            if (txtUsuario.Text == "INGRESE USUARIO" && txtContrasenia.Text=="INGRESE CONTRASEÑA")
            {
                lblErrorUsuario.Text = "Ingrese su usuario";
                lblErrorUsuario.Visible = true;
                lblErrorPass.Text = "Ingrese su contraseña";
                lblErrorPass.Visible = true;

            }
            else if (txtContrasenia.Text == "INGRESE CONTRASEÑA")
            {
                lblErrorPass.Text = "Ingrese su contraseña";
                lblErrorPass.Visible = true; 
            }
            else if (txtUsuario.Text == "INGRESE CONTRASEÑA")
            {
                lblErrorUsuario.Text = "Ingrese su usuario";
                lblErrorUsuario.Visible = true;
            }

            int tipo = -1; 
            if (txtContrasenia.Text!= "INGRESE USUARIO" && txtUsuario.Text != "INGRESE CONTRASEÑA")
            {
                if (!usuario.iniciar_sesion(txtUsuario.Text, txtContrasenia.Text, ref tipo))
                {
                    MessageBox.Show("El usuario y/o la contraseña son incorrectos.",
                    "Iniciar Sesion", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                else
                {

                    Form1 frmPrincipal = new Form1(tipo);
                    frmPrincipal.ShowDialog();
                    this.Dispose();
                }

            }
            
            
        }

        private void txtContrasenia_Enter(object sender, EventArgs e)
        {
            if (txtContrasenia.Text == "INGRESE CONTRASEÑA")
            {
                txtContrasenia.Text = "";
                txtContrasenia.ForeColor = Color.OliveDrab;
                txtContrasenia.UseSystemPasswordChar = true; 
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "INGRESE USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.OliveDrab;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "INGRESE USUARIO";
                txtUsuario.ForeColor = Color.LightGray;
                lblErrorUsuario.Visible = false;
            }
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose(); 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtContrasenia_Leave(object sender, EventArgs e)
        {
            if (txtContrasenia.Text=="INGRESE CONTRASEÑA")
            {
                txtContrasenia.Text = "";
                txtContrasenia.ForeColor = Color.LightGray;
                txtContrasenia.UseSystemPasswordChar = false;
                lblErrorPass.Visible = false;
            }
        }
    }
}
