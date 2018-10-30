using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace Formularios
{
    public partial class frmModificarFichaMedidas : Form
    {
        public frmModificarFichaMedidas(FichaMedida fm, Cliente c)
        {
            InitializeComponent();
            txtNombre.Text = c.Nombres + " " + c.ApPaterno + " " + c.ApMaterno;
            dateTimePicker1.Value = fm.Fecha;
            if(fm.Tipo == "ENDOMORFO")
            {
                cboTipoSomatico.Text = "ENDOMORFO";
            }
            if(fm.Tipo == "ECTOMORFO")
            {
                cboTipoSomatico.Text = "ECTOMORFO";
            }
            if(fm.Tipo == "MESOMORFO")
            {
                cboTipoSomatico.Text = "MESOMORFO";
            }
            txtPeso.Text = Convert.ToString(fm.Peso);
            txtEspalda.Text = Convert.ToString(fm.Espalda);
            txtAbAlto.Text = Convert.ToString(fm.AbdomenAlto);
            txtAbBajo.Text = Convert.ToString(fm.AbdomenBajo);
            txtCintura.Text = Convert.ToString(fm.Cintura);
            txtBrDer.Text = Convert.ToString(fm.BrazoDerecho);
            txtBrIzq.Text = Convert.ToString(fm.BrazoIzquierdo);
            txtGluteos.Text = Convert.ToString(fm.Gluteos);
            txtPierDer.Text = Convert.ToString(fm.PiernaDer);
            txtIzq.Text = Convert.ToString(fm.PiernaIzq);

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
