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

             if (!usuario.iniciar_sesion(txtUsuario.Text, txtContrasenia.Text))
            {
                MessageBox.Show("El usuario y/o la contraseña son incorrectos.",
                "Iniciar Sesion", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            } 
             else
            {
                
                Form1 frmPrincipal = new Form1();
                frmPrincipal.ShowDialog();
   
            }
            
        }

        private void txtContrasenia_Enter(object sender, EventArgs e)
        {
            if (txtContrasenia.Text == "")
            {
                txtContrasenia.UseSystemPasswordChar = true; 
            }
        }
    }
}
